using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PresentationTier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Please sign in";
            label3.Hide();
            btn3_opt.Hide();
            btn4_next.Hide();
            pictureBox2.Hide();
            label1.Text = "User name:";
            label2.Text = "Password:";
            btn2_ok.Text = "Login";
            btn1_cancel.Text = "E&xit";
            groupBox1.Text = "Please sign in";
        }

        private void btn1_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn2_ok_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == String.Empty || txtPassword.Text == String.Empty)
            {
                MessageBox.Show("You must enter a user name and password to continue");
            }
            else
            {
                String UserName = txtUserName.Text.Trim();
                String Password = txtPassword.Text.Trim();
                preAuthentication(UserName, Password);
            }
        }
        private void preAuthentication(String UserName, String Password)
        {
            this.Text = "Welcome " + UserName;
        }
        private void postAuthentication(String UserName, String Password)
        {
            this.Text = "continue";
            label3.Show();
            btn3_opt.Show();
            btn4_next.Show();
            pictureBox2.Show(); // database picture retrieved from blog https://lazyprogrammer.me/category/databases/
            pictureBox1.Hide();
            groupBox1.Hide();
            btn2_ok.Hide();
            label1.Hide();
            label2.Hide();
            pictureBox1.Hide();
            label3.Text = "Please click Next to continue";
            label1.Text = "User name:";
            label2.Text = "Password:";
            btn3_opt.Text = "Back";
            btn4_next.Text = "&Next";
            btn1_cancel.Text = "E&xit";
        }

        //Authentication method
        private bool athenticateUser(string text1, string text2)
        {
            throw new NotImplementedException();
        }

        private void btn4_next_Click(object sender, EventArgs e)
        {
            this.Text = "Now viewing";
            label3.Hide();
            pictureBox2.Hide();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
