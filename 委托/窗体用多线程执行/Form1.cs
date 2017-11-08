using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 窗体用多线程执行
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Task.Factory.StartNew(() =>
            //    {
            //        progressBar1.Value = 10;
            //    });
            //错误的写法：直接更新
            new Thread(() =>
            {
                progressBar1.Value = 10;
                label1.Text = "10";
            }).Start();
            var mainThread = Thread.CurrentThread;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //正确的写法：直接更新
            this.Invoke((EventHandler)delegate
            {
                progressBar1.Value = 10;
                label1.Text = "10";
            });
            label1.Text = "加载10完成";
            this.Invoke((EventHandler)delegate
            {
                progressBar1.Value = 11;
                label1.Text = "11";
            });
            label1.Text = "加载11完成";
            this.Invoke((EventHandler)delegate
            {
                progressBar1.Value = 12;
                label1.Text = "12";
            });
            label1.Text = "加载12完成";
            this.Invoke((EventHandler)delegate {
                progressBar1.Value = 100;
            });
        }
    }
}
