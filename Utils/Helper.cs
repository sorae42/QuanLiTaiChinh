using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
