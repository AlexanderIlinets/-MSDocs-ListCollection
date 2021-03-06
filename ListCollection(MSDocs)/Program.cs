﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare List<T>
            var names = new List<string> { "Alex", "Ana", "Felipe" };
            //Use foreach loop to iterate through 'names' List<T>
            foreach (var name in names)
            {
                //Using sting interpolation feature to print each item
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            Console.WriteLine();
            //Adding items to 'names' List<T>
            names.Add("Maria");
            names.Add("Bill");
            names.Add("Ana");
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            Console.WriteLine();
            //Referencing items in 'names' List<T> by index
            Console.WriteLine($"My name is {names[0]}.");
            Console.WriteLine($"I've added names {names[2]} and {names[3]} to the list.");
            //Using the Count property to get number of items in list
            Console.WriteLine($"The list has {names.Count} people in it");

            Console.WriteLine();
            //Using IndexOf method to find item index using item value
            var index = names.IndexOf("Felipe");
            if (index != -1)
            {
                Console.WriteLine($"The name {names[index]} is at index {index}");
            }

            //If index of list item is not found, -1 is returned
            var notFound = names.IndexOf("Tommy");
            Console.WriteLine($"When an item is not found, IndexOf returns {notFound}");

            Console.WriteLine();
            //Using the Sort method to put list items in alphabetical order
            names.Sort();
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            Console.WriteLine();
            //Declare new List<T> of int type
            var fibonacciNumbers = new List<int> { 1, 1 };

            //Using for loop to add 20 fibonacci numbers to list
            for (int i = 0; i < 18; i++) //or while(fibonacciNumbers.Count < 20)
            {
                //Declaring two variables that will hold the values of the 2 previous number in the list
                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
                //Adding the sum of the 2 previous numbers to the fibonacciNumbers List
                fibonacciNumbers.Add(previous + previous2);
            }

            foreach (var item in fibonacciNumbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
