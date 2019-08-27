using System;

namespace FIbonacciSequence
{
    class Program
    {
        static int Fibonacci(int n)
        {
            int x, y;
            //when n is greater than 1 call the fibonacci function to find the previous two values of the sequence.
            if (n > 1)
            {
                x = Fibonacci(n - 1);
                y = Fibonacci(n - 2);
            }
            else
            {
                //when n equals 0 the result is 1
                if (n == 0)
                {
                    x = 1;
                    y = 0;
                }
                //when n equals 1 the result is 1
                else
                {
                    x = n;
                    y = n - 1;
                }
            }
            //returns the sum of the previous two entries to get the next number in the sequence.
            return x + y;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the position of the fibonacci number you'd like to see.");
            int n;
            string input = Console.ReadLine();
            Int32.TryParse(input, out n);
            Console.WriteLine(Fibonacci(n));
        }
       
    }
}
