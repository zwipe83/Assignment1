﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            price = decimal.Parse(Console.ReadLine());
        }

        private void SaveVisitors()
        {
            Console.WriteLine("\nHow many adults?");
            numberOfAdults = int.Parse(Console.ReadLine());
            Console.WriteLine("\nHow many children?");
            numberOfchildren = int.Parse(Console.ReadLine());
        }

        private void CalculateCost()
        {
            totalCost = (numberOfAdults * price) + (numberOfchildren * (price - (price * childrensDiscount)));
        }

        private void ShowCost()
        {
            Console.WriteLine($"\n{name}, Your total cost will be: {totalCost.ToString("N2")}");                
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
