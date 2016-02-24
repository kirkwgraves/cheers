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
            // Get user's name info and format data
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();
            string lowerName = name.ToLower();
            string anLetters = "halfnorsemix";

            // Get user's birthday info and format data
            DateTime userBirthday = GetUserBirthday(name);
            DateTime today = DateTime.Today;
            double birthdayDelta = (userBirthday - today).TotalDays;

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
            if (birthdayDelta <= 0)
            {
                Console.Write("Happy birthday, " + name + "!");
            }
            else
            {
                Console.Write("Your birthday is " + birthdayDelta + " days away!");
            }
           
            Console.ReadKey();            
        }

        private static DateTime GetUserBirthday(string name)
        {
            Console.WriteLine("When's your birthday, " + name + "? (MM/DD)");
            string userBirthday = Console.ReadLine();
            DateTime birthday = DateTime.Parse(userBirthday);
            return birthday;
        }

        
    }
}
