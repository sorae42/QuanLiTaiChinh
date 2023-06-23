using QuanLiTaiChinh.Models;

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

            if (username != "" && password != "")
            {
                submitBtn_Status(0);
                int id = ProcessLogin(username, password);
                if (id >= 0)
                {
                    MainWindow window = new MainWindow(id, this);
                    window.Show();
                    this.Hide();
                    submitBtn_Status(1);
                }
            }
        }

        private int ProcessLogin(string username, string password)
        {
            int profileId = LoginHandler.Login(username, password);

            if (profileId == -2)
            {
                if (MessageBox.Show("Hồ sơ này không tồn tại. Bạn có muốn tạo hồ sơ mới không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    LoginHandler.Register(username, password);
                    MessageBox.Show("Hồ sơ mới đã tạo thành công. Vui lòng đăng nhập bằng tên mới.");
                }
            }
            else if (profileId == -1)
            {
                MessageBox.Show("Mật khẩu không chính xác!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            submitBtn_Status(1);

            return profileId;
        }

        private void submitBtn_Status(int status)
        {
            switch (status)
            {
                case 0:
                    submitBtn.Text = "Đợi...";
                    submitBtn.Enabled = false;
                    break;
                case 1:
                    submitBtn.Text = "Xác nhận";
                    submitBtn.Enabled = true;
                    break;
            }
        }
    }
}
