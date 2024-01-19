using System;
using System.IO;

namespace PetProject
{
    internal class Album
    {
        private string? name;
        private string? artist;
        private int yearOfRelease;
        private string? genre;
        private int numberOfTracks;
        private string? format;
        private string? producer;
        private bool artistIsAlive;

        private void SaveName()
        {
            name = "";
        }

        private void SaveArtist() 
        {
            artist = "";
        }
        private void SaveYear()
        {
            yearOfRelease = 0;
        }

        private void SaveGenre()
        {
            genre = "";
        }

        private void SaveNumberOfTracks()
        { 
            numberOfTracks = 0;
        }        
        private void SaveFormat()
        {
            format = "";
        }

        private void SaveProducer()
        {
            producer = "";
        }

        private void SaveArtisIsAlive() 
        {
            artistIsAlive = true;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"{name} - {artist} - {producer} - {numberOfTracks} - {format} - {genre} - {yearOfRelease}");
        }

        public void Run()
        {
            SaveName();
            SaveArtist();
            SaveYear();
            SaveGenre();
            SaveNumberOfTracks();
            SaveFormat();
            SaveProducer();
            SaveArtisIsAlive();
            DisplayInfo();
        }
    }
}
