using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoffeeShop.Models
{
    public class Register
    {

        private string firstname;
        private string lastname;
        private string email;
        private string phonenumber;
        private string password;

        public Register()
        {
            firstname = "";
            lastname = "";
            email = "";
            phonenumber = "";
            password = "";

        }

        public Register(string firstname, string lastname, string email, string phonenumber, string password)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.email = email;
            this.phonenumber = phonenumber;
            this.password = password;
        }

        public string FirstName
        {
            set { firstname = value; }
            get { return firstname; }
        }

        public string LastName
        {
            set { lastname = value; }
            get { return lastname; }
        }

        public string Email
        {
            set { email = value; }
            get { return email; }
        }

        public string PhoneNumber
        {
            set { phonenumber = value; }
            get { return phonenumber; }
        }

        public string Password
        {
            set { password = value; }
            get { return password; }
        }
    }
}