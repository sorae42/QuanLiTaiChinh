using QuanLiTaiChinh.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiTaiChinh.Models
{
    public class ProfileEditHandler
    {
        public ProfileEditHandler() { }

        public static string getName(int profileId)
        {
            return DataProvider.ExecuteScalar("SELECT profileName FROM Profiles WHERE profileId = @id", profileId).ToString();
        }

        public static bool EditName(int id, string name)
        {
            int a = (int)DataProvider.ExecuteNonQuery("UPDATE Profiles SET ProfileName = @name WHERE profileId = @id", name, id);
            
            if (a > 0) return true;
            else return false;
        }

        public static bool EditPassword(int id, string password)
        {
            int a = (int)DataProvider.ExecuteNonQuery("UPDATE Profiles SET ProfilePassword = @password WHERE profileId = @id", password, id);

            if (a > 0) return true;
            else return false;
        }
    }
}
