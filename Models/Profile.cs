using Microsoft.VisualBasic.ApplicationServices;
using QuanLiTaiChinh.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return DataProvider.ExecuteReader("SELECT profilePrefDefaultName, profilePrefSpendingLimit, profilePrefStartupTab FROM Profiles WHERE profileId = @id", profileID);
        }

    }
}
