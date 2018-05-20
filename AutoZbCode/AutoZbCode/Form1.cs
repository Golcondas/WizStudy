using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace AutoZbCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_search_Click(object sender, EventArgs e)
        {
            using (IDbConnection connection = DapperSqlConnnection.OpenMysqlConnection())
            {
                string str = "SELECT * FROM dbmapping";
                var dt = connection.Query(str);

            }
        }
    }
}
