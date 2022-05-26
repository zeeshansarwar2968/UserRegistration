using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace UserRegistration
{
    public class RegexValidation
    {
        public const string Regex_FirstName = "^[A-Z]{1}[A-Za-z]{2,}$";
        public const string Regex_LastName = "^[A-Z]{1}[A-Za-z]{2,}$";


        //Method for first name validation
        public bool ValidateFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, Regex_FirstName);
        }

        //Method for Last name validation
        public bool ValidateLastName(string LastName)
        {
            return Regex.IsMatch(LastName, Regex_LastName);
        }
    }
}
