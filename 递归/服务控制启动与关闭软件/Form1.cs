using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 服务控制启动与关闭软件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ServiceController[] Services = ServiceController.GetServices();  
        private bool ExistSth()
        {
            bool exist = false;
            for (int i = 0; i < Services.Length; i++)
            {
                if (Services[i].DisplayName.ToLower().ToString() == textBox1.Text.ToLower().ToString())
                    exist = true;
            }
            return exist;
        }

        private bool GetServiceName(string serviceName) 
        {
            bool isServiceName = false;
            for (int i = 0; i < listBox1.Items.Count; i++)
			{
			    if(listBox1.Items[i].ToString()==serviceName)
                {
                    isServiceName= true;
                }
			}
            return isServiceName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ExistSth())
                MessageBox.Show("已安装");
            else
                MessageBox.Show("未安装");  
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Services.Length; i++)
                listBox1.Items.Add(Services[i].DisplayName.ToString());  
        }
        private ServiceController _controller;  
        private void btn_Start_Click(object sender, EventArgs e)
        {
            this._controller = new ServiceController(textBox1.Text.Trim());
            this._controller.Start();
            this._controller.WaitForStatus(ServiceControllerStatus.Running);
            this._controller.Close();
            if (this._controller.Status == ServiceControllerStatus.Running)
            {
                MessageBox.Show("启动成功");
            }
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            this._controller = new ServiceController(textBox1.Text.Trim());
            this._controller.Stop();
            this._controller.WaitForStatus(ServiceControllerStatus.Stopped);
            this._controller.Close();
            if (this._controller.Status == ServiceControllerStatus.Stopped)
            {
                MessageBox.Show("停止成功");
            }
        }

        private void btn_ReStart_Click(object sender, EventArgs e)
        {
            this._controller = new ServiceController(textBox1.Text.Trim());
            this._controller.Stop();
            this._controller.WaitForStatus(ServiceControllerStatus.Stopped);
            this._controller.Start();
            this._controller.WaitForStatus(ServiceControllerStatus.Running);
            this._controller.Close();
            if (this._controller.Status == ServiceControllerStatus.Running)
            {
                MessageBox.Show("重启成功");
            }
        }

        private void btn_GetServiceName_Click(object sender, EventArgs e)
        {
            textBox1.Text= listBox1.SelectedItem.ToString();
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = listBox1.SelectedItem.ToString();
        }


    }
}
