using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserregistraionMstest
{
    public class UserValidation
    {
        const string REGEX_NAME = "^[A-Z]{1}[A-Za-z]{2,}";
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
    }
}
