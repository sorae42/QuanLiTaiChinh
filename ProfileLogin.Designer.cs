namespace QuanLiTaiChinh
{
    partial class ProfileLogin
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
            label1 = new Label();
            label2 = new Label();
            usernameInput = new TextBox();
            passwordInput = new TextBox();
            submitBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 19);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(184, 32);
            label1.TabIndex = 0;
            label1.Text = "Tên người dùng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 122);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(115, 32);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu";
            // 
            // usernameInput
            // 
            usernameInput.Location = new Point(22, 58);
            usernameInput.Margin = new Padding(6);
            usernameInput.Name = "usernameInput";
            usernameInput.PlaceholderText = "johnuser";
            usernameInput.Size = new Size(448, 39);
            usernameInput.TabIndex = 2;
            // 
            // passwordInput
            // 
            passwordInput.Location = new Point(22, 160);
            passwordInput.Margin = new Padding(6);
            passwordInput.Name = "passwordInput";
            passwordInput.PasswordChar = '●';
            passwordInput.PlaceholderText = "●●●●●●●●●";
            passwordInput.Size = new Size(448, 39);
            passwordInput.TabIndex = 3;
            passwordInput.UseSystemPasswordChar = true;
            // 
            // submitBtn
            // 
            submitBtn.Location = new Point(297, 237);
            submitBtn.Margin = new Padding(6);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(176, 50);
            submitBtn.TabIndex = 4;
            submitBtn.Text = "Xác nhận";
            submitBtn.UseVisualStyleBackColor = true;
            submitBtn.Click += submitBtn_Click;
            // 
            // ProfileLogin
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 304);
            Controls.Add(submitBtn);
            Controls.Add(passwordInput);
            Controls.Add(usernameInput);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ProfileLogin";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kinsen";
            Activated += ProfileLogin_Activated;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox usernameInput;
        private TextBox passwordInput;
        private Button submitBtn;
    }
}