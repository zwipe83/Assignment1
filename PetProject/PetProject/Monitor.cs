/// < summary >
/// Filename: Monitor.cs
/// Created on: 2024-01-20 00:00:00
/// Author: Samuel Jeffman
/// </summary>

using System.ComponentModel;

namespace PetProject
{
    /// <summary>
    /// Class Monitor
    /// </summary>
    internal class Monitor
    {
        // Fields
        private string? manufacturer;
        private string? modelName;
        private double price;
        private DateTime purchaseDate;

        /// <summary>
        /// Save manufacturer name
        /// </summary>
        private void SaveManufacturer()
        {
            Console.WriteLine("\nWhat is the name of the manufacturer of your monitor?");
            manufacturer = Console.ReadLine();
        }

        /// <summary>
        /// Save model name
        /// </summary>
        private void SaveModel()
        {
            Console.WriteLine("\nWhat is the model name?");
            modelName = Console.ReadLine();
        }

        /// <summary>
        /// Save the date of purchase
        /// </summary>
        private void SavePurchaseDate()
        {
            Console.WriteLine("\nWhat date(yyyy-MM-dd) did you buy your monitor?");
            if (!DateTime.TryParse(Console.ReadLine(), out purchaseDate))
            {
                purchaseDate = DateTime.Today;
            }
        }
        
        /// <summary>
        /// Save what is cost
        /// </summary>
        private void SavePrice()
        {
            Console.WriteLine("\nWhat did it cost?");
            if(!double.TryParse(Console.ReadLine(), out price))
            {
                price = 0.0;
            }
        }

        /// <summary>
        /// Save data
        /// </summary>
        private void SaveData()
        {
            SaveManufacturer();
            SaveModel();
            SavePurchaseDate();
            SavePrice();
        }

        /// <summary>
        /// Display information in Console
        /// </summary>
        private void DisplayInfo()
        {
            Console.WriteLine($"\n\nName of manufacturer: {manufacturer}" +
                $"\nModel name: {modelName}" +
                $"\nDate of purchase: {purchaseDate.Date:yyyy-MM-dd}" +
                $"\nPurchase cost: {price}");
        }

        /// <summary>
        /// Run method
        /// </summary>
        public void Run()
        {
            Console.WriteLine("\n------------------------\nWelcome to the electronics store!");
            SaveData();
            DisplayInfo();
        }
    }
}
