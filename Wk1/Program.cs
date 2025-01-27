using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to ITSE1302");

            //Excersiese 2
            //Get firstName
            Console.Write("What is your first name: ");
            string fname = Console.ReadLine();
            //Get lastname
            Console.Write("What is your last name: ");
            string lname = Console.ReadLine();
            //Get age
            Console.Write("What is your age: ");
            int age = int.Parse(Console.ReadLine());
            //Get color
            Console.Write("Enter your favorite color: ");
            string color = Console.ReadLine();

            // Print statement
            Console.WriteLine($"Hello {fname}{lname}, you are {age} years old and your favorite color is {color}.");

        }
    }
}
