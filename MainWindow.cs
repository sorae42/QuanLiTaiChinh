namespace QuanLiTaiChinh
{
    public partial class MainWindow : Form
    {
        public MainWindow(int user)
        {
            InitializeComponent();
        }

        private void addSpendingBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(dateSelector.SelectionStart.ToShortDateString());
            System.Diagnostics.Debug.WriteLine(fundingNameInput.Text);
            System.Diagnostics.Debug.WriteLine(fundSpentInput.Text);



            noticeLabel.Text = "Đã thêm thành công!!";
        }

        private void dateSelector_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}