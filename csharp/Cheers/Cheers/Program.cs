using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();
            string lowerName = name.ToLower();
            string anLetters = "halfnorsemix";
            foreach (char letter in lowerName)
            {
                if (anLetters.Contains(letter))
                {
                    Console.Write("Give me an " + letter + "!\n");
                }
                else
                {
                    Console.Write("Give me a " + letter + "!\n");
                }
            }
            Console.Write(name.ToUpper() + " is just GRAND!\n");
            Console.ReadKey();            
        }

        
    }
}
