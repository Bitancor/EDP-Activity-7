namespace Activity4_GUI
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            unameLabel = new Label();
            pwordLabel = new Label();
            usernameTxt = new TextBox();
            passwordTxt = new TextBox();
            loginBtn = new Button();
            exitBtn = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            recoverLink = new LinkLabel();
            showpassCheckBox = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // unameLabel
            // 
            unameLabel.AutoSize = true;
            unameLabel.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            unameLabel.ForeColor = Color.White;
            unameLabel.Location = new Point(32, 160);
            unameLabel.Name = "unameLabel";
            unameLabel.Size = new Size(88, 21);
            unameLabel.TabIndex = 0;
            unameLabel.Text = "Username";
            // 
            // pwordLabel
            // 
            pwordLabel.AutoSize = true;
            pwordLabel.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pwordLabel.ForeColor = Color.White;
            pwordLabel.Location = new Point(38, 201);
            pwordLabel.Name = "pwordLabel";
            pwordLabel.Size = new Size(82, 21);
            pwordLabel.TabIndex = 1;
            pwordLabel.Text = "Password";
            // 
            // usernameTxt
            // 
            usernameTxt.Location = new Point(126, 160);
            usernameTxt.Name = "usernameTxt";
            usernameTxt.Size = new Size(236, 23);
            usernameTxt.TabIndex = 2;
            // 
            // passwordTxt
            // 
            passwordTxt.Location = new Point(126, 203);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.Size = new Size(236, 23);
            passwordTxt.TabIndex = 3;
            passwordTxt.UseSystemPasswordChar = true;
            // 
            // loginBtn
            // 
            loginBtn.Location = new Point(205, 272);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(119, 27);
            loginBtn.TabIndex = 4;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(80, 272);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(119, 27);
            exitBtn.TabIndex = 5;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(164, 119);
            label1.Name = "label1";
            label1.Size = new Size(59, 22);
            label1.TabIndex = 6;
            label1.Text = "Login";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(158, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(78, 82);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // recoverLink
            // 
            recoverLink.AutoSize = true;
            recoverLink.Font = new Font("Century Gothic", 9F);
            recoverLink.ForeColor = Color.Black;
            recoverLink.LinkColor = Color.White;
            recoverLink.Location = new Point(205, 242);
            recoverLink.Name = "recoverLink";
            recoverLink.Size = new Size(117, 17);
            recoverLink.TabIndex = 8;
            recoverLink.TabStop = true;
            recoverLink.Text = "Recover Password";
            recoverLink.LinkClicked += recoverLink_LinkClicked;
            // 
            // showpassCheckBox
            // 
            showpassCheckBox.AutoSize = true;
            showpassCheckBox.Font = new Font("Century Gothic", 9F);
            showpassCheckBox.ForeColor = Color.White;
            showpassCheckBox.Location = new Point(82, 241);
            showpassCheckBox.Name = "showpassCheckBox";
            showpassCheckBox.Size = new Size(117, 21);
            showpassCheckBox.TabIndex = 10;
            showpassCheckBox.Text = "Show Password";
            showpassCheckBox.UseVisualStyleBackColor = true;
            showpassCheckBox.CheckedChanged += showpassCheckBox_CheckedChanged;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(394, 356);
            Controls.Add(showpassCheckBox);
            Controls.Add(recoverLink);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(exitBtn);
            Controls.Add(loginBtn);
            Controls.Add(passwordTxt);
            Controls.Add(usernameTxt);
            Controls.Add(pwordLabel);
            Controls.Add(unameLabel);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label unameLabel;
        private Label pwordLabel;
        private TextBox usernameTxt;
        private TextBox passwordTxt;
        private Button loginBtn;
        private Button exitBtn;
        private Label label1;
        private PictureBox pictureBox1;
        private LinkLabel recoverLink;
        private CheckBox showpassCheckBox;
    }
}