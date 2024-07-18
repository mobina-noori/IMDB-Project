using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IMDB
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label8.Text = "";
            if (textBox7.Text == textBox6.Text)
            {
                MyData md = new MyData();
                md.strsql = "insert into Users values(N'" + textBox1.Text + "',N'" +
                textBox2.Text + "',N'" + textBox3.Text + "',N'" + textBox4.Text + "','"+textBox6.Text+"','"+textBox5.Text+"',null)";
                md.ManData();
                MessageBox.Show("You are now in our family");

            }
            else label8.Text = "Re enter password is incorrect";
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
