using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetProject
{
    internal class Pet
    {
        private string? name;
        private int age;
        private bool isFemale;

        private void ReadData()
        {
            Console.WriteLine("\nEnter name of pet:");
            name = Console.ReadLine();

            Console.WriteLine("\nEnter age of pet(year(s)):");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("\nIs the pet a female(y/n)?");
            string answer = Console.ReadLine();
            if(answer == "y" || answer == "yes") 
            {
                isFemale = true;
                var dummy = 0;
            }
            else
            {
                isFemale = false;
                var dummy = 0;
            }
        }

        internal void ShowData()
        {
            Console.WriteLine($"\nYour pets' name is: {name}");
            Console.WriteLine(isFemale ? $"\nHer age is {age} year" : $"\nHis age is {age} year");
        }

        public void Run()
        {
            Console.WriteLine("Hello and welcome to me pet project!");
            ReadData();
            ShowData();
        }
    }
}
