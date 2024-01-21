using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PetProject
{
    internal class Monitor
    {
        private string? manufacturer;
        private string? modelName;
        private int horizontalResolutionInPixels;
        private int verticalResolutionInPixels;
        private int totalResolutionInPixels;
        private double price;
        private DateTime purchaseDate;

        private void SaveManufacturer()
        {
            Console.WriteLine("\nWhat is the name of the manufacturer of your monitor?");
            manufacturer = Console.ReadLine();
        }
        private void SaveModel()
        {
            Console.WriteLine("\nWhat is the model name?");
            modelName = Console.ReadLine();
        }

        private void SaveHorizontalResolution()
        {
            Console.WriteLine("\nWhat is the horizontal resolution in pixels?");
            if (!int.TryParse(Console.ReadLine(), out horizontalResolutionInPixels))
            {
                horizontalResolutionInPixels = 1920;
            }
        }
        private void SaveVerticalResolution()
        {
            Console.WriteLine("\nWhat is the vertical resolution in pixels?");
            if (!int.TryParse(Console.ReadLine(), out verticalResolutionInPixels))
            {
                verticalResolutionInPixels = 1080;
            }
        }

        private void CalculateTotalResolution()
        {
            totalResolutionInPixels = horizontalResolutionInPixels * verticalResolutionInPixels;
        }

        private void SavePurchaseDate()
        {
            Console.WriteLine("\nWhat date did you buy your monitor?");
            if (!DateTime.TryParse(Console.ReadLine(), out purchaseDate))
            {
                purchaseDate = DateTime.Today;
            }
        }
        private void SavePrice()
        {
            Console.WriteLine("\nWhat date did it cost?");
            if(!double.TryParse(Console.ReadLine(), out price))
            {
                price = 0.0;
            }
        }

        private void SaveData()
        {
            SaveManufacturer();
            SaveModel();
            SaveHorizontalResolution();
            SaveVerticalResolution();
            CalculateTotalResolution();
            SavePurchaseDate();
            SavePrice();
        }

        private void DisplayInfo()
        {
            Console.WriteLine($"{manufacturer} - {modelName} - {horizontalResolutionInPixels} - {verticalResolutionInPixels} - {totalResolutionInPixels} - {purchaseDate.Date.ToString("yyyy-MM-dd")} - {price}");
        }

        public void Run()
        {
            Console.WriteLine("\n------------------------\nWelcome to the electronics store!");
            SaveData();
            DisplayInfo();
        }
    }
}
