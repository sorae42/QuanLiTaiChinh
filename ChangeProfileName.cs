using QuanLiTaiChinh.Models;

namespace QuanLiTaiChinh
{
    public partial class ChangeProfileName : Form
    {
        private int profileId;
        public ChangeProfileName(int id)
        {
            profileId = id;
            InitializeComponent();
        }

        private void ChangeProfileName_Load(object sender, EventArgs e)
        {
            nameInput.Text = Profile.GetName(profileId);
        }

        private void changeBtn_Click(object sender, EventArgs e)
        {
            if (ProfileEditHandler.EditName(profileId, nameInput.Text))
            {
                MessageBox.Show("Tên hồ sơ mới sẽ được hiển thị trong lần đăng nhập tiếp theo.", "Đổi tên thành công!");
                this.Close();
            }
        }

    }
}
