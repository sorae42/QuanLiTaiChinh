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


        }

        private void dateSelector_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}