using System;
using System.Data;
using System.Data.SqlClient;

namespace BankSystemDataAccessLayer
{
    public class clsUserDataAccess  
    {
        public static bool GetUserByID(int UserID, ref int PerID, ref string UserName, ref short Permissions, ref decimal Salary)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT * FROM Users WHERE UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

            SqlDataReader reader = null;

            bool isFound = false;

            try
            {
                connection.Open();

                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    PerID = (int)reader["PerID"];
                    UserName = (string)reader["UserName"];
                    Permissions = (short)reader["Permissions"];
                    Salary = (decimal)reader["Salary"];
                }

                else
                    isFound = false;
            }

            catch (Exception ex)
            {
                isFound = false;
            }

            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static bool GetUserByUserNameAndPassword(string UserName, string Password,ref int UserID, ref int PerID, ref short Permissions, ref decimal Salary)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"
                            SELECT Users.* , Persons.Password FROM Users 
                            INNER JOIN Persons
                            ON Users.PerID = Persons.PersonID
                            WHERE UserName = @UserName AND Password = @Password";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);

            SqlDataReader reader = null;

            bool isFound = false;

            try
            {
                connection.Open();

                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    UserID = (int)reader["UserID"]; 
                    PerID = (int)reader["PerID"];                  
                    Permissions = (short)reader["Permissions"];
                    Salary = (decimal)reader["Salary"];
                }

                else
                    isFound = false;
            }

            catch (Exception ex)
            {
                isFound = false;
            }

            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static int AddNewUser(int PerID, string UserName, short Permissions,  decimal Salary)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"INSERT INTO Users (PerID,UserName,Permissions,Salary)
                             VALUES (@PerID,@UserName,@Permissions,@Salary)
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PerID", PerID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Permissions", Permissions);
            command.Parameters.AddWithValue("@Salary", Salary);


            object reader = null;

            int UserID = -1;

            try
            {
                connection.Open();

                reader = command.ExecuteScalar();

                if (reader != null && int.TryParse(reader.ToString(), out int insertedID))
                {
                    UserID = insertedID;
                }
            }

            catch (Exception ex) { }

            finally
            {
                connection.Close();
            }

            return UserID;
        }

        public static bool UpdateUser(int UserID, string UserName, short Permissions, decimal Salary)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"UPDATE Users 
                            SET UserName = @UserName,
                            Permissions = @Permissions,
                            Salary = @Salary
                            WHERE UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Permissions", Permissions);
            command.Parameters.AddWithValue("@Salary", Salary);

            int rowsAffected = 0;

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();
            }

            catch (Exception ex) { }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

        public static bool DeleteUser(int UserID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"DELETE Users                            
                            WHERE UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

            int rowsAffected = 0;

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();
            }

            catch (Exception ex) { }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

        public static bool IsUserExist(int UserID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "SELECT isFound = 1 FROM Users WHERE UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

            SqlDataReader reader = null;

            bool isFound = false;

            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                isFound = (reader.HasRows);
            }

            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static DataTable GetAllUsers()
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT UserID, UserName,Password,Permissions,Salary,FirstName,LastName,Email,Phone,Address,DateOfBirth,ImagePath
                            FROM Users
                            INNER JOIN Persons
                            ON Users.PerID = Persons.PersonID; ";

            SqlCommand command = new SqlCommand(query, connection);

            SqlDataReader reader = null;

            DataTable dt = new DataTable(); 

            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                while(reader.HasRows)
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

        public static int GetUsersCount()
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "SELECT COUNT(UserID) FROM Users";

            SqlCommand command = new SqlCommand(query, connection);

            object reader = null;

            int UsersCount = 0;

            try
            {
                connection.Open();
                reader = command.ExecuteScalar();

                if (reader != null && int.TryParse(reader.ToString(), out int Count))
                {
                    UsersCount = Count;
                }

            }

            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return UsersCount;
        }


    }
}
