using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Challenge
{
    class Week1Challenge
    {
        static void Main(string[] args)
        {
            string firstName = "jason";
            string lastName = "kyle";
            int age = 48;

            string[] favoriteBooks = { "Dune", "The Hobbit", "The gunslinger","It" };
            List<DateTime> dates = new List<DateTime>();
            dates.Add(DateTime.Now);

            int agePlusSeven = age + 7;
            Console.WriteLine("My age in seven years is " + agePlusSeven.ToString());

            int numberOfHoursSlept = 8;

            if (numberOfHoursSlept >= 10)
            {
                Console.WriteLine("Wow that is a lot of sleep");
            }
            else if (numberOfHoursSlept >= 8 && numberOfHoursSlept < 10)
            {
                Console.WriteLine("You should be rested");
            }
            else if (numberOfHoursSlept > 4 && numberOfHoursSlept < 8)
            {
                Console.WriteLine("Bummer");

            }
            else
            {
                Console.WriteLine("Oh man, get some sleep");
            }

            string todaysDay = "";

            todaysDay = "Good";
            switch(todaysDay)
            {
                case "Great":
                    Console.WriteLine("Awesome");
                    break;
                case "Good":
                    Console.WriteLine("Not bad");
                    break;
                case "Okay":
                    Console.WriteLine("Could be worse");
                    break;
                case "Bad":
                    Console.WriteLine("That stinks");
                    break;
                default:
                    Console.WriteLine("Oh well");
                    break;
            }



            Console.ReadLine();

        }
    }
}
