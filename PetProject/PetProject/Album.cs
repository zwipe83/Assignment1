using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            DisplayInfo();
        }
    }
}
