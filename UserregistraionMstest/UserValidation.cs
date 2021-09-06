using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserregistraionMstest
{
    public class UserValidation
    {
        const string REGEX_NAME = "^[A-Z]{1}[A-Za-z]{2,}";
        const string REGEX_EMAIL_ID = @"^[A-Za-z0-9]+([\.+\-_][A-Za-z0-9]+)*@[a-zA-Z0-9]+\.?[A-Za-z]+\.?[A-Za-z]{2,}$";
        const string REGEX_MOBILE_NUMBER = "^[1-9]{1,2}[ ][1-9]{1}[0-9]{9}$";


        public bool FirstName(string firstName)
        {

            Console.WriteLine(" Name Should start with Capital and has Minimum 3 characters : ");


            return Regex.IsMatch(firstName, REGEX_NAME);
        }
        public bool LastName(string lastName)
        {

            Console.WriteLine(" Name start with Capital and has Minimum 3 characters : ");


            return Regex.IsMatch(lastName, REGEX_NAME);
        }
        public bool Email(string email)
        {
            //Return True or False
            return Regex.IsMatch(email, REGEX_EMAIL_ID);
        }
        public bool Mobile(string mobile)
        {
            //Return True or False
            return Regex.IsMatch(mobile, REGEX_MOBILE_NUMBER);
        }
    }
}
