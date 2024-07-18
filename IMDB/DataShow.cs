using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IMDB
{
    public partial class DataShow : Form
    {
        int co = 0;
        public DataShow()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataShow_Load(object sender, EventArgs e)
        {
            if(Form1.type=="Movie")
            {
             MyData m3 = new MyData();
            DataGridView dg = new DataGridView();
            m3.strsql = "Select AVG(Vote.Rate) as avg From Vote where Movie='"+Form1.ID1+"' ";
            dg.DataSource = m3.ShowData().DefaultView;
                this.Controls.Add(dg);
                label4.Text = dg.Rows[0].Cells["avg"].Value.ToString();
                dg.Visible = false;
            }
          
            button2.Visible = false;
            textBox2.Visible = false;
            button3.Visible = false;
            comboBox1.Visible = false;
            button4.Visible = false;

            try
                {
                pictureBox1.Image = new Bitmap(Form1.imgID);

                }
                catch { }
            
            NameFamily.Text = Form1.Name1 + Form1.Family;
            if (Form1.type == "Movie")
            {
                label1.Text = "Running Time: "+Form1.Birth;
               
               
              
                    label2.Text = "Director:" + Form1.Death;
                
                label3.Text = "Genre: " + Form1.Gender;
                textBox1.Text = Form1.Bio;
                textBox1.BorderStyle = BorderStyle.None;
                MyData md = new MyData();
                MyData md1 = new MyData();
                md.strsql = "Select Comment.comment ,Users.Name from Comment,Users where Movie ='" + Form1.ID1 + "'and Users.ID=Comment.Users  ";
                dataGridView1.DataSource = md.ShowData().DefaultView;
                dataGridView1.Visible = false;
                if (Login.s == 1)
                {
                    button2.Visible = true;
                }

            }
            else
            {
                button2.Visible = false;
                button3.Visible = false;
                label1.Text = "Birth: "+Form1.Birth;
                if (Form1.Death != "")
                {
                    label2.Text = "Died:" + Form1.Death;
                }
                textBox1.Text = Form1.Bio;
                textBox1.BorderStyle = BorderStyle.None;
                button1.Text = "Movies";
                if(Form1.type=="Actor")
                {
                    MyData md = new MyData();
                    md.strsql = "select Movie.Name,Movie.Release from Movie where ID in(Select Cast.Movie from Cast where Cast.Actor = '"+Form1.ID1+"')" ;
                    dataGridView1.DataSource = md.ShowData().DefaultView;
                    dataGridView1.Visible = false;
                }
                if (Form1.type == "Director")
                {
                    MyData md = new MyData();
                    md.strsql = "select Movie.Name,Movie.Release from Movie where Director in(Select Director.ID from Director where Director.ID ='" + Form1.ID1 + "')";
                    dataGridView1.DataSource = md.ShowData().DefaultView;
                    dataGridView1.Visible = false;
                }
            }
           


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            dataGridView1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (co % 2 == 0)
            {

                button2.Text = "close comment";
                textBox2.Visible = true;
                button3.Visible = true;
                comboBox1.Visible = true;
                button4.Visible = true;
            }
            else
            {
               
                button2.Text = "add comment";
                textBox2.Visible = false;
                button3.Visible = false;
                comboBox1.Visible = false;
                button4.Visible = false;
            }
            co++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MyData md = new MyData();
            md.strsql = "insert into Comment values('"+Login.ID+"','"+Form1.ID1+"','"+textBox2.Text+"')";
            md.ManData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i = comboBox1.SelectedIndex;
            i++;
            MyData md = new MyData();
          
            md.strsql = "insert into Vote values('"+Form1.ts+"','"  +Login.t +  "','" + i + "')";
            md.ManData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
