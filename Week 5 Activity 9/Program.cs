using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5_Activity_9
{
    class Program
    {
        static void Main(string[] args)
        {
            /* methods being tested */

            // #1
            Stubs.AddNums(7, 10);

            // #2
            Console.WriteLine("2: " + Stubs.Avg(7.6, 1.3, 9, 14.6, 4.55));

            // #3
            Console.WriteLine("3: " + Stubs.RandomSum()); 

            // #4
            Console.WriteLine("4: " + Stubs.DivByThree(1, 2, 3)); // true output
            Console.WriteLine("4: " + Stubs.DivByThree(2, 2, 3)); // false output

            // #5
            Stubs.ShortString("I am a string", "I am also a string");

            // #6
            double[] array = { 8.3, 6.1, 74.3, 61.85, 48.2 }; // array
            Console.WriteLine("6: " + Stubs.HighestArrayValue(array));

            // #7
            int[] fifty = Stubs.FiftyInts(); // call for array
            Console.Write("7: "); for (int i = 0; i < 50; i++) { Console.Write(fifty[i] + " "); } Console.WriteLine(" "); // print

            // #8
            Console.WriteLine("8: " + Stubs.TrueOrFalse(true, true)); // true
            Console.WriteLine("8: " + Stubs.TrueOrFalse(true, false)); // false

            // #9
            Console.WriteLine("9: " + Stubs.Product(5.5, 7));

            // #10
            int[,] array2D = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } }; // 2D array
            Console.WriteLine("10: " + Stubs.Avg2DArray(array2D));

            // prevents console from closing until enter key is pressed
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        }
    }

    static class Stubs
    {
        // a method that takes two integers and displays their sum
        public static void AddNums(int a, int b)
        {
            Console.WriteLine("1: " + (a + b));
        }

        // a method that takes five doubles and returns their average
        public static double Avg(double a, double b, double c, double d, double e)
        {
            double avg = ((double) (a + b + c + d + e) / 5);

            return avg;
        }

        // a method that returns the sum of two randomly generated integers
        public static int RandomSum()
        {
            Random rand = new Random();
            int a = rand.Next(1, 100);
            int b = rand.Next(1, 100);
            int num = a + b;

            return num;
        }

        // a method that takes three integers and returns true if their sum is divisible by 3, false otherwise
        public static Boolean DivByThree(int a, int b, int c)
        {
            int num = a + b + c;
            if (num % 3 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // a method that takes two strings and displays the string that has fewer characters
        public static void ShortString(String a, String b)
        {
            if (a.Length > b.Length)
            {
                Console.WriteLine("5: " + b);
            }
            else
            {
                Console.WriteLine("5: " + a);
            }
        }

        // a method that takes an array of doubles and returns the largest value in the array
        public static double HighestArrayValue(double[] array)
        {
            double highest = 0; 
            for (int i = 0; i < array.Length; i++) 
            {
                if (array[i] > highest) 
                {
                    highest = array[i]; 
                }
            }

            return highest;
        }

        // a method that generates and returns an array of fifty integer values
        public static int[] FiftyInts()
        {
            Random rand = new Random();

            int[] fifty = new int[50];
            for (int i = 0; i < fifty.Length; i++) 
            {
                fifty[i] = rand.Next(1, 100); 
            }

            return fifty;
        }

        // a method that takes two bool variables and returns true if they have the same value, false otherwise
        public static Boolean TrueOrFalse(bool a, bool b)
        {
            if (a == b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // a method that takes an int and a double and returns their product
        public static double Product(double a, int b)
        {
            double c = ((double)a * b); 

            return c;
        }

        // a method that takes a two-dimensional array of integers and returns the average of the entries
        public static double Avg2DArray(int[,] array)
        {
            int total = 0; 

            for (int i = 0; i < 3; i++) 
            {
                for (int j = 0; j < 3; j++) 
                {
                    total += array[i, j]; 
                }
            }

            double avg = ((double)total / 9);

            return avg;
        }
    }
}
