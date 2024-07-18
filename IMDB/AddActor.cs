using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IMDB
{
    public partial class AddActor : Form
    {
        public AddActor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyData md = new MyData();
            md.strsql = "insert into Actor values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox8.Text + "','"+textBox7.Text+"','"+textBox9.Text+"','"+comboBox1.SelectedItem.ToString()+"','"+textBox10.Text+"')";
            md.ManData();
        }
    }
}
