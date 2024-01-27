/// < summary >
/// Filename: Album.cs
/// Created on: 2024-01-20 00:00:00
/// Author: Samuel Jeffman
/// </summary>

namespace PetProject
{
    internal class Album
    {
        //Fields
        private string? name;
        private string? artist;
        private int numOfTracks;
        private int yearOfRelease;

        /// <summary>
        /// Save album name
        /// </summary>
        private void SaveName()
        {
            Console.WriteLine("\nWhat is the name of your favorite album?");
            name = Console.ReadLine();
        }

        /// <summary>
        /// Save artist name
        /// </summary>
        private void SaveArtist()
        {
            Console.WriteLine("\nWhat is the artists name?");
            artist = Console.ReadLine();
        }

        /// <summary>
        /// Save number of tracks on album
        /// </summary>
        private void SaveNumberOfTracks()
        {
            Console.WriteLine("\nHow many songs are there on the album?");
            if (!int.TryParse(Console.ReadLine(), out yearOfRelease))
            {
                numOfTracks = 0;
            }
        }

        /// <summary>
        /// Save year of release of the album
        /// </summary>
        private void SaveYear()
        {
            Console.WriteLine("\nWhat year was the album released?");
            if (!int.TryParse(Console.ReadLine(), out yearOfRelease))
            {
                yearOfRelease = 0;
            }
        }

        /// <summary>
        /// Run save methods
        /// </summary>
        private void SaveData()
        {
            SaveName();
            SaveArtist();
            SaveNumberOfTracks();
            SaveYear();
        }

        /// <summary>
        /// Display information
        /// </summary>
        private void DisplayInfo()
        {
            Console.WriteLine($"\n\nName of the album: {name}" +
                $"\nName of the artist: {artist}" +
                $"\nNumber of tracks: {numOfTracks}" +
                $"\nYear of release: {yearOfRelease}");
        }

        /// <summary>
        /// Run method
        /// </summary>
        public void Run()
        {
            Console.WriteLine("------------------------\nWelcome to my Music hall of fame!");
            SaveData();
            DisplayInfo();
        }
    }
}
