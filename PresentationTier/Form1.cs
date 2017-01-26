using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            this.Text = "Continue";
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
            groupBox1.Text = "Please sign in";

        }

        private void btn4_next_Click(object sender, EventArgs e)
        {
            this.Text = "Now viewing";
            label3.Hide();
            pictureBox2.Hide();
        }
    }
}
