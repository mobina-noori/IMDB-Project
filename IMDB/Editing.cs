using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IMDB
{
    public partial class Editing : Form
    {
        string password;
        public Editing()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Editing_Load(object sender, EventArgs e)
        {
            MyData md = new MyData();
            DataGridView d1 = new DataGridView();
            switch (Login.s)
            {
                case 1: md.strsql = "select * from Users where UserName='"+Login.id+"' ";
            d1.DataSource = md.ShowData().DefaultView;
                    this.Controls.Add(d1);
                    d1.Visible = false;
                    textBox1.Text = d1.Rows[0].Cells["Name"].Value.ToString();
                    textBox2.Text = d1.Rows[0].Cells["Family"].Value.ToString();
                    textBox3.Text = d1.Rows[0].Cells["Email"].Value.ToString();
                    textBox4.Text = d1.Rows[0].Cells["Birth"].Value.ToString();
                    textBox5.Text = d1.Rows[0].Cells["UserName"].Value.ToString();
                    textBox6.Text = d1.Rows[0].Cells["PassWord"].Value.ToString();
                    textBox7.Text = d1.Rows[0].Cells["PassWord"].Value.ToString();
                    password = d1.Rows[0].Cells["PassWord"].Value.ToString();
                    textBox10.Visible = false;label10.Visible = false;
                    textBox11.Visible = false;label11.Visible = false;
                    textBox9.Visible = false;label9.Visible = false;
                        break;


                case 2:
                    md.strsql = "select * from Actor where UserName='" + Login.id + "' ";
                    d1.DataSource = md.ShowData().DefaultView;
                    this.Controls.Add(d1);
                    d1.Visible = false;
                    textBox1.Text = d1.Rows[0].Cells["Name"].Value.ToString();
                    textBox2.Text = d1.Rows[0].Cells["Family"].Value.ToString();
                    textBox3.Text = d1.Rows[0].Cells["Email"].Value.ToString();
                    textBox4.Text = d1.Rows[0].Cells["Birth"].Value.ToString();
                    textBox5.Text = d1.Rows[0].Cells["UserName"].Value.ToString();
                    textBox6.Text = d1.Rows[0].Cells["PassWord"].Value.ToString();
                    textBox7.Text = d1.Rows[0].Cells["PassWord"].Value.ToString();
                    password = d1.Rows[0].Cells["PassWord"].Value.ToString();
                    textBox9.Text = d1.Rows[0].Cells["Death"].Value.ToString();
                    textBox10.Text = d1.Rows[0].Cells["Gender"].Value.ToString();
                    textBox11.Text = d1.Rows[0].Cells["Bio"].Value.ToString();
                    button2.Visible = false;
                    break;


                case 3:
                    md.strsql = "select * from Director where UserName='" + Login.id + "' ";
                    d1.DataSource = md.ShowData().DefaultView;
                    this.Controls.Add(d1);
                    d1.Visible = false;
                    textBox1.Text = d1.Rows[0].Cells["Name"].Value.ToString();
                    textBox2.Text = d1.Rows[0].Cells["Family"].Value.ToString();
                    textBox3.Text = d1.Rows[0].Cells["Email"].Value.ToString();
                    textBox4.Text = d1.Rows[0].Cells["Birth"].Value.ToString();
                    textBox5.Text = d1.Rows[0].Cells["UserName"].Value.ToString();
                    textBox6.Text = d1.Rows[0].Cells["PassWord"].Value.ToString();
                    textBox7.Text = d1.Rows[0].Cells["PassWord"].Value.ToString();
                    password = d1.Rows[0].Cells["PassWord"].Value.ToString();
                    textBox9.Text = d1.Rows[0].Cells["Death"].Value.ToString();
                    textBox10.Visible = false;label10.Visible = false;
                    textBox11.Text = d1.Rows[0].Cells["Bio"].Value.ToString();
                    button2.Visible = false;
                    break;
            }
       
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Login.s == 1)
            {
                if (textBox7.Text == textBox6.Text)
                {
                    if (password == textBox8.Text)
                    {
                        string message = "Are you sure you want to Update your information?";
                        string title = "Update";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttons);
                        if (result == DialogResult.Yes)
                        {

                            MyData md = new MyData();

                            md.strsql = "update Users set Name='" + textBox1.Text + "',Family='" + textBox2.Text + "',Email='" + textBox3.Text + "',Birth='" + textBox4.Text + "',UserName='" + textBox5.Text + "'" +
                                ",PassWord='" + textBox6.Text + "'where UserName ='" + Login.id + "'and PassWord='" + textBox8.Text + "'";
                            md.ManData();
                            string message1 = "updated successfully";
                            MessageBox.Show(message1);
                        }
                        else
                        {

                        }
                    }
                    else label8.Text = "PassWord is incorrect";


                }
                else label8.Text = "Re-Enter is incorrect";
            }
            if (Login.s == 2)
            {
                if (textBox7.Text == textBox6.Text)
                {
                    if (password == textBox8.Text)
                    {
                        string message = "Are you sure you want to Update your information?";
                        string title = "Update";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttons);
                        if (result == DialogResult.Yes)
                        {

                            MyData md = new MyData();

                            md.strsql = "update Actor set Name='" + textBox1.Text + "',Family='" + textBox2.Text + "',Email='" + textBox3.Text + "',Birth='" + textBox4.Text + "',UserName='" + textBox5.Text + "'" +
                                ",PassWord='" + textBox6.Text + "',Death='"+textBox9.Text+"',Gender='"+textBox10.Text+"',Bio='"+textBox11.Text+"'where UserName ='" + Login.id + "'and PassWord='" + textBox8.Text + "'";
                            md.ManData();
                            string message1 = "updated successfully";
                            MessageBox.Show(message1);
                        }
                        else
                        {

                        }
                    }
                    else label8.Text = "PassWord is incorrect";


                }
                else label8.Text = "Re-Enter is incorrect";
            }
            if (Login.s == 3)
            {
                if (textBox7.Text == textBox6.Text)
                {
                    if (password == textBox8.Text)
                    {
                        string message = "Are you sure you want to Update your information?";
                        string title = "Update";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttons);
                        if (result == DialogResult.Yes)
                        {

                            MyData md = new MyData();

                            md.strsql = "update Director set Name='" + textBox1.Text + "',Family='" + textBox2.Text + "',Email='" + textBox3.Text + "',Birth='" + textBox4.Text + "',UserName='" + textBox5.Text + "'" +
                                ",PassWord='" + textBox6.Text + "',Death='" + textBox9.Text + "',Bio='" + textBox11.Text + "'where UserName ='" + Login.id + "'and PassWord='" + textBox8.Text + "'";
                            md.ManData();
                            string message1 = "updated successfully";
                            MessageBox.Show(message1);
                        }
                        else
                        {

                        }
                    }
                    else label8.Text = "PassWord is incorrect";


                }
                else label8.Text = "Re-Enter is incorrect";
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to delete your account?";
            string title = "Delete";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                if (password == textBox8.Text)
                {
                    MyData md = new MyData();
                    md.strsql = "delete from Users where UserName='" + Login.id + "'";
                    md.ManData();
                    string message1 = "Deleted successfully";
                    MessageBox.Show(message1);
                  
                    Environment.Exit(1);                   
                }
                else label8.Text = "Password is incorrect";
            }
            else
            {
                
            }
            

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
