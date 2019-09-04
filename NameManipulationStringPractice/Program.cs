using System;

namespace NameManipulationStringPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name? ");

            string firstName;
            firstName = Console.ReadLine();

            Console.WriteLine("Your first name is: " + firstName);

            Console.WriteLine("What is your last name? ");

            string lastName = Console.ReadLine();

            Console.WriteLine("Your full name is: " + firstName.ToLower()+ " " + lastName.ToLower());

            if(firstName.Length > lastName.Length) Console.WriteLine(firstName);
            
            if(lastName.Length > firstName.Length) Console.WriteLine(lastName);

            if(lastName.Length == firstName.Length) Console.WriteLine("Your first and last name are equal in character length");
            

        }
    }
}
