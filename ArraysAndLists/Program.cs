using System;
using System.Collections.Generic;
namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            int[] Array = new int[10] {1,2,3,4,5,6,7,8,9,10};
            // Could write it as: var Array = new int[10] {1,2,3,4,5,6,7,8,9,10};

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
             List<int> evens = new List<int>();
             List<int> odds = new List<int>();
             // Could write it as: var evens/odds = new List<int>();

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */
             foreach (var num in Array)
             {  
                if (num % 2 == 0)
                {
                    evens.Add(num);
                    // Now to address the last question you could just add this here : Console.WriteLine($"{num} is a even number.");
                }
                else
                {
                    odds.Add(num);
                     // Now to address the last question you could just add this here : Console.WriteLine($"{num} is a ODD number.");

                }
             }
             // if you wanted to do a for Loop:
             //for (int i = 0, i < Array.Length; i++)
             //{
             //   if (Array[i] % == 0)
             //   {
             //       evens.Add(Array[i]);
             //   }
             //   else
            //    {
            //        odds.Add(Array[i]);
             //   }
             //}

            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
             foreach (var item in evens)
             {
                Console.WriteLine($"{item} is a even number.");
             }

             foreach (var item in odds)
             {
                Console.WriteLine($"{item} is a odd number.");
             }
        }
    }
}
