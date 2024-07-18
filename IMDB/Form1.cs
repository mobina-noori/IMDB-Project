using System;
using System.Windows.Forms;

namespace IMDB
{
    public partial class Form1 : Form
    {
        public static string  type;
        public static string ID1,Name1,Family,imgID,Birth,Death,Bio,Gender;
        public static int ts;
        public Form1()
        {
            InitializeComponent();
        }
        string name,family;

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyData md = new MyData();
            int s;
                               md.strsql = "Select * from genre where Genre.Genre='"+comboBox2.SelectedItem+"'  ";
                    dataGridView1.DataSource = md.ShowData().DefaultView;
      
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MyData md = new MyData();
            int s;
            md.strsql = "select Actor.Name from Actor where Actor.ID in( select Actor.ID from Actor,Cast where Actor.Age>30 and Cast.Role='asli' and Cast.Actor=Actor.ID and Cast.Movie in(select Movie.ID from Movie where Movie.ID in (select count(award.Movie) from award group by award.Movie having COUNT(award.Movie)> 3)))  ";
            dataGridView1.DataSource = md.ShowData().DefaultView;
        }

        private void editInfosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Editing ed = new Editing();
            ed.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            f.ShowDialog();


        }

        private void button2_Click(object sender, EventArgs e)
        {            

            SignUp f = new SignUp();
            f.ShowDialog();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MyData md = new MyData();
            md.strsql = "select Name,Release,Genre from Movie";
            editInfosToolStripMenuItem.Visible = false;
            dataGridView1.DataSource = md.ShowData().DefaultView;
            if(Login.s!=0)
            {
                button2.Visible = false;
                    button1.Visible = false;
                editInfosToolStripMenuItem.Visible = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
             case   0:
                    md.strsql = "Select Name,Release,Genre from Movie where Name like '%" + textBox1.Text + "%'";
                    dataGridView1.DataSource = md.ShowData().DefaultView;break;
                case 1:
                    md.strsql = "Select Name,Family from Actor where Name like '%" + textBox1.Text + "%'";
                    dataGridView1.DataSource = md.ShowData().DefaultView; break;
                case 2:
                    md.strsql = "Select Name,Family from Director where Name like '%" + textBox1.Text + "%'";
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
                    md.strsql = "Select Name,Release,Genre from Movie ";
                    dataGridView1.DataSource = md.ShowData().DefaultView; break;
                case 1:
                    md.strsql = "Select Name,Family from Actor";
                    dataGridView1.DataSource = md.ShowData().DefaultView; break;
                case 2:
                    md.strsql = "Select Name,Family from Director";
                    dataGridView1.DataSource = md.ShowData().DefaultView; break;

            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            MyData md = new MyData();
            int s = comboBox1.SelectedIndex;
            name = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            family = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            DataGridView d2 = new DataGridView();
            switch (s)
            {
                case 0: md.strsql = "Select Movie.ID, Movie.ImgID, Movie.Name,Movie.Release,Movie.about,Movie.Genre,Movie.[Runng Time],Director.Name as n1,Director.Family from Movie,Director"+
" where  Movie.Name = '"+name+"'and Movie.Release='"+family+"' and Director.ID = Movie.Director";

                    d2.DataSource = md.ShowData().DefaultView;
                    d2.Size = new System.Drawing.Size(1000, 1000);
                    d2.Left = 100;
                    d2.Top = 100;

                    this.Controls.Add(d2);
                    d2.Visible = false;
                    type = "Movie";
                    ID1= d2.Rows[0].Cells["ID"].Value.ToString();
                    Name1 = d2.Rows[0].Cells["Name"].Value.ToString();
                    Family = d2.Rows[0].Cells["Release"].Value.ToString();
                    imgID = d2.Rows[0].Cells["ImgID"].Value.ToString();
                    Birth = d2.Rows[0].Cells["Runng Time"].Value.ToString();
                    Death = d2.Rows[0].Cells["n1"].Value.ToString() +"  "+ d2.Rows[0].Cells["Family"].Value.ToString();
                    Bio = d2.Rows[0].Cells["about"].Value.ToString();
                    Gender = d2.Rows[0].Cells["Genre"].Value.ToString();
                    ts = Convert.ToInt32(ID1);
                    break;
                case 1: md.strsql = "Select * from Actor where Name='" + name + "'and Family ='" + family + "'";

                    d2.DataSource = md.ShowData().DefaultView;
                    d2.Size = new System.Drawing.Size(1000, 1000);
                    d2.Left = 100;
                    d2.Top = 100;

                    this.Controls.Add(d2);
                    d2.Visible = false;
                    type = "Actor";
                    ID1 = d2.Rows[0].Cells["ID"].Value.ToString();

                    Name1 = d2.Rows[0].Cells["Name"].Value.ToString();
                    Family = d2.Rows[0].Cells["Family"].Value.ToString();
                    imgID = d2.Rows[0].Cells["imgID"].Value.ToString();
                    Birth = d2.Rows[0].Cells["Birth"].Value.ToString();
                    Death = d2.Rows[0].Cells["Death"].Value.ToString();
                    Bio = d2.Rows[0].Cells["Bio"].Value.ToString();
                    Gender = d2.Rows[0].Cells["Gender"].Value.ToString();

                    break;
                case 2: md.strsql = "Select * from Director where Name='" + name + "'and Family ='" + family + "'";

                    d2.DataSource = md.ShowData().DefaultView;
                    d2.Size = new System.Drawing.Size(1000, 1000);
                    d2.Left = 100;
                    d2.Top = 100;

                    this.Controls.Add(d2);
                    d2.Visible = false;
                    type = "Director";
                    ID1 = d2.Rows[0].Cells["ID"].Value.ToString();
                    Name1 = d2.Rows[0].Cells["Name"].Value.ToString();
                    Family = d2.Rows[0].Cells["Family"].Value.ToString();
                    imgID = d2.Rows[0].Cells["imgID"].Value.ToString();
                    Birth = d2.Rows[0].Cells["Birth"].Value.ToString();
                    Death = d2.Rows[0].Cells["Death"].Value.ToString();
                    Bio = d2.Rows[0].Cells["Bio"].Value.ToString();
                    break;

            }

            DataShow ds = new DataShow();
            ds.ShowDialog();
            
         

        }
    }
}
