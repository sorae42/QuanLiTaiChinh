using QuanLiTaiChinh.Models;

namespace QuanLiTaiChinh
{
    public partial class ProfileLogin : Form
    {
        public ProfileLogin()
        {
            InitializeComponent();
        }

        private void ProfileLogin_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("[INFO] Please log in!");
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string username = usernameInput.Text;
            string password = passwordInput.Text;
            int id = ProcessLogin(username, password);
            if (id != -1)
            {
                MainWindow window = new MainWindow(id);
                this.Hide();
                window.Show();
            }
        }

        private int ProcessLogin(string username, string password)
        {
            int profileId = LoginHandler.Login(username, password);

            if (profileId == -1)
            {
                if (MessageBox.Show("Tài khoản này không tồn tại. Bạn có muốn tạo mới không?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    LoginHandler.Register(username, password);
                    MessageBox.Show("Tạo thành công! Vui lòng đăng nhập bằng tài khoản mới!");
                }
            }

            return profileId;
        }

    }
}
