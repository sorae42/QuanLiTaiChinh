using System.Data;
using QuanLiTaiChinh.Models;
using QuanLiTaiChinh.Utils;

namespace QuanLiTaiChinh
{
    public partial class MainWindow : Form
    {
        private int profileID;

        private string username;
        private string defaultName;
        private int spendingLimit;
        private int startupTab;

        public MainWindow(int id)
        {
            profileID = id;
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            string profileName = Profile.GetName(profileID);
            profileNameLabel.Text = profileName;
            this.Text = "Kinsen - " + profileName;

            this.Refresh();
        }

        // Add Spending Tab
        private void addSpendingBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(dateSelector.SelectionStart.ToShortDateString());
            System.Diagnostics.Debug.WriteLine(fundingNameInput.Text);
            System.Diagnostics.Debug.WriteLine(fundSpentInput.Text);

            // TODO: put values
            //DataProvider.Instance.ExecuteNonQuery("INSERT INTO Spendings (spendName, spendDate, spendAmount, spendUser)", Name, dateChooser, amount, userID);

            noticeLabel.Text = "Đã thêm thành công!!";
        }

        private void dateSelector_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}