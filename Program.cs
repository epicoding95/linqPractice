using System;
using System.Linq;

namespace newPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a setence to be reversed");
            string userAnswer = Console.ReadLine();

            string[] wordArray = userAnswer.Split(' ');
            foreach (string w in wordArray.Reverse())
                Console.Write(w + " ");

            Console.ReadLine();


        }


    }
}
