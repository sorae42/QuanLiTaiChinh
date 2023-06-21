using System.Globalization;

namespace QuanLiTaiChinh.Utils
{
    public class Helper
    {
        public static string FormatNumber(int number)
        {
            return number.ToString("#,#", CultureInfo.InvariantCulture);
        }
    }
}
