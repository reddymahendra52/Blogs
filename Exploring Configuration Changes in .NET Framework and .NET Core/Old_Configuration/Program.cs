using System;
using System.Configuration;

namespace Old_Configuration
{
    class Program
    {
        static void Main(string[] args)
        {
            string fName = ConfigurationManager.AppSettings["firstName"];
            string lName = ConfigurationManager.AppSettings["lastName"];

            Console.WriteLine($"First Name: {fName}");
            Console.WriteLine($"Last  Name: {lName}");

            Console.ReadLine();

        }
    }
}
