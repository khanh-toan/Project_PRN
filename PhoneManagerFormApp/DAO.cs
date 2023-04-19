using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace PhoneManagerFormApp
{
    public class DAO
    {
        public static SqlConnection GetConnection()
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            string connect = config.GetConnectionString("MyDB");
            return new SqlConnection(connect);
        }


        //private static string GetConnectionString()
        //{
        //    string jsonString = File.ReadAllText("appsettings.json");
        //    JsonDocument document = JsonDocument.Parse(jsonString);
        //    JsonElement element = document.RootElement.GetProperty("ConnectionStrings").GetProperty("MyDB");
        //    return element.GetString();
        //}

        //public static SqlConnection GetConnection()
        //{
        //    return new SqlConnection(GetConnectionString());
        //}
        public static DataTable SelectData(string sql)
        {
            SqlCommand command = new SqlCommand(sql, GetConnection());
            
            //SqlDataAdapter là một lớp đại diện cho một tập hợp các lệnh SQL và kết nối cơ sở
            //dữ liệu. Nó được sử dụng để điền DataSet hoặc DataTable và modify dữ liệu.
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

/*        public static int UpdateData(string sql)
        {
            using (SqlConnection connection = GetConnection())
            {
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                int result = command.ExecuteNonQuery();
                return result;
            }
        }*/
    }
}
