using BankSystemDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemBusinessLayer
{
    public class clsClient : clsPerson
    {
        private enum enMode { AddNew = 0, Update = 1 };

        private enMode _Mode;

        public int ClientID { get; private set; }

        private int PerID;

        public string AccountNumber { get; set; }

        public decimal AccountBalance { get; set; }

        private clsClient(int PersonID, string FirstName, string LastName, string Email, string Phone, string Address, DateTime DateOfBirth, string Password, string ImagePath,
            int ClientID, string AccountNumber, decimal AccountBalance) : base(PersonID,FirstName, LastName, Email, Phone, Address, DateOfBirth, Password, ImagePath)
        {

            this.ClientID = ClientID;
            this.PerID = PersonID;
            this.AccountNumber = AccountNumber;
            this.AccountBalance = AccountBalance;

            _Mode = enMode.Update;
        }

        public clsClient() : base()
        {
            this.ClientID = -1;
            this.PerID = -1;
            this.AccountNumber = "";
            this.AccountBalance = 0;

            _Mode = enMode.AddNew;
        }

        public static new clsClient Find(int ClientID)
        {
            int PerID = -1;
            string AccountNumber = "";
            decimal AccountBalance = 0;

            bool isClientFound = clsClientDataAccess.GetClientByID(ClientID, ref PerID, ref AccountNumber, ref AccountBalance);
            
            if (isClientFound)
            {           
               clsPerson person = clsPerson.Find(PerID);

               return new clsClient(person.PersonID, person.FirstName, person.LastName, person.Email, person.Phone, person.Address, person.DateOfBirth, person.Password, person.ImagePath,
              ClientID, AccountNumber, AccountBalance);
              
            }

            return null;
        }

        public static clsClient Find(string AccountNumber)
        {
            int PerID = -1;
            int  ClientID = -1;
            decimal AccountBalance = 0;

            bool isClientFound = clsClientDataAccess.GetClientByAccountNumber(AccountNumber,ref ClientID, ref PerID, ref AccountBalance);

            if (isClientFound)
            {
                clsPerson person = clsPerson.Find(PerID);

                return new clsClient(person.PersonID, person.FirstName, person.LastName, person.Email, person.Phone, person.Address, person.DateOfBirth, person.Password, person.ImagePath,
               ClientID, AccountNumber, AccountBalance);

            }

            return null;
        }

        private bool _AddNewClient()
        {          
            if(base.Save())
            {
                PerID = PersonID;         
                ClientID = clsClientDataAccess.AddNewClient(PerID, AccountNumber, AccountBalance);
                return (ClientID != -1);
            }

            return false;     
        }

        private bool _UpdateClient()
        {
            if (base.Save())
            {
                return clsClientDataAccess.UpdateClient(ClientID, AccountNumber, AccountBalance);
            }

            return false;
        }

        public static bool DeleteClient(int ClientID)
        {
            clsClient Client = clsClient.Find(ClientID);
            int personID = Client.PersonID; 

            if(clsClientDataAccess.DeleteClient(ClientID))
            {
                return clsPerson.DeletePerson(personID); 
            }

            return false;
        }

        public static bool IsClientExist(int ClientID)
        {
            return clsClientDataAccess.IsClientExist(ClientID);
        }

        public static bool IsAccountNumberExist(string AccountNumber)
        {
            return clsClientDataAccess.IsAccountNumberExist(AccountNumber); 
        }

        public static DataTable GetAllClients()
        {
            return clsClientDataAccess.GetAllClients(); 
        }

        public static int GetClientsCount()
        {
            return clsClientDataAccess.GetClientsCount(); 
        }
      
        public bool Withdraw(decimal WithdrawAmount)
        {
            if (WithdrawAmount > AccountBalance)
                return false;

            else
            {
                AccountBalance -= WithdrawAmount;

                return _UpdateClient();
            }
        }

        public bool Deposit(decimal DepositAmount)
        {
            if (DepositAmount <= 0)
                return false;

            else
            {
                AccountBalance += DepositAmount;

                return _UpdateClient(); 
            }
        }

        public bool Transfer(decimal TransferAmount , ref clsClient DestinationClient)
        {
            if(AccountBalance < TransferAmount)
            {
                return false;
            }

            this.Withdraw(TransferAmount);
            DestinationClient.Deposit(TransferAmount);

            return true;
        }

        public new bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    {
                        if (_AddNewClient())
                        {
                            _Mode = enMode.Update;
                            return true;
                        }
                        else
                            return false;
                    }

                case enMode.Update:
                    {
                        if (_UpdateClient())
                            return true;
                        else
                            return false;
                    }
            }

            return false;
        }

    }
}
