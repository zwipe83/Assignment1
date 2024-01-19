namespace PetProject
{
    internal class TicketSeller
    {
        private string? name;
        private decimal price;
        private int numberOfAdults;
        private int numberOfchildren;
        private decimal totalCost;
        private readonly decimal childrensDiscount = 0.25M;

        private void SaveName()
        {
            Console.WriteLine("\nWhat is your name?");
            name = Console.ReadLine();
        }

        private void SavePrice()
        {
            Console.WriteLine("\nWhat is the cost of a ticket?");
            if (!decimal.TryParse(Console.ReadLine(), out price))
            {
                price = 0.0M;
            }
        }

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

        private void CalculateCost()
        {
            totalCost = (numberOfAdults * price) + (numberOfchildren * (price - (price * childrensDiscount)));
        }

        private void ShowCost()
        {
            Console.WriteLine($"\n{name}, Your total cost will be: {totalCost:N2}");                
        }

        public void Run()
        {
            Console.WriteLine("\nHello and welcome to my circus!");
            SaveName();
            SavePrice();
            SaveVisitors();
            CalculateCost();
            ShowCost();
        }
    }
}
