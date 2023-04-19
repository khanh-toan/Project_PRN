using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace PhoneManagerFormApp
{
    public static class Actions
    {
        static List<Phone> phones = new List<Phone>();
        
        /// <summary>
        /// câu lệnh truy vấn chung
        /// </summary>
        static string sql = @" select Phone.*, Manufacturer.ManufacturerName as Name2, Manufacturer.Country
        from Phone, Manufacturer
	    where Phone.manufacturerid = manufacturer.id";
        static string sql1 = "Select * from Account";

        public static Account Login(string username, string password)
        {
            try
            {
                string sql2 = sql1;
                if (username != null) sql2 += " where Username = '" + username + "'" + "and Password = '" + password + "'";
                DataTable dt = DAO.SelectData(sql2);
                DataRow dr = dt.Rows[0];
                return new Account
                {
                    Username = dr["Username"].ToString(),
                    Password = dr["Password"].ToString()
                };
            }
            catch (Exception)
            {
                MessageBox.Show("sai ten hoac mat khau");
            }
            return null;
        }

        /// <summary>
        /// phương thức lấy toàn bộ danh sách phone
        /// </summary>
        /// <returns></returns>
        public static List<Phone> GetAllPhones()
        {
            string sql1 = sql;

            DataTable dt = DAO.SelectData(sql1);

            return GetListPhones(dt);
        }

        public static int UpdatePhone(Phone phone)
        {
            string sql = @"UPDATE [dbo].[Phone]
                   SET [Name] = @Name,
                       [Price] = @Price,
                       [ManufacturerId] = @ManufacturerId,
                       [Quantity] = @Quantity,
                       [ReleaseDate] = @ReleaseDate,
                       [Description] = @Description
                   WHERE id = @Id";

            using (SqlConnection connection = DAO.GetConnection())
            {
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@Name", phone.Name);
                command.Parameters.AddWithValue("@Price", phone.Price);
                command.Parameters.AddWithValue("@ManufacturerId", phone.ManufacturerId);
                command.Parameters.AddWithValue("@Quantity", phone.Quantity);
                command.Parameters.AddWithValue("@ReleaseDate", phone.ReleaseDate);
                command.Parameters.AddWithValue("@Description", phone.Description);
                command.Parameters.AddWithValue("@Id", phone.Id);

                connection.Open();
                int result = command.ExecuteNonQuery();
                return result;
            }
        }
        public static int InsertPhone(Phone phone)
        {
            string sql = @"INSERT INTO Phone (Name, Price, Quantity, ManufacturerId, ReleaseDate, Description)
VALUES (@Name, @Price, @Quantity,@ManufacturerId, @ReleaseDate,@Description)";

            using (SqlConnection connection = DAO.GetConnection())
            {
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@Name", phone.Name);
                command.Parameters.AddWithValue("@Price", phone.Price);
                command.Parameters.AddWithValue("@ManufacturerId", phone.ManufacturerId);
                command.Parameters.AddWithValue("@Quantity", phone.Quantity);
                command.Parameters.AddWithValue("@ReleaseDate", phone.ReleaseDate);
                command.Parameters.AddWithValue("@Description", phone.Description);

                connection.Open();
                int result = command.ExecuteNonQuery();
                return result;
            }
        }
        public static void DeletePhone(int phoneId)
        {
            string sql = @"delete from Phone where id = @Id";
            using (SqlConnection connection = DAO.GetConnection())
            {
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@Id", phoneId);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        /// <summary>
        /// phương thức tìm kiếm nhân viên
        /// </summary>
        /// <param name="na"></param>
        /// <param name="sex"></param>
        /// <param name="pos"></param>
        /// <returns></returns>
        /*public static List<Phone> GetSearch(string na, string sex, string pos)
        {
            string sql1 = sql;
            DataTable dt = DAO.SelectData(sql1);
            return GetListPhones(dt);
        }*/

        public static Phone GetPhone(int id)
        {
            string sql1 = sql;
            sql1 += " and phone.id =" + id;
            DataTable dt = DAO.SelectData(sql1);
            DataRow item = dt.Rows[0];
            return new Phone
            {
                Id = int.Parse(item["Id"].ToString()),
                Name = item["Name"].ToString(),
                ReleaseDate = DateTime.Parse(item["releaseDate"].ToString()),
                Description = item["description"].ToString(),
                ManufacturerId = int.Parse(item["manufacturerId"].ToString()),
                ManufacturerName = item["Name2"].ToString(),
                Price = decimal.Parse(item["price"].ToString()),
                Quantity = int.Parse(item["QuaNTIty"].ToString()),
                Country = item["country"].ToString()
            };
        }

        public static List<Phone> GetPhoneFilter(string na, string man, string count, int price, int year)
        {
            string sql1 = sql;

            if (na != "") sql1 += " and name like '%" + na + "%'";
            if (man != "All manufacturers") sql1 += " and Manufacturer.ManufacturerName = '" + man + "'";
            if (count != "All countries") sql1 += " and country = '" + count + "'";
            if (price + year > 0) sql1 += " order by";
            if (price == 1) sql1 += " price";
            else if(price ==2) sql1 += " price desc";
            if (price > 0 && year > 0) sql1 += ", ";
            if (year == 1) sql1 += " ReleaseDate";
            if (year == 2) sql1 += " ReleaseDate desc";


            //List<Phone> list = new List<Phone>();
            DataTable dt = DAO.SelectData(sql1);
            return GetListPhones(dt);
        }

        public static List<Manufacturer> GetManufacturers()
        {
            string sql1 = "select * from Manufacturer";
            DataTable dt = DAO.SelectData(sql1);
            List<Manufacturer> list = new List<Manufacturer>();
            foreach (DataRow item in dt.Rows) {
                list.Add(new Manufacturer
                {
                    Id = int.Parse(item["Id"].ToString()),
                    Name = item["manufacturerName"].ToString(),
                    Country = item["country"].ToString()
                });
            }
            return list;
        }

        public static List<Phone> GetListPhones(DataTable dt)
        {
            phones.Clear();

            foreach (DataRow item in dt.Rows)
            {
                phones.Add(new Phone
                {
                    Id = int.Parse(item["Id"].ToString()),
                    Name = item["Name"].ToString(),
                    ReleaseDate = DateTime.Parse(item["releaseDate"].ToString()),
                    Description = item["description"].ToString(),
                    ManufacturerId = int.Parse(item["manufacturerId"].ToString()),
                    ManufacturerName = item["Name2"].ToString(),
                    Price = decimal.Parse(item["price"].ToString()),
                    Quantity = int.Parse(item["QuaNTIty"].ToString()),
                    Country = item["country"].ToString()

                }) ;
            }
            return phones;
        }
    }
}