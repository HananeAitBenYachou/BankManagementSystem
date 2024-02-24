using System;
using System.Data;
using System.Data.SqlClient; 

namespace BankSystemDataAccessLayer
{
    public class clsClientDataAccess
    {
        public static bool GetClientByID(int ClientID , ref int PerID , ref string AccountNumber , ref decimal AccountBalance)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT * FROM Clients WHERE ClientID = @ClientID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ClientID", ClientID);

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
                    AccountNumber = (string)reader["AccountNumber"];
                    AccountBalance = (decimal)reader["AccountBalance"]; 
                }

                else
                    isFound = false;
            }

            catch(Exception ex )
            {
                isFound = false;
            }

            finally
            {
                connection.Close(); 
            }

            return isFound;
        }

        public static bool GetClientByAccountNumber(string AccountNumber, ref int ClientID, ref int PerID, ref decimal AccountBalance)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT * FROM Clients WHERE AccountNumber = @AccountNumber";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);

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
                    ClientID = (int)reader["ClientID"];
                    AccountBalance = (decimal)reader["AccountBalance"];
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

        public static int AddNewClient(int PerID, string AccountNumber,  decimal AccountBalance)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"INSERT INTO Clients (PerID,AccountNumber,AccountBalance)
                             VALUES (@PerID,@AccountNumber,@AccountBalance)
                             SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query,connection);

            command.Parameters.AddWithValue("@PerID", PerID);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            command.Parameters.AddWithValue("@AccountBalance", AccountBalance);

            object reader = null;

            int ClientID = -1;

            try
            {
                connection.Open();

                reader = command.ExecuteScalar();

                if (reader != null && int.TryParse(reader.ToString(), out int insertedID))
                {
                    ClientID = insertedID;
                }
            }

            catch(Exception ex) { }

            finally
            {
                connection.Close();
            }

            return ClientID;
        }

        public static bool UpdateClient(int ClientID ,string AccountNumber, decimal AccountBalance)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"UPDATE Clients 
                            SET AccountNumber = @AccountNumber,
                            AccountBalance = @AccountBalance
                            WHERE ClientID = @ClientID";

            SqlCommand command = new SqlCommand(query,connection);

            command.Parameters.AddWithValue("@ClientID", ClientID);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            command.Parameters.AddWithValue("@AccountBalance", AccountBalance);

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
    
        public static bool DeleteClient(int ClientID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"DELETE Clients                            
                            WHERE ClientID = @ClientID";

            SqlCommand command = new SqlCommand(query,connection);

            command.Parameters.AddWithValue("@ClientID", ClientID);
           
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

        public static bool IsClientExist(int ClientID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "SELECT isFound = 1 FROM Clients WHERE ClientID = @ClientID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ClientID", ClientID);

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

        public static bool IsAccountNumberExist(string AccountNumber)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "SELECT isFound = 1 FROM Clients WHERE AccountNumber = @AccountNumber";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);

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

        public static DataTable GetAllClients()
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT ClientID, AccountNumber,Password ,AccountBalance,FirstName,LastName,Email,Phone,Address,DateOfBirth,ImagePath
                            FROM Clients
                            INNER JOIN Persons
                            ON Clients.PerID = Persons.PersonID;";

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

        public static int GetClientsCount()
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "SELECT COUNT(ClientID) FROM Clients";

            SqlCommand command = new SqlCommand(query, connection);

            object reader = null;

            int ClientsCount = 0;

            try
            {
                connection.Open();
                reader = command.ExecuteScalar();

                if (reader != null && int.TryParse(reader.ToString(), out int Count))
                {
                    ClientsCount = Count; 
                }
         
            }

            catch (Exception ex)
            {
               
            }
            finally
            {
                connection.Close();
            }

            return ClientsCount;
        }
    }
}
