namespace QuanLiTaiChinh
{
    partial class ChangePassword
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
            passwordInput = new TextBox();
            changeBtn = new Button();
            passwordConfirmInput = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 22);
            label1.Name = "label1";
            label1.Size = new Size(318, 32);
            label1.TabIndex = 0;
            label1.Text = "Đổi mật khẩu mới cho hồ sơ";
            // 
            // passwordInput
            // 
            passwordInput.Location = new Point(21, 77);
            passwordInput.Name = "passwordInput";
            passwordInput.PasswordChar = '●';
            passwordInput.PlaceholderText = "Mật khẩu mới";
            passwordInput.Size = new Size(512, 39);
            passwordInput.TabIndex = 1;
            passwordInput.UseSystemPasswordChar = true;
            // 
            // changeBtn
            // 
            changeBtn.Location = new Point(317, 225);
            changeBtn.Name = "changeBtn";
            changeBtn.Size = new Size(216, 46);
            changeBtn.TabIndex = 2;
            changeBtn.Text = "Đổi mật khẩu";
            changeBtn.UseVisualStyleBackColor = true;
            changeBtn.Click += changeBtn_Click;
            // 
            // passwordConfirmInput
            // 
            passwordConfirmInput.Location = new Point(21, 149);
            passwordConfirmInput.Name = "passwordConfirmInput";
            passwordConfirmInput.PasswordChar = '●';
            passwordConfirmInput.PlaceholderText = "Nhập lại mật khẩu mới";
            passwordConfirmInput.Size = new Size(512, 39);
            passwordConfirmInput.TabIndex = 4;
            passwordConfirmInput.UseSystemPasswordChar = true;
            // 
            // ChangePassword
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 301);
            Controls.Add(passwordConfirmInput);
            Controls.Add(changeBtn);
            Controls.Add(passwordInput);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ChangePassword";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Đổi mật khẩu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox passwordInput;
        private Button changeBtn;
        private TextBox passwordConfirmInput;
    }
}