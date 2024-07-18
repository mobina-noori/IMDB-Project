using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IMDB
{
    public partial class AddCast : Form
    {
        public AddCast()
        {
            InitializeComponent();
        }

        private void AddCast_Load(object sender, EventArgs e)
        {
            MyData md = new MyData();
            MyData md1 = new MyData();

            md.strsql = "select Name,Family,ID from Actor";

            dataGridView1.DataSource = md.ShowData().DefaultView;

           
            md1.strsql = "select Name,Release,ID from Movie";

            dataGridView2.DataSource = md1.ShowData().DefaultView;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MyData md = new MyData();
            md.strsql = "Select Name,Family,ID from Actor where Name like '%" + textBox1.Text + "%'";
            dataGridView1.DataSource = md.ShowData().DefaultView;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            MyData md = new MyData();
            md.strsql = "Select Name,Release,ID from Movie where Name like '%" + textBox2.Text + "%'";
            dataGridView2.DataSource = md.ShowData().DefaultView;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox3.Text = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox4.Text = dataGridView2.CurrentRow.Cells["ID"].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != " " && textBox4.Text != " ")
            {
                MyData md = new MyData();
                md.strsql = "insert into Cast values('" + textBox3.Text + "','" + textBox4.Text + "','"+comboBox1.SelectedItem+"')";
                md.ManData();
            }
            else
                MessageBox.Show("Fill the boxes");
        }
    }
}
