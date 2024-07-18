
namespace IMDB
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.name1 = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.Birth = new System.Windows.Forms.TextBox();
            this.Bio = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.Family = new System.Windows.Forms.TextBox();
            this.imgID = new System.Windows.Forms.TextBox();
            this.Death = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.un = new System.Windows.Forms.Label();
            this.eml = new System.Windows.Forms.Label();
            this.im = new System.Windows.Forms.Label();
            this.de = new System.Windows.Forms.Label();
            this.bir = new System.Windows.Forms.Label();
            this.pss = new System.Windows.Forms.Label();
            this.bi = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.castToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Movie",
            "Actor",
            "Director",
            "User"});
            this.comboBox1.Location = new System.Drawing.Point(318, 73);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(73, 28);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.Text = "Movie";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Search";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Location = new System.Drawing.Point(40, 74);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(179, 27);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 169);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(429, 544);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // name1
            // 
            this.name1.BackColor = System.Drawing.Color.Gold;
            this.name1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name1.Location = new System.Drawing.Point(616, 77);
            this.name1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.name1.Name = "name1";
            this.name1.Size = new System.Drawing.Size(195, 20);
            this.name1.TabIndex = 11;
            // 
            // Email
            // 
            this.Email.BackColor = System.Drawing.Color.Gold;
            this.Email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Email.Location = new System.Drawing.Point(616, 203);
            this.Email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(195, 20);
            this.Email.TabIndex = 12;
            // 
            // pass
            // 
            this.pass.BackColor = System.Drawing.Color.Gold;
            this.pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pass.Location = new System.Drawing.Point(616, 317);
            this.pass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(195, 20);
            this.pass.TabIndex = 13;
            // 
            // Birth
            // 
            this.Birth.BackColor = System.Drawing.Color.Gold;
            this.Birth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Birth.Location = new System.Drawing.Point(616, 381);
            this.Birth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Birth.Name = "Birth";
            this.Birth.Size = new System.Drawing.Size(195, 20);
            this.Birth.TabIndex = 14;
            // 
            // Bio
            // 
            this.Bio.BackColor = System.Drawing.Color.Gold;
            this.Bio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Bio.Location = new System.Drawing.Point(616, 567);
            this.Bio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Bio.Multiline = true;
            this.Bio.Name = "Bio";
            this.Bio.Size = new System.Drawing.Size(195, 117);
            this.Bio.TabIndex = 15;
            // 
            // Username
            // 
            this.Username.BackColor = System.Drawing.Color.Gold;
            this.Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Username.Location = new System.Drawing.Point(616, 255);
            this.Username.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(195, 20);
            this.Username.TabIndex = 18;
            // 
            // Family
            // 
            this.Family.BackColor = System.Drawing.Color.Gold;
            this.Family.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Family.Location = new System.Drawing.Point(616, 145);
            this.Family.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Family.Name = "Family";
            this.Family.Size = new System.Drawing.Size(195, 20);
            this.Family.TabIndex = 17;
            // 
            // imgID
            // 
            this.imgID.BackColor = System.Drawing.Color.Gold;
            this.imgID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.imgID.Location = new System.Drawing.Point(616, 491);
            this.imgID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.imgID.Name = "imgID";
            this.imgID.Size = new System.Drawing.Size(195, 20);
            this.imgID.TabIndex = 20;
            // 
            // Death
            // 
            this.Death.BackColor = System.Drawing.Color.Gold;
            this.Death.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Death.Location = new System.Drawing.Point(616, 433);
            this.Death.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Death.Name = "Death";
            this.Death.Size = new System.Drawing.Size(195, 20);
            this.Death.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(533, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(534, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Family :";
            // 
            // un
            // 
            this.un.AutoSize = true;
            this.un.Location = new System.Drawing.Point(534, 255);
            this.un.Name = "un";
            this.un.Size = new System.Drawing.Size(85, 20);
            this.un.TabIndex = 24;
            this.un.Text = "UserName :";
            // 
            // eml
            // 
            this.eml.AutoSize = true;
            this.eml.Location = new System.Drawing.Point(533, 203);
            this.eml.Name = "eml";
            this.eml.Size = new System.Drawing.Size(53, 20);
            this.eml.TabIndex = 23;
            this.eml.Text = "Email :";
            // 
            // im
            // 
            this.im.AutoSize = true;
            this.im.Location = new System.Drawing.Point(534, 509);
            this.im.Name = "im";
            this.im.Size = new System.Drawing.Size(57, 20);
            this.im.TabIndex = 28;
            this.im.Text = "imgID :";
            this.im.Click += new System.EventHandler(this.im_Click);
            // 
            // de
            // 
            this.de.AutoSize = true;
            this.de.Location = new System.Drawing.Point(534, 444);
            this.de.Name = "de";
            this.de.Size = new System.Drawing.Size(56, 20);
            this.de.TabIndex = 27;
            this.de.Text = "Death :";
            // 
            // bir
            // 
            this.bir.AutoSize = true;
            this.bir.Location = new System.Drawing.Point(534, 381);
            this.bir.Name = "bir";
            this.bir.Size = new System.Drawing.Size(47, 20);
            this.bir.TabIndex = 26;
            this.bir.Text = "Birth :";
            // 
            // pss
            // 
            this.pss.AutoSize = true;
            this.pss.Location = new System.Drawing.Point(534, 317);
            this.pss.Name = "pss";
            this.pss.Size = new System.Drawing.Size(77, 20);
            this.pss.TabIndex = 25;
            this.pss.Text = "Password :";
            // 
            // bi
            // 
            this.bi.AutoSize = true;
            this.bi.Location = new System.Drawing.Point(534, 567);
            this.bi.Name = "bi";
            this.bi.Size = new System.Drawing.Size(38, 20);
            this.bi.TabIndex = 29;
            this.bi.Text = "Bio :";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Gold;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(666, 16);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(114, 20);
            this.textBox2.TabIndex = 30;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(534, 653);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 31);
            this.button1.TabIndex = 31;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(725, 653);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 31);
            this.button2.TabIndex = 32;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(870, 30);
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.movieToolStripMenuItem,
            this.actorToolStripMenuItem,
            this.directorToolStripMenuItem,
            this.castToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // movieToolStripMenuItem
            // 
            this.movieToolStripMenuItem.Name = "movieToolStripMenuItem";
            this.movieToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.movieToolStripMenuItem.Text = "Movie";
            this.movieToolStripMenuItem.Click += new System.EventHandler(this.movieToolStripMenuItem_Click);
            // 
            // actorToolStripMenuItem
            // 
            this.actorToolStripMenuItem.Name = "actorToolStripMenuItem";
            this.actorToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.actorToolStripMenuItem.Text = "Actor";
            this.actorToolStripMenuItem.Click += new System.EventHandler(this.actorToolStripMenuItem_Click);
            // 
            // directorToolStripMenuItem
            // 
            this.directorToolStripMenuItem.Name = "directorToolStripMenuItem";
            this.directorToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.directorToolStripMenuItem.Text = "Director";
            this.directorToolStripMenuItem.Click += new System.EventHandler(this.directorToolStripMenuItem_Click);
            // 
            // castToolStripMenuItem
            // 
            this.castToolStripMenuItem.Name = "castToolStripMenuItem";
            this.castToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.castToolStripMenuItem.Text = "Cast";
            this.castToolStripMenuItem.Click += new System.EventHandler(this.castToolStripMenuItem_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(870, 729);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.bi);
            this.Controls.Add(this.im);
            this.Controls.Add(this.de);
            this.Controls.Add(this.bir);
            this.Controls.Add(this.pss);
            this.Controls.Add(this.un);
            this.Controls.Add(this.eml);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.imgID);
            this.Controls.Add(this.Death);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Family);
            this.Controls.Add(this.Bio);
            this.Controls.Add(this.Birth);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.name1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox name1;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox Birth;
        private System.Windows.Forms.TextBox Bio;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Family;
        private System.Windows.Forms.TextBox imgID;
        private System.Windows.Forms.TextBox Death;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label un;
        private System.Windows.Forms.Label eml;
        private System.Windows.Forms.Label im;
        private System.Windows.Forms.Label de;
        private System.Windows.Forms.Label bir;
        private System.Windows.Forms.Label pss;
        private System.Windows.Forms.Label bi;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem directorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem castToolStripMenuItem;
    }
}