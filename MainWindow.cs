using System.ComponentModel;
using System.Data;
using QuanLiTaiChinh.Models;
using QuanLiTaiChinh.Utils;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace QuanLiTaiChinh
{
    public partial class MainWindow : Form
    {
        // hackery workaround: pass the profilelogin form
        // in order to show it again (it's the main form)
        private int profileID;
        private int fundLimit;
        private bool firstDisplay = true;
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
            DataRow profilePrefs = Profile.GetPrefs(profileID).Rows[0];

            int startTab = int.Parse(profilePrefs["profilePrefStartupTab"].ToString());
            fundLimit = int.Parse(profilePrefs["profilePrefSpendingLimit"].ToString());

            profileNameLabel.Text = profileName;
            this.Text = "Kinsen - " + profileName;

            dateChooser.Value = DateTime.Now;
            getRecords();

            appTabs.SelectedIndex = startTab;
            startupOptions.SelectedIndex = startTab;

            fundLimitInput.Value = fundLimit;

            Refresh();
            notify("Chào mừng quay trở lại!");
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            loginWindow.Show();
        }

        // Add Spending Tab
        private void addSpendingBtn_Click(object sender, EventArgs e)
        {
            int spent = (int)fundSpentInput.Value;
            string name = fundingNameInput.Text;
            string selectedDate = dateSelector.SelectionStart.ToShortDateString();

            if (name == "")
                return;

            if (Spending.add(name, spent, selectedDate, profileID) > 0)
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

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (spendingList.SelectedItems.Count == 0)
                return;

            string recordID = spendingList.SelectedItems[0].Text;
            if (MessageBox.Show("Xoá chi tiêu này?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (Spending.delete(recordID) > 0) getRecords();
            }
        }

        private void saveLimitBtn_Click(object sender, EventArgs e)
        {
            if (PrefsEditHandler.setFundLimit(profileID, (int)fundLimitInput.Value) > 0)
            {
                fundLimit = (int)fundLimitInput.Value;
                notify("Đã thay đổi hạn mức.");
                MessageBox.Show("Đã thay đổi hạn mức!");
            }
        }

        private void startupOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PrefsEditHandler.setStartupTab(profileID, startupOptions.SelectedIndex) > 0)
            {
                notify("Đã thay đổi khởi động: " + startupOptions.SelectedItem);
            }
        }

        private void getRecords()
        {
            int total = 0;
            string dateChosen = dateChooser.Value.ToShortDateString();
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

                spendingTotal.Text = Helper.FormatNumber(total);
                spendingTotal.ForeColor = Color.Black;
                overLimitTooltip.Hide(spendingTotal);

                System.Diagnostics.Debug.WriteLine(total + " " + fundLimit);
                if (isLimit(total))
                {
                    spendingTotal.ForeColor = Color.Red;
                    overLimitTooltip.Show(string.Empty, spendingTotal, 0); // known bug 
                    overLimitTooltip.Show("Bạn đã chi tiêu quá giới hạn vào ngày này!", spendingTotal, 4269);
                }
            }

            notify("Đã lấy xong dữ liệu!");
        }

        private bool isLimit(int total)
        {
            return (total > fundLimit && fundLimit > 0);
        }

        private void notify(string message)
        {
            noticeLabel.Text = message;
        }
    }
}