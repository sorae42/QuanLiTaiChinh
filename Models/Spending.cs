using QuanLiTaiChinh.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace QuanLiTaiChinh.Models
{
    public class Spending 
    {
        public static int add(string name, int amount, string date, int profileID)
        {
            return (int)DataProvider.ExecuteNonQuery("INSERT INTO Spendings (spendName, spendDate, spendAmount, spendUser) VALUES ( @name , @date , @amount , @id )", name, date, amount, profileID);
        }
        public static int delete(string ID)
        {
            return (int)DataProvider.ExecuteNonQuery("DELETE FROM Spendings WHERE spendId = @id", ID);
        }

        public static DataTable? getAll(int profileID, string date)
        {
            return DataProvider.ExecuteReader("SELECT * FROM Spendings WHERE spendUser = @id AND spendDate = @date", profileID, date);
        }
    }
}
