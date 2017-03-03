using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace 酒店管理系统
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlconn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                try 
                { 
                SqlCommand sqlcmd = sqlconn.CreateCommand();
                sqlcmd.CommandText = "SELECT * FROM 登录账户 WHERE ID='" + textBox1.Text + "'" + "AND PASSWORD='" + textBox2.Text + "'";
                sqlconn.Open();//===打开数据库连接======
                SqlDataReader dr = sqlcmd.ExecuteReader();
                if (dr.Read())
                {
                    MainForm.isRunMain = true;
                    MainForm M = new MainForm();
                    M.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("用户名或者密码错误,请重新输入！");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox1.Focus();
                }
                }
                catch(Exception E)
                {
                    MessageBox.Show(E.Message);
                }
              }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
     }
}
