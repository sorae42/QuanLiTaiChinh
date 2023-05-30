using QuanLiTaiChinh.Utils;

namespace QuanLiTaiChinh.Models
{
    internal class LoginHandler
    {
        private static LoginHandler? instance;

        private LoginHandler() { }

        public static LoginHandler Instance
        {
            get { if (instance == null) instance = new LoginHandler(); return instance; }
            private set { instance = value; }
        }

        public int Login(string username, string password)
        {
            System.Diagnostics.Debug.WriteLine("[INFO] Attempt to login!");
            object? result = DataProvider.Instance.ExecuteScalar("SELECT profileId FROM Profiles WHERE profileName = @username AND profilePassword = @password", username, password);

            if (result == null)
                return -1;

            System.Diagnostics.Debug.WriteLine("[INFO] User ID: " + result);
            return (int) result;
        }

        public void Register(string username, string password)
        {
            System.Diagnostics.Debug.WriteLine("[INFO] Attempt to register!");
            DataProvider.Instance.ExecuteNonQuery("INSERT INTO Profiles (profileName, profilePassword) VALUES (@username, @password)", username, password);
        }
    }
}
