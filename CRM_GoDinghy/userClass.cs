using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_GoDinghy
{
    public class userClass
    {
        private static int id;
        private static string firstName;
        private static string lastName;
        private static string initials;
        private static bool isAdminUser;
        private static bool isNormalUser;
        private static bool isLoggedIn;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Initials
        {
            get { return initials; }
            set { initials = value; }
        }

        public bool IsAdminUser
        {
            get { return isAdminUser; }
            set { isAdminUser = value; }
        }

        public bool IsNormalUser
        {
            get { return isNormalUser; }
            set { isNormalUser = value; }
        }

        public bool IsLoggedIn
        {
            get { return isLoggedIn; }
            set { isLoggedIn = value; }
        }
    }
}
