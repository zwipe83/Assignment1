/// < summary >
/// Filename: Pet.cs
/// Created on: 2024-01-20 00:00:00
/// Author: Samuel Jeffman
/// </summary>

namespace PetProject
{
    /// <summary>
    /// Class Pet
    /// </summary>
    internal class Pet
    {
        /// <summary>
        /// Declare fields
        /// </summary>
        private string? name;   //name of pet
        private int age;        //age of pet
        private bool isFemale;  //Is the pet female?

        /// <summary>
        /// Read and save data from console input
        /// </summary>
        private void SaveData()
        {
            Console.WriteLine("\nEnter name of pet:");
            name = Console.ReadLine();

            Console.WriteLine($"\nWhat is {name}s' age?");
            if(!int.TryParse(Console.ReadLine(), out age))
            {
                age = 0;
            }

            Console.WriteLine($"\nIs {name} a female(y/n)?");
            string? answer = Console.ReadLine();

            if( answer != null )
            {
                answer = answer?.Trim();
            }

            char response = ((answer is not null && answer.Length > 0) ? answer[0] : '\0');

            if((response == 'y') || (response == 'Y')) 
            {
                isFemale = true;
            }
            else
            {
                isFemale = false;
            }
        }

        /// <summary>
        /// Retrieve and display data from object fields
        /// </summary>
        private void DisplayInfo()
        {
            Console.WriteLine($"\n\nYour pets' name is: {name}");
            Console.WriteLine(isFemale ? $"Her age is {age} year(s)" : $"His age is {age} year(s)");
        }

        /// <summary>
        /// Entry point for start of an instance of this class
        /// </summary>
        public void Run()
        {
            Console.WriteLine("Hello and welcome to my pet project!");
            SaveData();
            DisplayInfo();
        }
    }
}
