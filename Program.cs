namespace QuanLiTaiChinh
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            System.Diagnostics.Debug.WriteLine("Initializing Kinsen...");
            ApplicationConfiguration.Initialize();
            Application.Run(new ProfileLogin());
        }
    }
}