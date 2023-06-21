using QuanLiTaiChinh.Models;

namespace QuanLiTaiChinh
{
    public partial class ChangePassword : Form
    {
        private int profileId;
        public ChangePassword(int id)
        {
            profileId = id;
            InitializeComponent();
        }

        private void changeBtn_Click(object sender, EventArgs e)
        {
            string password = passwordInput.Text;
            string passwordConfirm = passwordConfirmInput.Text;
            if (password.Length <= 0 || passwordConfirm.Length <= 0)
                return;

            if (password != passwordConfirm)
            {
                MessageBox.Show("Mật khẩu không trùng khớp!!");
                return;
            }

            if (ProfileEditHandler.EditPassword(profileId, password))
            {
                MessageBox.Show("Thay đổi mật khẩu thành công!");
                this.Close();
            }
        }
    }
}
