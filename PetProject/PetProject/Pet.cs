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
            if(!int.TryParse(Console.ReadLine(), out age))
            {
                age = 0;
            }

            Console.WriteLine("\nIs the pet a female(y/n)?");
            string? answer = Console.ReadLine();
            if(answer == "y" || answer == "yes") 
            {
                isFemale = true;
            }
            else
            {
                isFemale = false;
            }
        }

        private void ShowData()
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
