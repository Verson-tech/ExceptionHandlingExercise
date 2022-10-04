using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------------------------------------------------------------------------
            // First create a char[], it must contain 6 numbers and 3 letters - name it arr
            var arr = new char[] {'1','2','3','4','5','6','a','b','c'};
            // Create a list called numbers, that will hold integers
            var numbers = new List<int>();
            // Create a string variable with an empty string initializer - name it str
            string str = "";
            // using a foreach loop, attempt to parse the elements in your char[] with int.Parse()           
            foreach (var i in arr)
            {
                // Now create a try catch
                // Inside your try block
                // set your string variable to each array element in your char[] to .ToString()
                // Now, using int.Parse, parse your string variable and store in an int variable
                // Then add each int to your list
                try
                {
                    str = i.ToString();
                    var number = int.Parse(str);
                    numbers.Add(number);
                }
                catch(Exception e)
                {
                    // and Exceptions will be thrown 
                    // Below we will set this up 
                    // ------------------------------------------------------------------------------
                    //TODO START HERE:
                    // Make a foreach loop to iterate through your character array
                    // catch your Exception:
                    // in the scope of your catch you can use the following, 

                    Console.WriteLine($"Unable to Parse '{i}'"); //character will be the name of each item in your collection

                }
            }
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
