using QuanLiTaiChinh.Utils;
using System.Data;

namespace QuanLiTaiChinh.Models
{
    public class Profile
    {
        private Profile() { }

        public static string GetName(int profileID)
        {
            string? result = DataProvider.ExecuteScalar("SELECT profileName FROM Profiles WHERE profileId = @id", profileID) as string;
            if (result != null)
                return result;
            return "Guest"; // should never returned but the intellicode needs to shut up
        }

        public static DataTable GetPrefs(int profileID)
        {
            return DataProvider.ExecuteReader("SELECT profilePrefSpendingLimit, profilePrefStartupTab FROM Profiles WHERE profileId = @id", profileID);
        }

    }
}
