using BankSystemDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemBusinessLayer
{
    public class clsUser : clsPerson
    {
        private enum enMode { AddNew = 0, Update = 1 };

        private enMode _Mode;

        public enum enPermissions
        {
            eAll = -1 , eShowList = 1, eFindClient = 2, eAddClient = 4, eUpdateClient = 8, eDeleteClient = 16, eManageUsers = 32,
            eTransactions = 64, eShowLogLogin = 128
        }

        public int UserID { get; private set; }


        private int PerID;

        public string UserName { get; set; }

        public short Permissions { get; set; }

        public decimal Salary { get; set; }

        private clsUser(int PersonID, string FirstName, string LastName, string Email, string Phone, string Address, DateTime DateOfBirth, string Password, string ImagePath,
            int UserID, string UserName, short Permissions, decimal Salary) : base(PersonID, FirstName, LastName, Email, Phone, Address, DateOfBirth, Password, ImagePath)
        {

            this.UserID = UserID;
            this.UserName = UserName;
            this.PerID = PersonID;
            this.Permissions = Permissions;
            this.Salary = Salary;

            _Mode = enMode.Update;
        }

        public clsUser() 
        {
            this.UserID = -1;
            this.UserName = ""; 
            this.PerID = -1;
            this.Permissions = 0;
            this.Salary = 0;

            _Mode = enMode.AddNew;
        }

        public static new clsUser Find(int UserID)
        {
            int PerID = -1;
            string UserName = "";
            short Permissions = 0;
            decimal Salary = 0;

            bool isUserFound = clsUserDataAccess.GetUserByID(UserID, ref PerID, ref UserName, ref Permissions, ref Salary);

            if (isUserFound)
            {
                clsPerson person = clsPerson.Find(PerID);

                return new clsUser(person.PersonID, person.FirstName, person.LastName, person.Email, person.Phone, person.Address, person.DateOfBirth, person.Password, person.ImagePath,
               UserID,UserName, Permissions, Salary);

            }

            return null;
        }

        public static  clsUser Find(string UserName ,string Password)
        {
            int PerID = -1;
            int UserID = -1;
            short Permissions = 0;
            decimal Salary = 0;

            bool isUserFound = clsUserDataAccess.GetUserByUserNameAndPassword(UserName, Password,ref UserID, ref PerID, ref Permissions, ref Salary);

            if (isUserFound)
            {
                clsPerson person = clsPerson.Find(PerID);

                return new clsUser(person.PersonID, person.FirstName, person.LastName, person.Email, person.Phone, person.Address, person.DateOfBirth, person.Password, person.ImagePath,
               UserID, UserName, Permissions, Salary);

            }

            return null;
        }

        private bool _AddNewUser()
        {
            if (base.Save())
            {
                PerID = PersonID;
                UserID = clsUserDataAccess.AddNewUser(PerID,UserName, Permissions, Salary);
                return (UserID != -1);
            }

            return false;
        }

        private bool _UpdateUser()
        {
            if (base.Save())
            {
                return clsUserDataAccess.UpdateUser(UserID,UserName, Permissions, Salary);
            }

            return false;
        }

        public static bool DeleteUser(int UserID)
        {
            clsUser User = clsUser.Find(UserID);
            int personID = User.PersonID;

            if (clsUserDataAccess.DeleteUser(UserID))
            {
                return clsPerson.DeletePerson(personID);
            }

            return false;
        }

        public static bool IsUserExist(int UserID)
        {
            return clsUserDataAccess.IsUserExist(UserID);
        }

        public static DataTable GetAllUsers()
        {
            return clsUserDataAccess.GetAllUsers(); 
        }

        public static int GetUsersCount()
        {
            return clsUserDataAccess.GetUsersCount();
        }

        public bool CheckAccessPermission(enPermissions Permission)
        {
            if(this.Permissions == (short) enPermissions.eAll)
            {
                return true;
            }

            else if((this.Permissions & (short) Permission ) == (short) Permission)
            {
                return true;
            }

            return false;

        }

        public bool AddNewLoginRecord()
        {
            return (clsLoginDataAccess.AddNewLoginRecord(DateTime.Now, UserName, Password, Permissions) != -1);
        }
        
        public static DataTable GetAllLoginRecords()
        {
            return clsLoginDataAccess.GetAllLoginRecords(); 
        }

        public new bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    {
                        if (_AddNewUser())
                        {
                            _Mode = enMode.Update;
                            return true;
                        }
                        else
                            return false;
                    }

                case enMode.Update:
                    {
                        if (_UpdateUser())
                            return true;
                        else
                            return false;
                    }
            }

            return false;
        }

    }
}
