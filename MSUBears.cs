using System;

namespace MSUBears
{
    class Program
    {
        static void Main(string[] args)
        {
            //loops from 1 to 100
            for(int i = 1; i < 101; ++i)
            {
                // when i is divisible by both 3 and 5 print MSUBears to the console.
                if(i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("MSUBears");
                }
                //when i is divisible by just 3 print MSU to the console.
                else if(i % 3 == 0)
                {
                    Console.WriteLine("MSU");
                }
                //when i is divisible by just 5 print Bears to the console.
                else if(i % 5 == 0)
                {
                    Console.WriteLine("Bears");
                }
                //when i isn't divisible by either 5 or 3 print its value.
                else
                {
                    Console.WriteLine(i);
                }               
            }
        }
    }
}
