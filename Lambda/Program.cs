using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            // Common syntax: args => expression

            // Lambda uses delegates, so Func<>() is valid
            Func<int, int> squareDelegate = SquareMethod;
            Console.WriteLine(squareDelegate(5));

            // If Func is valid, so the following is valid too
            Func<int, int> squareDelegate2 = number => number * number; // and this way, we dont need the SquareMethod() anymore
            Console.WriteLine(squareDelegate2(5));

            // if NO argument is needed, we can write the following
            // () => ...

            // If we have ONE argument, we can write the following
            // x => x...

            // If we have MULTIPLE arguments, we can write the following
            // (x, y, z) => ...
        }

        static int SquareMethod(int number)
        {
            return number * number;
        }
    }
}
