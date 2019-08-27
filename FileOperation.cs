using System;
using System.Linq;

namespace FileOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isBear = false;
            const string FILE_PATH = "textfileBears.txt";

            //retrieves the first line from a text file.
            string lineOne = System.IO.File.ReadLines(FILE_PATH).First();
            //splits the first line into individual words.
            string[] splitLine = lineOne.Split();
            //searches through the array of words looking for the word "bear."
            foreach(string word in splitLine)
            {
                //when the word "bear." is found isBear becomes true .
                if(word == "bear.")
                {
                    isBear = true;
                    break;
                }
                
            }
            //when isBear is true it prints that the word bear is present if its false it prints saying that it's not.
            if (isBear)
            {
                Console.WriteLine("The line contains the word \"bear.\"");
            }
            else
            {
                Console.WriteLine("This line doesn't contain the word \"bear.\"");
            }
            
        }
    }
}
