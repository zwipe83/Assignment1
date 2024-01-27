/// < summary >
/// Filename: Program.cs
/// Created on: 2024-01-20 00:00:00
/// Author: Samuel Jeffman
/// </summary>

namespace PetProject
{
    /// <summary>
    /// Class Program
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main entry point
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            SetupConsole();

            //Create class objects
            Pet pet = new Pet();
            TicketSeller tickets = new TicketSeller();
            Album album = new Album();
            Monitor monitor = new Monitor();

            //Run methods
            pet.Run();
            Pause();
            tickets.Run();
            Pause();
            album.Run();
            Pause();
            monitor.Run();
        }

        static void Pause()
        {
            Console.WriteLine("\nPress Enter to continue to next part!");
            Console.ReadLine();
            Console.Clear();
        }

        static void SetupConsole()
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Title = "Pet Project!";
        }
    }
}
