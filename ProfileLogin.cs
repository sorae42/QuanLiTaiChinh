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

            if (ProcessLogin(username, password))
            {
                MainWindow window = new MainWindow();
                this.Hide();
                window.Show();
            }
        }

        private int ProcessLogin(string username, string password)
        {
            int profileId = LoginHandler.Instance.Login(username, password);

            if (profileId == -1)
            {
                if (MessageBox.Show("Tài khoản này không tồn tại. Bạn có muốn tạo mới không?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    LoginHandler.Instance.Register(username, password);
                    MessageBox.Show("Tạo thành công!");
                    ProcessLogin(username, password);
                }
            }

            return profileId;
        }

    }
}
