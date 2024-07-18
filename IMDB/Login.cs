using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.Resources;
using IMDB.Properties;

namespace IMDB
{
    public partial class Login : Form
    {
        public static int s = 0,t;
        public static String id,ID ;


        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MyData md = new MyData();

            SqlConnection con1 = new SqlConnection("server=(local);database=IMDB;integrated security=true");
            con1.Open();
            SqlCommand c1 = new SqlCommand();
            DataGridView d2 = new DataGridView();

            int i = comboBox1.SelectedIndex;
            switch (i)
            {
                case 0:
                    c1.CommandText = "select * from Users where UserName='" + textBox1.Text + "' and PassWord = '" + textBox2.Text + "'";
                   md.strsql= "select * from Users where UserName='" + textBox1.Text + "' and PassWord = '" + textBox2.Text + "'";
                    s = 1;
                    id =textBox1.Text;
                    break;
                case 1:
                    c1.CommandText = "select * from Actor where UserName='" + textBox1.Text + "' and Password = '" + textBox2.Text + "'";
                    md.strsql = "select * from Actor where UserName='" + textBox1.Text + "' and PassWord = '" + textBox2.Text + "'";

                    s = 2;
                    id = textBox1.Text;

                    break;
                case 2:
                   
                   c1.CommandText = "select * from Director where UserName='" + textBox1.Text + "' and PassWord = '" + textBox2.Text + "'";
                    md.strsql = "select * from Users where UserName='" + textBox1.Text + "' and PassWord = '" + textBox2.Text + "'";

                    s = 3;
                    id = textBox1.Text;

                    break;
                case 3:
                    c1.CommandText = "select * from Admin where UserName='" + textBox1.Text + "' and PassWord = '" + textBox2.Text + "'";
                    md.strsql = "select * from Users where UserName='" + textBox1.Text + "' and PassWord = '" + textBox2.Text + "'"; s = 4; break;
                    
                default: break;
            }

            c1.Connection = con1;
            SqlDataReader dr = c1.ExecuteReader();
            object[] x = new object[3];
            d2.DataSource = md.ShowData().DefaultView;
            d2.Size = new System.Drawing.Size(1000, 1000);
            d2.Left = 100;
            d2.Top = 100;

            this.Controls.Add(d2);
            d2.Visible = false;

            if (dr.Read())
            {
                ID = d2.Rows[0].Cells["ID"].Value.ToString();
                t = Convert.ToInt32(ID);
                if (s == 4)
                {
                    Admin a = new Admin();
                    a.ShowDialog();
                }
                else
                {
                Form1 f = new Form1();
                f.ShowDialog();
                }
                
            }
            con1.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
