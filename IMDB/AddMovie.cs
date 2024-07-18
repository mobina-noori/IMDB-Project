using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IMDB
{
    public partial class AddMovie : Form
    {
        public AddMovie()
        {
            InitializeComponent();
        }

        private void AddMovie_Load(object sender, EventArgs e)
        {
            MyData md = new MyData();
            md.strsql = "select Name,Family,ID from Director";

            dataGridView1.DataSource = md.ShowData().DefaultView;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            MyData md = new MyData();
            MyData md1 = new MyData();
            md.strsql = "Select Name,Family,ID from Director where Name like '%" + textBox8.Text + "%'";
            dataGridView1.DataSource = md.ShowData().DefaultView;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox4.Text = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyData md = new MyData();
            md.strsql = "insert into Movie values('" + textBox1.Text + "','" +textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','"+textBox5.Text+"','"+textBox6.Text+"','"+textBox7.Text+"')";
            md.ManData();
        }

        private void Name1_Click(object sender, EventArgs e)
        {

        }
    }
}
