using System;
using Microsoft.Extensions.Configuration;

namespace NewConfiguration
{
    class Program
    {
        static void Main(string[] args)
        {

            var config = new ConfigurationBuilder()
                            .AddJsonFile("appsetting.json")
                            .AddJsonFile("complexSetting.json") // Adding the other json file also to the config
                            .Build();

            string fName = config["firstName"];
            string lName = config["lastName"];

            string capital = config["Address:State:Capital"];
            string galaxy = config["Address:Location:Galaxy"];

            Console.WriteLine($"First Name: {fName}");
            Console.WriteLine($"Last  Name: {lName}");
            Console.WriteLine($"Capital   : {capital}");
            Console.WriteLine($"Galaxy    : {galaxy}");

        }
    }
}