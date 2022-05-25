using System;

namespace UserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t User Registration using Regular Expression (Regex)");
            RegexValidation regexValidation = new RegexValidation();
            Console.Write("Enter Your First Name : ");
            string firstName = Console.ReadLine();
            Console.WriteLine(regexValidation.ValidateFirstName(firstName));
        }
    }
}
