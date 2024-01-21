using System;
using System.IO;

namespace PetProject
{
    internal class Album
    {
        private string? name;
        private string? artist;
        private int yearOfRelease;
        private string? producer;

        private void SaveName()
        {
            Console.WriteLine("\nWhat is the name of youe favorite album?");
            name = Console.ReadLine();
        }

        private void SaveArtist()
        {
            Console.WriteLine("\nWhat is the artists name?");
            artist = Console.ReadLine();
        }
        private void SaveYear()
        {
            Console.WriteLine("\nWhat year was the album released?");
            if (!int.TryParse(Console.ReadLine(), out yearOfRelease))
            {
                yearOfRelease = 0;
            }
        }

        private void SaveProducer()
        {
            Console.WriteLine("\nWho produced the album?");
            producer = Console.ReadLine();
        }
        private void SaveData()
        {
            SaveName();
            SaveArtist();
            SaveYear();
            SaveProducer();
        }

        private void DisplayInfo()
        {
            Console.WriteLine($"{name} - {artist} - {producer} - {yearOfRelease}");
        }

        public void Run()
        {
            Console.WriteLine("\n------------------------\nWelcome to my Music hall of fame!");
            SaveData();
            DisplayInfo();
        }
    }
}
