using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace UserRegistration
{
    public class RegexValidation
    {   //Regex is a sequence of characters that specifies a search pattern in text
        //Pattern for First Name validation ---- First name starts with capital and has min 3 characters
        public const string Regex_FirstName = "^[A-Z]{1}[A-Za-z]{2,}$";
        //Pattern for Last Name validation ---- last name starts with capital and has min 3 characters
        public const string Regex_LastName  = "^[A-Z]{1}[A-Za-z]{2,}$";
        //Pattern for Email Name validation ---- 3 mandatory parts and 2 optional parts
        public const string Regex_Email = "^[0-9A-Za-z]+([._+-][0-9A-Za-z]+)*[@][0-9A-Za-z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";
        //Pattern for Phone Name validation ---- country code followed by space and 10 digit numbers
        public const string Regex_PhoneNumber = "^[1-9]{1}[0-9]{0,3}\\s[1-9]{1}[0-9]{9}$";
        //^[a-z0-9](.[a-z])+@[a-z]+\.[a-z]{2,3}$

        //\S matches for any non-whitespace character in the set
        //Pattern for Password validation ---- min 8 characters
        public const string Regex_Password = "[\\S]{8,}";

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

        //Method for Last name validation
        public bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email, Regex_Email);
        }
        //Method for Phone Number validation
        public bool ValidatePhone(string PhoneNumber)
        {
            return Regex.IsMatch(PhoneNumber, Regex_PhoneNumber);
        }

        public bool ValidatePassword(string password)
        {
            return Regex.IsMatch(password, Regex_Password);
        }
    }
}
