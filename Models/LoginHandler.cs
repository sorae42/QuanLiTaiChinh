using QuanLiTaiChinh.Utils;

namespace QuanLiTaiChinh.Models
{
    internal class LoginHandler
    {
        private LoginHandler() { }

        public static int Login(string username, string password)
        {
            System.Diagnostics.Debug.WriteLine("[INFO] Attempt to login!");
            object? result = DataProvider.ExecuteScalar("SELECT profileId FROM Profiles WHERE profileName = @username AND profilePassword = @password", username, password);

            if (result == null)
                return -1;

            System.Diagnostics.Debug.WriteLine("[INFO] Logged in! User ID: " + result);
            return (int) result;
        }

        public static void Register(string username, string password)
        {
            System.Diagnostics.Debug.WriteLine("[INFO] Attempt to register!");
            DataProvider.ExecuteNonQuery("INSERT INTO Profiles (profileName, profilePassword) VALUES ( @username , @password )", username, password);
        }
    }
}
