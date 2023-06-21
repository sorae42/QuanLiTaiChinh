using System.Data;
using QuanLiTaiChinh.Models;
using QuanLiTaiChinh.Utils;

namespace QuanLiTaiChinh
{
    public partial class MainWindow : Form
    {
        // hackery workaround: pass the profilelogin form
        // in order to show it again (it's the main form)
        private int profileID;
        ProfileLogin loginWindow;

        public MainWindow(int id, ProfileLogin loginWindow)
        {
            profileID = id;
            InitializeComponent();
            this.loginWindow = loginWindow;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            string profileName = Profile.GetName(profileID);
            profileNameLabel.Text = profileName;
            this.Text = "Kinsen - " + profileName;

            dateChooser.Value = DateTime.Now;
            getRecords();

            Refresh();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            loginWindow.Show();
        }

        // Add Spending Tab
        private void addSpendingBtn_Click(object sender, EventArgs e)
        {
            
            if (fundingNameInput.Text == null || fundingNameInput.Text == "")
                return;

            if (Spending.add(fundingNameInput.Text, (int)fundSpentInput.Value, dateSelector.SelectionStart.ToShortDateString(), profileID) > 0)
            {
                notify("Đã thêm thành công!!");
                MessageBox.Show("Đã thêm thành công!!");
                getRecords();
            }
        }

        private void dateChooser_ValueChanged(object sender, EventArgs e)
        {
            getRecords();
        }


        private void changeProfileNameBtn_Click(object sender, EventArgs e)
        {
            ChangeProfileName window = new ChangeProfileName(profileID);
            window.ShowDialog();
        }

        private void changePasswordBtn_Click(object sender, EventArgs e)
        {
            ChangePassword window = new ChangePassword(profileID);
            window.ShowDialog();
        }


        private void getRecords()
        {
            int total = 0;
            string dateChosen = dateChooser.Value.ToShortDateString();
            System.Diagnostics.Debug.WriteLine("[INFO] Attempt GET " + dateChosen);
            notify("Đang lấy dữ liệu...");
            DataTable? result = Spending.getAll(profileID, dateChosen);
            spendingList.Items.Clear();

            if (result != null)
            {
                foreach (DataRow row in result.Rows)
                {
                    string? name = row["spendName"].ToString();
                    string? amount = row["spendAmount"].ToString();
                    string? id = row["spendId"].ToString();

                    string[] dataresult = { id, name, Helper.FormatNumber(int.Parse(amount)) };
                    var listview = new ListViewItem(dataresult);
                    spendingList.Items.Add(listview);

                    total += int.Parse(amount);
                }

            }

            spendingTotal.Text = Helper.FormatNumber(total);
            notify("Xong.");
        }

        private void notify(string message)
        {
            noticeLabel.Text = message;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string recordID = spendingList.SelectedItems[0].Text;
            if (Spending.delete(recordID) > 0) getRecords(); 
        }
    }
}