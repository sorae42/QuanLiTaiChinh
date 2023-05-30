using System.Data;
using System.Data.SqlClient;

namespace QuanLiTaiChinh.Utils
{
    public class DataProvider
    {
        private static readonly string ConnectionString = @"Data Source=DESKTOP-1MUEJCA\SQLEXPRESS;Initial Catalog=KinsenDB;Integrated Security=True";

        public DataProvider() { }

        public static DataTable? ExecuteReader(string query, params object[] parameter)
        {
            try
            {
                DataTable data = new DataTable();
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameter.Length > 0)
                    {
                        string[] queryLists = query.Split(' ');
                        int i = 0;
                        foreach (string item in queryLists)
                        {
                            if (item.Contains("@"))
                            {
                                command.Parameters.AddWithValue(item, parameter[i]);
                                i++;
                            }
                        }
                    }
                    connection.Open();
                    data.Load(command.ExecuteReader());
                }
                return data;
            }
            catch (SqlException ex)
            {
                System.Diagnostics.Debug.WriteLine("[ERROR] " + ex.Message);
                MessageBox.Show(ex.Message, "Lỗi!!");
                return null;
            }
        }

        public static object? ExecuteScalar(string query, params object[] parameter)
        {
            try
            {
                object data;
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameter.Length > 0)
                    {
                        string[] queryLists = query.Split(' ');
                        int i = 0;
                        foreach (string item in queryLists)
                        {
                            if (item.Contains("@"))
                            {
                                command.Parameters.AddWithValue(item, parameter[i]);
                                i++;
                            }
                        }
                    }
                    connection.Open();
                    data = command.ExecuteScalar();
                }

                return data;
            }
            catch (SqlException ex)
            {
                System.Diagnostics.Debug.WriteLine("[ERROR] " + ex.Message);
                MessageBox.Show(ex.Message, "Lỗi!!");
                return null;
            }
        }

        public static int? ExecuteNonQuery(string query, params object[] parameter)
        {
            try
            {
                int affected;
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameter.Length > 0)
                    {
                        string[] queryLists = query.Split(' ');
                        int i = 0;
                        foreach (string item in queryLists)
                        {
                            if (item.Contains("@"))
                            {
                                command.Parameters.AddWithValue(item, parameter[i]);
                                i++;
                            }
                        }
                    }
                    connection.Open();
                    affected = command.ExecuteNonQuery();
                }

                return affected;
            }
            catch (SqlException ex)
            {
                System.Diagnostics.Debug.WriteLine("[ERROR] " + ex.Message);
                MessageBox.Show(ex.Message, "Lỗi!!");
                return null;
            }
        }
    }
}
