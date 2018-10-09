using System;

namespace NumbersInCSharp
{
    class Program
    {
        static void WorkingWithIntegers()
        {

            // Simple equations using mathmatical concepts and variables
            int a = 18;
            int b = 6;
            int c = a + b;
            Console.WriteLine(c);

            c = a - b;
            Console.WriteLine(c);

            c = a * b;
            Console.WriteLine(c);

            c = a / b;
            Console.WriteLine(c);
        }

        static void OrderPrecedence()
        {           
            int a = 5;
            int b = 4;
            int c = 2;

            //Example of Order of Operations, computed result is the addition of a to b * c
            int d = a + b * c;
            Console.WriteLine(d);

            // Same equation, different syntax... a+b is computed first in parenthesis then multiplied by c
            d = (a + b) * c;
            Console.WriteLine(d);

            d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
            Console.WriteLine(d);
        }

        static void QuotientRemainder()
        {

            int a = 7;
            int b = 4;
            int c = 3;
            int d = (a + b) / c;
            int e = (a + b) % c;
            Console.WriteLine($"quotient: {d}");
            Console.WriteLine($"remainder: {e}");

        }

        static void OverflowExample()
        {
            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} to {max}");


            // example of overflow, the maximum value for int overflows and wraps around to a large negative value, or min + 2

            int what = max + 3;
            Console.WriteLine($"An example of overflow: {what}");

        }


        static void WorkWithDoubles()
        {

            double a = 5;
            double b = 4;
            double c = 2;
            double d = (a + b) / c;
            Console.WriteLine(d);

            double e = 19;
            double f = 23;
            double g = 8;
            double h = (e + f) / g;
            Console.WriteLine(h);

            double max = double.MaxValue;
            double min = double.MinValue;
            Console.WriteLine($"the range of double is {min} to {max}");

        }

        static void Main(string[] args)
        {

        }
    }
}
