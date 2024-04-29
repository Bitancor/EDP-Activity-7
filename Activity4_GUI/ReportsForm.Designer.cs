namespace Activity4_GUI
{
    partial class ReportsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportsForm));
            panel1 = new Panel();
            accountsLink = new LinkLabel();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            exitBtn = new Button();
            linkLabel3 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            dashboardLink = new LinkLabel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            clubExportBtn = new Button();
            payExportBtn = new Button();
            fullExportBtn = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            ReportsGridView = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ReportsGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(accountsLink);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(exitBtn);
            panel1.Controls.Add(linkLabel3);
            panel1.Controls.Add(linkLabel2);
            panel1.Controls.Add(dashboardLink);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(178, 443);
            panel1.TabIndex = 0;
            // 
            // accountsLink
            // 
            accountsLink.AutoSize = true;
            accountsLink.Font = new Font("Century Gothic", 12F);
            accountsLink.LinkColor = Color.White;
            accountsLink.Location = new Point(45, 263);
            accountsLink.Name = "accountsLink";
            accountsLink.Size = new Size(86, 21);
            accountsLink.TabIndex = 9;
            accountsLink.TabStop = true;
            accountsLink.Text = "Accounts";
            accountsLink.LinkClicked += accountsLink_LinkClicked;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(18, 264);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(24, 27);
            pictureBox5.TabIndex = 8;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(18, 221);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(24, 27);
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(18, 182);
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
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel3.LinkColor = Color.White;
            linkLabel3.Location = new Point(45, 221);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(69, 21);
            linkLabel3.TabIndex = 3;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Reports";
            // 
            // linkLabel2
            // 
            linkLabel2.ActiveLinkColor = Color.White;
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel2.LinkColor = Color.White;
            linkLabel2.Location = new Point(45, 182);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(61, 21);
            linkLabel2.TabIndex = 2;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "About";
            // 
            // dashboardLink
            // 
            dashboardLink.ActiveLinkColor = Color.White;
            dashboardLink.AutoSize = true;
            dashboardLink.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dashboardLink.LinkColor = Color.White;
            dashboardLink.Location = new Point(45, 140);
            dashboardLink.Name = "dashboardLink";
            dashboardLink.Size = new Size(97, 21);
            dashboardLink.TabIndex = 1;
            dashboardLink.TabStop = true;
            dashboardLink.Text = "Dashboard";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(45, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(79, 81);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(61, 90, 128);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(184, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(579, 63);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(238, 22);
            label1.Name = "label1";
            label1.Size = new Size(79, 22);
            label1.TabIndex = 0;
            label1.Text = "Reports";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(152, 193, 217);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(ReportsGridView);
            panel3.Location = new Point(184, 68);
            panel3.Name = "panel3";
            panel3.Size = new Size(579, 374);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(41, 50, 65);
            panel4.Controls.Add(clubExportBtn);
            panel4.Controls.Add(payExportBtn);
            panel4.Controls.Add(fullExportBtn);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(4, 219);
            panel4.Name = "panel4";
            panel4.Size = new Size(572, 152);
            panel4.TabIndex = 1;
            // 
            // clubExportBtn
            // 
            clubExportBtn.Location = new Point(11, 103);
            clubExportBtn.Name = "clubExportBtn";
            clubExportBtn.Size = new Size(75, 25);
            clubExportBtn.TabIndex = 5;
            clubExportBtn.Text = "Export";
            clubExportBtn.UseVisualStyleBackColor = true;
            clubExportBtn.Click += clubExportBtn_Click;
            // 
            // payExportBtn
            // 
            payExportBtn.Location = new Point(11, 62);
            payExportBtn.Name = "payExportBtn";
            payExportBtn.Size = new Size(75, 25);
            payExportBtn.TabIndex = 4;
            payExportBtn.Text = "Export";
            payExportBtn.UseVisualStyleBackColor = true;
            payExportBtn.Click += payExportBtn_Click;
            // 
            // fullExportBtn
            // 
            fullExportBtn.Location = new Point(11, 21);
            fullExportBtn.Name = "fullExportBtn";
            fullExportBtn.Size = new Size(75, 25);
            fullExportBtn.TabIndex = 3;
            fullExportBtn.Text = "Export";
            fullExportBtn.UseVisualStyleBackColor = true;
            fullExportBtn.Click += fullExportBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(102, 105);
            label4.Name = "label4";
            label4.Size = new Size(109, 21);
            label4.TabIndex = 2;
            label4.Text = "Clubs Joined";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(102, 23);
            label3.Name = "label3";
            label3.Size = new Size(81, 21);
            label3.TabIndex = 1;
            label3.Text = "Full Table";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(102, 64);
            label2.Name = "label2";
            label2.Size = new Size(133, 21);
            label2.TabIndex = 0;
            label2.Text = "Payment Status";
            // 
            // ReportsGridView
            // 
            ReportsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ReportsGridView.Location = new Point(4, 3);
            ReportsGridView.Name = "ReportsGridView";
            ReportsGridView.Size = new Size(572, 213);
            ReportsGridView.TabIndex = 0;
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 441);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ReportsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reports";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ReportsGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private LinkLabel dashboardLink;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel3;
        private Button exitBtn;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private DataGridView ReportsGridView;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox5;
        private LinkLabel accountsLink;
        private Panel panel4;
        private Button clubExportBtn;
        private Button payExportBtn;
        private Button fullExportBtn;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}