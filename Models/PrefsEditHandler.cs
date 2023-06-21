using QuanLiTaiChinh.Utils;

namespace QuanLiTaiChinh.Models
{
    public class PrefsEditHandler
    {
        public static int setFundLimit(int id, int limit)
        {
            return (int)DataProvider.ExecuteNonQuery("UPDATE Profiles SET profilePrefSpendingLimit = @limit WHERE profileId = @id", limit, id);
        }

        public static int setStartupTab(int id, int tab)
        {
            return (int)DataProvider.ExecuteNonQuery("UPDATE Profiles SET profilePrefStartupTab = @tab WHERE profileId = @id", tab, id);
        }
    }
}
