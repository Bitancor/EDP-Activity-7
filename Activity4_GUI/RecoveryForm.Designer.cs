namespace Activity4_GUI
{
    partial class RecoveryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecoveryForm));
            enterBtn = new Button();
            label1 = new Label();
            label3 = new Label();
            confirmPasswordTxt = new TextBox();
            pictureBox1 = new PictureBox();
            backBtn = new Button();
            passwordTxt = new TextBox();
            label2 = new Label();
            label4 = new Label();
            usernameTxt = new TextBox();
            showpassCheckBox = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // enterBtn
            // 
            enterBtn.Location = new Point(206, 302);
            enterBtn.Name = "enterBtn";
            enterBtn.Size = new Size(119, 27);
            enterBtn.TabIndex = 1;
            enterBtn.Text = "Enter";
            enterBtn.UseVisualStyleBackColor = true;
            enterBtn.Click += enterBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(102, 121);
            label1.Name = "label1";
            label1.Size = new Size(190, 22);
            label1.TabIndex = 2;
            label1.Text = "Password Recovery";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(19, 243);
            label3.Name = "label3";
            label3.Size = new Size(147, 21);
            label3.TabIndex = 5;
            label3.Text = "Confirm Password";
            // 
            // confirmPasswordTxt
            // 
            confirmPasswordTxt.Location = new Point(172, 241);
            confirmPasswordTxt.Name = "confirmPasswordTxt";
            confirmPasswordTxt.Size = new Size(190, 23);
            confirmPasswordTxt.TabIndex = 6;
            confirmPasswordTxt.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(158, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(78, 79);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // backBtn
            // 
            backBtn.Location = new Point(81, 302);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(119, 27);
            backBtn.TabIndex = 8;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // passwordTxt
            // 
            passwordTxt.Location = new Point(172, 206);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.Size = new Size(190, 23);
            passwordTxt.TabIndex = 9;
            passwordTxt.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(84, 208);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 10;
            label2.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(78, 172);
            label4.Name = "label4";
            label4.Size = new Size(88, 21);
            label4.TabIndex = 11;
            label4.Text = "Username";
            // 
            // usernameTxt
            // 
            usernameTxt.Location = new Point(172, 170);
            usernameTxt.Name = "usernameTxt";
            usernameTxt.Size = new Size(190, 23);
            usernameTxt.TabIndex = 12;
            // 
            // showpassCheckBox
            // 
            showpassCheckBox.AutoSize = true;
            showpassCheckBox.Font = new Font("Century Gothic", 9F);
            showpassCheckBox.ForeColor = Color.White;
            showpassCheckBox.Location = new Point(172, 274);
            showpassCheckBox.Name = "showpassCheckBox";
            showpassCheckBox.Size = new Size(117, 21);
            showpassCheckBox.TabIndex = 13;
            showpassCheckBox.Text = "Show Password";
            showpassCheckBox.UseVisualStyleBackColor = true;
            showpassCheckBox.CheckedChanged += showpassCheckBox_CheckedChanged;
            // 
            // RecoveryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(394, 356);
            Controls.Add(showpassCheckBox);
            Controls.Add(usernameTxt);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(passwordTxt);
            Controls.Add(backBtn);
            Controls.Add(pictureBox1);
            Controls.Add(confirmPasswordTxt);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(enterBtn);
            Name = "RecoveryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Password Recovery";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button enterBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox confirmPasswordTxt;
        private PictureBox pictureBox1;
        private Button backBtn;
        private TextBox passwordTxt;
        private Label label4;
        private TextBox usernameTxt;
        private CheckBox showpassCheckBox;
    }
}