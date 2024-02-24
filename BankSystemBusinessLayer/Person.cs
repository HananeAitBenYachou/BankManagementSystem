using System;
using System.Data.SqlClient;
using BankSystemDataAccessLayer;

namespace BankSystemBusinessLayer
{
    public class clsPerson
    {
        private enum enMode { AddNew = 0, Update = 1 };

        private enMode _Mode;

        public int PersonID { get; private set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Password { get; set; }

        public string ImagePath { get; set; }

        protected clsPerson(int PersonID, string FirstName, string LastName, string Email, string Phone, string Address, DateTime DateOfBirth, string Password, string ImagePath)
        {
            this.PersonID = PersonID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Phone = Phone;
            this.Address = Address;
            this.DateOfBirth = DateOfBirth;
            this.Password = Password;
            this.ImagePath = ImagePath;

            _Mode = enMode.Update; 
        }

        protected clsPerson()
        {
            this.PersonID = -1;
            this.FirstName = "";
            this.LastName = "";
            this.Email = "";
            this.Phone = "";
            this.Address = "";
            this.DateOfBirth = DateTime.Now;
            this.Password = "";
            this.ImagePath = "";

            _Mode = enMode.AddNew;
        }

        protected static clsPerson Find(int PersonID)
        {
            string FirstName = "", LastName = "", Email = "", Phone = "", Address = "", Password = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now;

            bool isFound = clsPersonDataAccess.GetPersonByID(PersonID, ref FirstName, ref LastName, ref Email, ref Phone, ref Address, ref DateOfBirth, ref Password, ref ImagePath);

            if (isFound)
            {
                return new clsPerson(PersonID, FirstName, LastName, Email, Phone, Address, DateOfBirth, Password, ImagePath);
            }

            else
            {
                return null;
            }
        }

        private bool _AddNewPerson()
        {
            PersonID = clsPersonDataAccess.AddNewPerson(FirstName, LastName, Email, Phone, Address, DateOfBirth,Password,ImagePath) ;
            return (PersonID != -1);
        }

        private bool _UpdatePerson()
        {
            return clsPersonDataAccess.UpdatePerson(PersonID, FirstName, LastName, Email, Phone, Address, DateOfBirth, Password, ImagePath);
        }

        protected static bool DeletePerson(int PersonID)
        {
            return clsPersonDataAccess.DeletePerson(PersonID); 
        }

        protected static bool IsPersonExist(int PersonID)
        {
            return clsPersonDataAccess.IsPersonExist(PersonID); 
        }

        public bool Save()
        {
            switch(_Mode)
            {
                case enMode.AddNew:
                    {
                        if (_AddNewPerson())
                        {
                            _Mode = enMode.Update;
                            return true;
                        }
                        else
                            return false;
                    }
                    
                case enMode.Update:
                    {
                        if (_UpdatePerson())
                            return true;
                        else
                            return false;
                    }                                 
            }

            return false;
        }
    }
}
