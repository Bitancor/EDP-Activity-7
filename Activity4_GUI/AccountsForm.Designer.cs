namespace Activity4_GUI
{
    partial class AccountsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountsForm));
            panel1 = new Panel();
            exitBtn = new Button();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            linkLabel4 = new LinkLabel();
            linkLabel3 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            dashboardLink = new LinkLabel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            panel5 = new Panel();
            updateBtn = new Button();
            newUsernameTxt = new TextBox();
            currentUsernameTxt = new TextBox();
            label5 = new Label();
            label2 = new Label();
            panel4 = new Panel();
            label4 = new Label();
            passwordTxt = new TextBox();
            label3 = new Label();
            usernameTxt = new TextBox();
            addBtn = new Button();
            searchBtn = new Button();
            accountsDataGridView = new DataGridView();
            searchboxTxt = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)accountsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(exitBtn);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(linkLabel4);
            panel1.Controls.Add(linkLabel3);
            panel1.Controls.Add(linkLabel2);
            panel1.Controls.Add(dashboardLink);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(178, 443);
            panel1.TabIndex = 0;
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(36, 359);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(97, 31);
            exitBtn.TabIndex = 9;
            exitBtn.Text = "Logout";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
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
            // linkLabel4
            // 
            linkLabel4.AutoSize = true;
            linkLabel4.Font = new Font("Century Gothic", 12F);
            linkLabel4.LinkColor = Color.White;
            linkLabel4.Location = new Point(45, 263);
            linkLabel4.Name = "linkLabel4";
            linkLabel4.Size = new Size(86, 21);
            linkLabel4.TabIndex = 4;
            linkLabel4.TabStop = true;
            linkLabel4.Text = "Accounts";
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Font = new Font("Century Gothic", 12F);
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
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Century Gothic", 12F);
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
            dashboardLink.AutoSize = true;
            dashboardLink.Font = new Font("Century Gothic", 12F);
            dashboardLink.LinkColor = Color.White;
            dashboardLink.Location = new Point(45, 140);
            dashboardLink.Name = "dashboardLink";
            dashboardLink.Size = new Size(97, 21);
            dashboardLink.TabIndex = 1;
            dashboardLink.TabStop = true;
            dashboardLink.Text = "Dashboard";
            dashboardLink.LinkClicked += dashboardLink_LinkClicked;
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
            label1.Font = new Font("Century Gothic", 14.25F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(183, 21);
            label1.Name = "label1";
            label1.Size = new Size(225, 22);
            label1.TabIndex = 0;
            label1.Text = "Account Management";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(152, 193, 217);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(searchBtn);
            panel3.Controls.Add(accountsDataGridView);
            panel3.Controls.Add(searchboxTxt);
            panel3.Location = new Point(184, 68);
            panel3.Name = "panel3";
            panel3.Size = new Size(579, 374);
            panel3.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(41, 50, 65);
            panel5.Controls.Add(updateBtn);
            panel5.Controls.Add(newUsernameTxt);
            panel5.Controls.Add(currentUsernameTxt);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(label2);
            panel5.Location = new Point(283, 259);
            panel5.Name = "panel5";
            panel5.Size = new Size(293, 112);
            panel5.TabIndex = 15;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(122, 77);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(95, 30);
            updateBtn.TabIndex = 4;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // newUsernameTxt
            // 
            newUsernameTxt.Location = new Point(122, 45);
            newUsernameTxt.Name = "newUsernameTxt";
            newUsernameTxt.Size = new Size(165, 23);
            newUsernameTxt.TabIndex = 3;
            // 
            // currentUsernameTxt
            // 
            currentUsernameTxt.Location = new Point(122, 11);
            currentUsernameTxt.Name = "currentUsernameTxt";
            currentUsernameTxt.Size = new Size(165, 23);
            currentUsernameTxt.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(20, 46);
            label5.Name = "label5";
            label5.Size = new Size(97, 17);
            label5.TabIndex = 1;
            label5.Text = "New Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 13);
            label2.Name = "label2";
            label2.Size = new Size(114, 17);
            label2.TabIndex = 0;
            label2.Text = "Current Username";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(41, 50, 65);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(passwordTxt);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(usernameTxt);
            panel4.Controls.Add(addBtn);
            panel4.Location = new Point(3, 259);
            panel4.Name = "panel4";
            panel4.Size = new Size(276, 112);
            panel4.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(9, 47);
            label4.Name = "label4";
            label4.Size = new Size(91, 17);
            label4.TabIndex = 8;
            label4.Text = "Add Password";
            // 
            // passwordTxt
            // 
            passwordTxt.Location = new Point(105, 45);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.Size = new Size(165, 23);
            passwordTxt.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(5, 13);
            label3.Name = "label3";
            label3.Size = new Size(95, 17);
            label3.TabIndex = 6;
            label3.Text = "Add Username";
            // 
            // usernameTxt
            // 
            usernameTxt.Location = new Point(105, 11);
            usernameTxt.Name = "usernameTxt";
            usernameTxt.Size = new Size(165, 23);
            usernameTxt.TabIndex = 5;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(105, 77);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(95, 30);
            addBtn.TabIndex = 4;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(3, 5);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(104, 24);
            searchBtn.TabIndex = 9;
            searchBtn.Text = "Search User";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            // 
            // accountsDataGridView
            // 
            accountsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            accountsDataGridView.Location = new Point(3, 34);
            accountsDataGridView.Name = "accountsDataGridView";
            accountsDataGridView.Size = new Size(573, 224);
            accountsDataGridView.TabIndex = 2;
            // 
            // searchboxTxt
            // 
            searchboxTxt.Location = new Point(113, 5);
            searchboxTxt.Name = "searchboxTxt";
            searchboxTxt.Size = new Size(463, 23);
            searchboxTxt.TabIndex = 1;
            // 
            // AccountsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 441);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AccountsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Account Management";
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
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)accountsDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox1;
        private LinkLabel linkLabel4;
        private LinkLabel linkLabel3;
        private LinkLabel linkLabel2;
        private LinkLabel dashboardLink;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Button exitBtn;
        private Label label1;
        private TextBox searchboxTxt;
        private DataGridView accountsDataGridView;
        private Button addBtn;
        private Label label3;
        private TextBox usernameTxt;
        private Label label4;
        private TextBox passwordTxt;
        private Button searchBtn;
        private Panel panel4;
        private Panel panel5;
        private Button updateBtn;
        private TextBox newUsernameTxt;
        private TextBox currentUsernameTxt;
        private Label label5;
        private Label label2;
    }
}