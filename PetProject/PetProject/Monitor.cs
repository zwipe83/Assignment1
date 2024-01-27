/// < summary >
/// Filename: Monitor.cs
/// Created on: 2024-01-20 00:00:00
/// Author: Samuel Jeffman
/// </summary>

using System.ComponentModel;
using System.Reflection;
using System.Xml.Linq;

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
        private int horizontalResolutionInPixels;
        private int verticalResolutionInPixels;
        private int totalResolutionInPixels;
        private double price;
        private DateTime purchaseDate;

        // Properties
        [Description("Name of manufacturer")]
        public string? Manufacturer { get { return manufacturer; } }
        [Description("Model name")]
        public string? ModelName { get { return modelName; } }

        [Description("Horizontal resolution(in pixels)")]
        public int HorizontalResolutionInPixels { get {  return horizontalResolutionInPixels; } }

        [Description("Vertical resolution(in pixels)")]
        public int VerticalResolutionInPixels { get { return verticalResolutionInPixels; } }

        [Description("Total resolution(in pixels)")]
        public int TotalResolutionInPixels { get { return totalResolutionInPixels; } }

        [Description("The cost of the monitor")]
        public double Price { get { return price; } }

        [Description("Purchase date of monitor")]
        public DateTime PurchaseDate { get {  return purchaseDate; } }

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
        /// Save horizontal resolution
        /// </summary>
        private void SaveHorizontalResolution()
        {
            Console.WriteLine("\nWhat is the horizontal resolution in pixels?");
            if (!int.TryParse(Console.ReadLine(), out horizontalResolutionInPixels))
            {
                horizontalResolutionInPixels = 1920;
            }
        }

        /// <summary>
        /// Save vertical resolution
        /// </summary>
        private void SaveVerticalResolution()
        {
            Console.WriteLine("\nWhat is the vertical resolution in pixels?");
            if (!int.TryParse(Console.ReadLine(), out verticalResolutionInPixels))
            {
                verticalResolutionInPixels = 1080;
            }
        }

        /// <summary>
        /// Calculate total number of pixels the monitor has
        /// </summary>
        private void CalculateTotalResolution()
        {
            totalResolutionInPixels = horizontalResolutionInPixels * verticalResolutionInPixels;
        }

        /// <summary>
        /// Save the date of purchase
        /// </summary>
        private void SavePurchaseDate()
        {
            Console.WriteLine("\nWhat date did you buy your monitor?");
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
            SaveHorizontalResolution();
            SaveVerticalResolution();
            CalculateTotalResolution();
            SavePurchaseDate();
            SavePrice();
        }

        /// <summary>
        /// Write information to a text file
        /// </summary>
        private void WriteToFile()
        {
            //Create path to "My documents" folder
            string myDocPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            //Write information about your monitor object to a file
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(myDocPath, "MonitorInfo.txt")))
            {
                foreach (PropertyInfo prop in this.GetType().GetProperties())
                {
                    var value = prop.GetValue(this, null); //Property value
                    Attribute? attribute = prop.GetCustomAttribute(typeof(DescriptionAttribute), true); //Get property attribute "Description"
                    DescriptionAttribute description = (DescriptionAttribute)attribute; //Get description
                    outputFile.WriteLine($"{((description is not null)? description.Description : prop.Name)}: {value?.ToString()}"); //Write line to file
                }
            }
        }

        /// <summary>
        /// Display information in Console
        /// </summary>
        private void DisplayInfo()
        {
            Console.WriteLine($"\n\nName of manufacturer: {manufacturer}" +
                $"\nModel name: {modelName}" +
                $"\nHorizontal resolution(in pixels): {horizontalResolutionInPixels}" +
                $"\nVertical resolution(in pixels): {verticalResolutionInPixels}" +
                $"\nTotal number of pixels on screen: {totalResolutionInPixels}" +
                $"\nDate of purchase: {purchaseDate.Date.ToString("yyyy-MM-dd")}" +
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
            Console.WriteLine($"\nDo you want to save monitor information in a file(in 'My Documents' folder)?(y/n)?");
            string? answer = Console.ReadLine();
            answer = answer?.Trim();

            char response = ((answer is not null) ? answer[0] : '\0');

            if ((response == 'y') || (response == 'Y'))
            {
                WriteToFile();
                Console.WriteLine("\nFile saved in My Documents/MonitorInfo.txt");
            }
        }
    }
}
