using System;
using System.Data;
using System.Data.SqlClient;


namespace BankSystemDataAccessLayer
{
    public class clsLoginDataAccess
    {
        public static int AddNewLoginRecord(DateTime LoginDate , string UserName , string Password , short Permissions)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"INSERT INTO LoginLogs (LoginDate,UserName,Password,Permissions)
                             VALUES  (@LoginDate,@UserName,@Password,@Permissions)
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LoginDate", LoginDate);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@Permissions", Permissions);


            object reader = null;

            int LoginID = -1;

            try
            {
                connection.Open();

                reader = command.ExecuteScalar();

                if (reader != null && int.TryParse(reader.ToString(), out int insertedID))
                {
                    LoginID = insertedID;
                }
            }

            catch (Exception ex) { }

            finally
            {
                connection.Close();
            }

            return LoginID;
        }

        public static DataTable GetAllLoginRecords()
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT *
                            FROM LoginLogs;                            ";

            SqlCommand command = new SqlCommand(query, connection);

            SqlDataReader reader = null;

            DataTable dt = new DataTable();

            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                while (reader.HasRows)
                {
                    dt.Load(reader);
                }
            }

            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return dt;
        }


    }
}
