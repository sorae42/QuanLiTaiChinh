namespace QuanLiTaiChinh
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addSpendingBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(dateChooser.Value);
            System.Diagnostics.Debug.WriteLine(fundingNameInput.Text);
            System.Diagnostics.Debug.WriteLine(fundSpentInput.Text);

            noticeLabel.Text = "Đã thêm thành công!!";
        }

        private void dateSelector_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}