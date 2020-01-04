﻿using System;

namespace TestingBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** UNIT PRICE CALCULATOR ***");

            bool quit = false;
            bool holiday = false;

            Console.WriteLine("Are you pricing for a holiday? [Y]es or [N]o");
            string holidayAnswer = Console.ReadKey().ToString().ToUpper();
            if (holidayAnswer == "Y")
            {
                holiday = true;
            }
            Console.WriteLine();

            while (quit == false)
            {

                Console.WriteLine("Enter quantity:");
                int quantity = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the unit price (no dollar sign):");
                decimal retailPrice = decimal.Parse(Console.ReadLine());

                PricingEngine engine = new PricingEngine(holiday);

                decimal unitPrice = engine.CalculateUnitPrice(quantity, retailPrice);

                Console.WriteLine("The calculated unit price is $" + unitPrice);

                Console.WriteLine("Price another product? [Y]es or [N]o");
                string answer = Console.ReadKey().ToString().ToUpper();
                Console.WriteLine();

                if (answer == "N")
                {
                    quit = true;
                }
            }
        }
    }
}