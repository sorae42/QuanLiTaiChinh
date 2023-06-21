﻿using QuanLiTaiChinh.Models;

namespace QuanLiTaiChinh
{
    public partial class ProfileLogin : Form
    {
        public ProfileLogin()
        {
            InitializeComponent();
        }

        private void ProfileLogin_Activated(object sender, EventArgs e)
        {
            passwordInput.Text = string.Empty;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string username = usernameInput.Text;
            string password = passwordInput.Text;

            if (username.Length > 0 || password.Length > 0)
            {
                int id = ProcessLogin(username, password);
                if (id != -1)
                {
                    MainWindow window = new MainWindow(id, this);
                    window.Show();
                    this.Hide();
                }
            }
        }

        private int ProcessLogin(string username, string password)
        {
            int profileId = LoginHandler.Login(username, password);

            if (profileId == -1)
            {
                if (MessageBox.Show("Hồ sơ với mật khẩu này không tồn tại. Bạn có muốn tạo hồ sơ mới không?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    LoginHandler.Register(username, password);
                }
            }

            return profileId;
        }
    }
}
