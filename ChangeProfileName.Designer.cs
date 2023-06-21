namespace QuanLiTaiChinh
{
    partial class ChangeProfileName
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
            nameInput = new TextBox();
            changeBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 17);
            label1.Name = "label1";
            label1.Size = new Size(159, 32);
            label1.TabIndex = 0;
            label1.Text = "Đổi tên hồ sơ";
            // 
            // nameInput
            // 
            nameInput.Location = new Point(12, 60);
            nameInput.Name = "nameInput";
            nameInput.PlaceholderText = "Tên";
            nameInput.Size = new Size(505, 39);
            nameInput.TabIndex = 2;
            // 
            // changeBtn
            // 
            changeBtn.Location = new Point(285, 116);
            changeBtn.Name = "changeBtn";
            changeBtn.Size = new Size(232, 46);
            changeBtn.TabIndex = 3;
            changeBtn.Text = "Đổi tên";
            changeBtn.UseVisualStyleBackColor = true;
            changeBtn.Click += changeBtn_Click;
            // 
            // ChangeProfileName
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 186);
            Controls.Add(changeBtn);
            Controls.Add(nameInput);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ChangeProfileName";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Đổi tên hồ sơ";
            Load += ChangeProfileName_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox nameInput;
        private Button changeBtn;
    }
}