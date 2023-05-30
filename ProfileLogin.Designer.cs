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
            Label label3;
            label1 = new Label();
            label2 = new Label();
            usernameInput = new TextBox();
            passwordInput = new TextBox();
            submitBtn = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 0;
            label1.Text = "Tên người dùng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 57);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu";
            // 
            // usernameInput
            // 
            usernameInput.Location = new Point(12, 27);
            usernameInput.Name = "usernameInput";
            usernameInput.PlaceholderText = "johnuser";
            usernameInput.Size = new Size(243, 23);
            usernameInput.TabIndex = 2;
            // 
            // passwordInput
            // 
            passwordInput.Location = new Point(12, 75);
            passwordInput.Name = "passwordInput";
            passwordInput.PasswordChar = '●';
            passwordInput.PlaceholderText = "●●●●●●●●●";
            passwordInput.Size = new Size(243, 23);
            passwordInput.TabIndex = 3;
            passwordInput.UseSystemPasswordChar = true;
            // 
            // submitBtn
            // 
            submitBtn.Location = new Point(160, 111);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(95, 34);
            submitBtn.TabIndex = 4;
            submitBtn.Text = "Xác nhận";
            submitBtn.UseVisualStyleBackColor = true;
            submitBtn.Click += submitBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(12, 106);
            label3.Name = "label3";
            label3.Size = new Size(130, 39);
            label3.TabIndex = 5;
            label3.Text = "Bạn có thể đăng ký hồ sơ\r\nmới nếu bạn không có\r\nbằng cách bấm Xác nhận.";
            // 
            // ProfileLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(267, 157);
            Controls.Add(label3);
            Controls.Add(submitBtn);
            Controls.Add(passwordInput);
            Controls.Add(usernameInput);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ProfileLogin";
            Text = "Kinsen";
            Load += ProfileLogin_Load;
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