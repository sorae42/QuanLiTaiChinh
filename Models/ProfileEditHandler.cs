using QuanLiTaiChinh.Utils;

namespace QuanLiTaiChinh.Models
{
    public class ProfileEditHandler
    {
        public ProfileEditHandler() { }

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
