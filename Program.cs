﻿using System;

namespace ALittleChos1._1.sln
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomizer = new Random();

            Console.WriteLine("Random can make integers: " + randomizer.Next());
            Console.WriteLine("Or a double: " + randomizer.NextDouble());

            int num = randomizer.Next(100);

            Console.WriteLine("You can atore a randomized result: " + num);
            Console.WriteLine("And use it over and over againL: " + num + num);

            Console.WriteLine("Or just keep generating new values");
            Console.WriteLine("Here's a bunch of numbers from 0 - 100: ");

            Console.WriteLine(randomizer.Next(101) + ", ");
            Console.WriteLine(randomizer.Next(101) + ", ");
            Console.WriteLine(randomizer.Next(101) + ", ");
            Console.WriteLine(randomizer.Next(101) + ", ");
            Console.WriteLine(randomizer.Next(101) + ", ");
            Console.WriteLine(randomizer.Next(101));
        }
    }
}
