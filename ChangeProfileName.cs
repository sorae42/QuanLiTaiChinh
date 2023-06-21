using QuanLiTaiChinh.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            nameInput.Text = ProfileEditHandler.getName(profileId);
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
