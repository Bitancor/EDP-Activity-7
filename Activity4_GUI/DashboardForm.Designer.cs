namespace Activity4_GUI
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            linkLabel1 = new LinkLabel();
            aboutLink = new LinkLabel();
            reportsLink = new LinkLabel();
            pictureBox1 = new PictureBox();
            exitBtn = new Button();
            panel1 = new Panel();
            exportLink = new LinkLabel();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            accountsLink = new LinkLabel();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Names = new DataGridViewTextBoxColumn();
            Section = new DataGridViewTextBoxColumn();
            GWA = new DataGridViewTextBoxColumn();
            Clubs = new DataGridViewTextBoxColumn();
            Fee = new DataGridViewTextBoxColumn();
            panel6 = new Panel();
            label7 = new Label();
            label4 = new Label();
            panel5 = new Panel();
            label6 = new Label();
            label3 = new Label();
            panel4 = new Panel();
            label5 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(45, 140);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(97, 21);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Dashboard";
            // 
            // aboutLink
            // 
            aboutLink.AutoSize = true;
            aboutLink.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            aboutLink.LinkColor = Color.White;
            aboutLink.Location = new Point(45, 182);
            aboutLink.Name = "aboutLink";
            aboutLink.Size = new Size(61, 21);
            aboutLink.TabIndex = 1;
            aboutLink.TabStop = true;
            aboutLink.Text = "About";
            // 
            // reportsLink
            // 
            reportsLink.AutoSize = true;
            reportsLink.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reportsLink.LinkColor = Color.White;
            reportsLink.Location = new Point(45, 221);
            reportsLink.Name = "reportsLink";
            reportsLink.Size = new Size(69, 21);
            reportsLink.TabIndex = 2;
            reportsLink.TabStop = true;
            reportsLink.Text = "Reports";
            reportsLink.LinkClicked += reportsLink_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(45, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(79, 81);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(36, 359);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(97, 31);
            exitBtn.TabIndex = 4;
            exitBtn.Text = "Logout";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(exportLink);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(accountsLink);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(exitBtn);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(aboutLink);
            panel1.Controls.Add(reportsLink);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(178, 443);
            panel1.TabIndex = 5;
            // 
            // exportLink
            // 
            exportLink.AutoSize = true;
            exportLink.Font = new Font("Century Gothic", 12F);
            exportLink.LinkColor = Color.White;
            exportLink.Location = new Point(45, 307);
            exportLink.Name = "exportLink";
            exportLink.Size = new Size(66, 21);
            exportLink.TabIndex = 11;
            exportLink.TabStop = true;
            exportLink.Text = "Exports";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(18, 307);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(24, 27);
            pictureBox6.TabIndex = 10;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.InitialImage = (Image)resources.GetObject("pictureBox5.InitialImage");
            pictureBox5.Location = new Point(18, 264);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(24, 27);
            pictureBox5.TabIndex = 9;
            pictureBox5.TabStop = false;
            // 
            // accountsLink
            // 
            accountsLink.AutoSize = true;
            accountsLink.Font = new Font("Century Gothic", 12F);
            accountsLink.LinkColor = Color.White;
            accountsLink.Location = new Point(45, 263);
            accountsLink.Name = "accountsLink";
            accountsLink.Size = new Size(86, 21);
            accountsLink.TabIndex = 8;
            accountsLink.TabStop = true;
            accountsLink.Text = "Accounts";
            accountsLink.LinkClicked += accountsLink_LinkClicked;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(18, 182);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(24, 27);
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(18, 221);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(24, 27);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(18, 142);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 27);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(61, 90, 128);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(184, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(579, 63);
            panel2.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(234, 21);
            label1.Name = "label1";
            label1.Size = new Size(113, 22);
            label1.TabIndex = 0;
            label1.Text = "Dashboard";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(152, 193, 217);
            panel3.Controls.Add(dataGridView1);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(184, 68);
            panel3.Name = "panel3";
            panel3.Size = new Size(579, 374);
            panel3.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Names, Section, GWA, Clubs, Fee });
            dataGridView1.Location = new Point(3, 72);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(571, 299);
            dataGridView1.TabIndex = 2;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // Names
            // 
            Names.HeaderText = "Name";
            Names.Name = "Names";
            // 
            // Section
            // 
            Section.HeaderText = "Section";
            Section.Name = "Section";
            // 
            // GWA
            // 
            GWA.HeaderText = "GWA";
            GWA.Name = "GWA";
            // 
            // Clubs
            // 
            Clubs.HeaderText = "Club";
            Clubs.Name = "Clubs";
            // 
            // Fee
            // 
            Fee.Name = "Fee";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(41, 50, 65);
            panel6.Controls.Add(label7);
            panel6.Controls.Add(label4);
            panel6.Location = new Point(389, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(187, 65);
            panel6.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 16F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(143, 31);
            label7.Name = "label7";
            label7.Size = new Size(36, 25);
            label7.TabIndex = 1;
            label7.Text = "50";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(15, 11);
            label4.Name = "label4";
            label4.Size = new Size(36, 17);
            label4.TabIndex = 0;
            label4.Text = "Staff";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(41, 50, 65);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(label3);
            panel5.Location = new Point(194, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(189, 65);
            panel5.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 16F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(146, 31);
            label6.Name = "label6";
            label6.Size = new Size(36, 25);
            label6.TabIndex = 1;
            label6.Text = "20";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 11);
            label3.Name = "label3";
            label3.Size = new Size(61, 17);
            label3.TabIndex = 0;
            label3.Text = "Teachers";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(41, 50, 65);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(185, 65);
            panel4.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 16F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(125, 31);
            label5.Name = "label5";
            label5.Size = new Size(48, 25);
            label5.TabIndex = 1;
            label5.Text = "200";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 11);
            label2.Name = "label2";
            label2.Size = new Size(60, 17);
            label2.TabIndex = 0;
            label2.Text = "Students";
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(764, 441);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private LinkLabel linkLabel1;
        private LinkLabel aboutLink;
        private LinkLabel reportsLink;
        private PictureBox pictureBox1;
        private Button exitBtn;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Label label7;
        private Label label4;
        private Label label6;
        private Label label3;
        private Label label5;
        private Label label2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Names;
        private DataGridViewTextBoxColumn Section;
        private DataGridViewTextBoxColumn GWA;
        private DataGridViewTextBoxColumn Clubs;
        private DataGridViewTextBoxColumn Fee;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox5;
        private LinkLabel accountsLink;
        private LinkLabel exportLink;
        private PictureBox pictureBox6;
    }
}