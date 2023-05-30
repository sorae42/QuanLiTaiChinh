using System.Data;
using QuanLiTaiChinh.Models;
using QuanLiTaiChinh.Utils;

namespace QuanLiTaiChinh
{
    public partial class MainWindow : Form
    {
        private int profileID;

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

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        // Add Spending Tab
        private void addSpendingBtn_Click(object sender, EventArgs e)
        {
            if (fundingNameInput.Text == null || fundingNameInput.Text == "")
                return;

            if (Spending.add(fundingNameInput.Text, (int)fundSpentInput.Value, dateSelector.SelectionStart.ToShortDateString(), profileID) > 0)
            {
                noticeLabel.Text = "Đã thêm thành công!!";
                MessageBox.Show("Đã thêm thành công!!");
            }
        }

        private void dateChooser_ValueChanged(object sender, EventArgs e)
        {
            string dateChosen = dateChooser.Value.ToShortDateString();
            System.Diagnostics.Debug.WriteLine("[INFO] Attempt GET " + dateChosen);
            DataTable? result = Spending.getAll(profileID, dateChosen);
            spendingList.Items.Clear();

            if (result != null)
            {
                foreach (DataRow row in result.Rows)
                {
                    string? name = row["spendName"].ToString();
                    string? amount = row["spendAmount"].ToString();
                    string? id = row["spendId"].ToString();

                    string[] dataresult = { id, name, amount };
                    var listview = new ListViewItem(dataresult);
                    spendingList.Items.Add(listview);
                }
            }
        }
    }
}