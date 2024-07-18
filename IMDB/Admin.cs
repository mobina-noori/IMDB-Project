using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IMDB
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            MyData md = new MyData();
            md.strsql = "select * from Movie";
          
            dataGridView1.DataSource = md.ShowData().DefaultView;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MyData md = new MyData();
            MyData md1 = new MyData();
            DataGridView d2 = new DataGridView();

            int s;
            s = comboBox1.SelectedIndex;
            switch (s)
            {
                case 0:
                    md.strsql = "Select * from Movie where Name like '%" + textBox1.Text + "%'";
                    dataGridView1.DataSource = md.ShowData().DefaultView; break;
                case 1:
                    md.strsql = "Select * from Actor where Name like '%" + textBox1.Text + "%'";
                    dataGridView1.DataSource = md.ShowData().DefaultView; break;
                case 2:
                    md.strsql = "Select * from Director where Name like '%" + textBox1.Text + "%'";
                    dataGridView1.DataSource = md.ShowData().DefaultView; break;
                case 3:
                    md.strsql = "Select * from Users where Name like '%" + textBox1.Text + "%'";
                    dataGridView1.DataSource = md.ShowData().DefaultView; break;

            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyData md = new MyData();
            int s;
            s = comboBox1.SelectedIndex;
            switch (s)
            {
                case 0:
                    md.strsql = "Select * from Movie ";
                    dataGridView1.DataSource = md.ShowData().DefaultView; break;
                case 1:
                    md.strsql = "Select * from Actor";
                    dataGridView1.DataSource = md.ShowData().DefaultView; break;
                case 2:
                    md.strsql = "Select * from Director";
                    dataGridView1.DataSource = md.ShowData().DefaultView; break;
                case 3:
                    md.strsql = "Select * from Users";
                    dataGridView1.DataSource = md.ShowData().DefaultView; break;

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int s;
            name1.Text = " ";
            Email.Text = " ";
            pass.Text = " ";
            Birth.Text = " ";
            Bio.Text = " ";
            imgID.Text = " ";
            Death.Text = " ";

            s = comboBox1.SelectedIndex;
            if (s == 0)
            {
                label2.Text = "Name";
                label3.Text = "Release";
                un.Text = "ImgID";
                eml.Text = "Director";
                im.Text = "Running Time";
                de.Text = "Genre";
                bir.Text = " ";
                pss.Text = " ";
               
                bi.Text = "about";

                name1.Text = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
                Family.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

                Email.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                Username.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

                imgID.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                Death.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                Bio.Text = dataGridView1.CurrentRow.Cells["about"].Value.ToString();

                textBox2.Text =  dataGridView1.CurrentRow.Cells[7].Value.ToString();

            }
            else
            {
                if (s == 3)
                {
                    de.Text = "";
                    bi.Text = "";
                    label2.Text = "Name"; name1.Text = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
                    label3.Text = "Family"; Family.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

                    un.Text = "UserName"; Email.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
                    eml.Text = "Email"; Username.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

                    im.Text = "Image Id"; pass.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    bir.Text = "BirthDay"; imgID.Text = dataGridView1.CurrentRow.Cells["ImgID"].Value.ToString();
                    pss.Text = "PassWord"; Death.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                    textBox2.Text = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
                    Birth.Text = dataGridView1.CurrentRow.Cells["Birth"].Value.ToString();
                }
                else
                {
                    label2.Text = "Name"; name1.Text = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
                    label3.Text = "Family"; Family.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

                    un.Text = "UserName"; Email.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
                    eml.Text = "Email"; Username.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

                    im.Text = "Image Id"; pass.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    de.Text = "Death"; Birth.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    bi.Text = "Bio"; Bio.Text = dataGridView1.CurrentRow.Cells["Bio"].Value.ToString();
                    bir.Text = "BirthDay"; imgID.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                    pss.Text = "PassWord";
                    Death.Text = dataGridView1.CurrentRow.Cells["Death"].Value.ToString();
                    textBox2.Text = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
                }
                }



        }

        private void im_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyData md = new MyData();
            int s;
            s = comboBox1.SelectedIndex;

            switch (s) 
                {
                case 0:
                    md.strsql = "delete from Movie where ID = '"+Login.id+"'";
                    break;
                case 1:
                    md.strsql = "delete from Actor where ID = '" + Login.id + "'";
                    break;
                case 2:
                    md.strsql = "delete from Director where ID = '" + Login.id + "'";
                    md.ManData();
                    break;

            }
            md.ManData();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyData md = new MyData();
            int s;
            s = comboBox1.SelectedIndex;

            switch (s)
            {
                case 0:
                    md.strsql = "delete from Movie where ID = '" + textBox2.Text + "'";
                    break;
                case 1:
                    md.strsql = "delete from Actor where ID = '" + textBox2.Text + "'";
                    break;
                case 2:
                    md.strsql = "delete from Director where ID = '" + textBox2.Text + "'";
                    break;

            }
            md.ManData();
        }

        private void movieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMovie am = new AddMovie();
            am.ShowDialog();
        }

        private void actorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddActor aa = new AddActor();
            aa.ShowDialog();
        }

        private void directorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDirector ad = new AddDirector();
            ad.ShowDialog();
        }

        private void castToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCast ac = new AddCast();
            ac.ShowDialog();
        }
    }
}
