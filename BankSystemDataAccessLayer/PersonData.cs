using System;
using System.Data.SqlClient; 

namespace BankSystemDataAccessLayer
{
    public class clsPersonDataAccess
    {
        public static bool GetPersonByID(int PersonID , ref string FirstName, ref string LastName, ref string Email, 
            ref string Phone, ref string Address, ref DateTime DateOfBirth, ref string Password,ref string ImagePath)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "SELECT * FROM Persons WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            SqlDataReader reader = null;

            bool isFound = false;

            try
            {
                connection.Open();

                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    Phone = (string)reader["Phone"];
                    Email = (string)reader["Email"];
                    Address = (string)reader["Address"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Password = (string)reader["Password"];
                    if (reader["ImagePath"] != System.DBNull.Value)
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }
                    else
                        ImagePath = ""; 
                }

                else
                    isFound = false;
            }

            catch(Exception ex)
            {
                isFound = false;
            }
            finally
            {
                reader.Close(); 
                connection.Close(); 
            }

            return isFound;
        }

        public static bool UpdatePerson(int PersonID,  string FirstName,  string LastName,  string Email,
             string Phone,  string Address,  DateTime DateOfBirth,  string Password,  string ImagePath)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"UPDATE Persons 
                            SET FirstName = @FirstName ,
                                LastName = @LastName ,
                                Email = @Email ,
                                Phone = @Phone ,
                                Address = @Address ,
                                DateOfBirth = @DateOfBirth ,
                                Password = @Password,
                                ImagePath = @ImagePath
                                WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Password", Password);

            if(ImagePath != "")
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);

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

        public static int AddNewPerson( string FirstName, string LastName, string Email,
            string Phone, string Address, DateTime DateOfBirth, string Password, string ImagePath)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"INSERT INTO Persons (FirstName,LastName,Email,Phone,Address,DateOfBirth,Password,ImagePath)
                            VALUES (@FirstName ,@LastName ,@Email , @Phone ,@Address ,@DateOfBirth ,@Password,@ImagePath)
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Password", Password);

            if(ImagePath != "")
                command.Parameters.AddWithValue("@ImagePath", ImagePath); 
            else
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);

            object reader = 0;

            int PersonID = -1;

            try
            {
                connection.Open();

                reader = command.ExecuteScalar();

                if(reader != null && int.TryParse(reader.ToString(),out int insertedID))
                {
                    PersonID = insertedID; 
                }
            }

            catch (Exception ex) { }
                    
            finally
            {
                connection.Close();
            }

            return PersonID;
        }

        public static bool DeletePerson(int PersonID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "DELETE Persons WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
          
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

        public static bool IsPersonExist(int PersonID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "SELECT isFound = 1 FROM Persons WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            object reader = null;

            bool isFound = false;

            try
            {
                connection.Open();
                reader = command.ExecuteScalar();

                isFound = (reader != null);
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

    }
}
