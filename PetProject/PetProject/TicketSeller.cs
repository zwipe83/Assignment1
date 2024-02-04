/// < summary >
/// Filename: TicketSeller.cs
/// Created on: 2024-01-20 00:00:00
/// Author: Samuel Jeffman
/// </summary>

namespace PetProject
{
    /// <summary>
    /// Class
    /// </summary>
    internal class TicketSeller
    {
        //Fields
        private string? name;
        private double price = 100.0;
        private int numberOfAdults;
        private int numberOfchildren;
        private double amountToPay;
        private double childrensDiscount = 0.25;

        /// <summary>
        /// Save name of visitor
        /// </summary>
        private void SaveName()
        {
            Console.WriteLine("\nWhat is your name?");
            name = Console.ReadLine();
        }

        /// <summary>
        /// Save price of ticket, currently not used
        /// </summary>
        private void SavePrice()
        {
            Console.WriteLine("\nWhat is the cost of a ticket?");
            if (!double.TryParse(Console.ReadLine(), out price))
            {
                price = 0.0;
            }
        }

        /// <summary>
        /// Save number of visitors, adults and children
        /// </summary>
        private void SaveVisitors()
        {
            Console.WriteLine("\nHow many adults?");
            if (!int.TryParse(Console.ReadLine(), out numberOfAdults))
            {
                numberOfAdults = 0;
            }
            Console.WriteLine("\nHow many children?");
            if (!int.TryParse(Console.ReadLine(), out numberOfchildren))
            {
                numberOfchildren = 0;
            }
        }

        /// <summary>
        /// Calculate amount to pay
        /// </summary>
        private void CalculateCost()
        {
            amountToPay = (numberOfAdults * price) + (numberOfchildren * (price * childrensDiscount));
        }

        /// <summary>
        /// Display information on how much to pay
        /// </summary>
        private void DisplayInfo()
        {
            Console.WriteLine($"\n\n{name}, ticket prices are {price:N2} per ticket.\nYour total cost will be: {amountToPay:N2}, including a 75% discount for children.");                
        }

        /// <summary>
        /// Save data
        /// </summary>
        private void SaveData()
        {
            SaveName();
            //SavePrice(); //Currently not used.
            SaveVisitors();
        }

        /// <summary>
        /// Run method
        /// </summary>
        public void Run()
        {
            Console.WriteLine("------------------------\nHello and welcome to my circus!");
            SaveData();
            CalculateCost();
            DisplayInfo();
        }
    }
}
