using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IMDB
{
    public partial class AddDirector : Form
    {
        public AddDirector()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyData md = new MyData();
            md.strsql = "insert into Director values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox8.Text + "','" + textBox7.Text + "','" + textBox9.Text + "')";
            md.ManData();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
