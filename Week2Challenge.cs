using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2challenge
{
    class Week2Challenge
    {
        static void Main(string[] args)
        {
            Greeter g = new Greeter();
            g.Hello("bob");
            g.Farewell("george");
            g.WhatTimeOfDay(TimeOfDay.Morning);
            Console.ReadLine();
        }
    }

    public enum TimeOfDay { Morning,Afternoon,Night};

    public class Greeter
    {

        public void Hello(string name)
        {
            Console.WriteLine("Hello {0} how are you!!", name);
        }

        public void Farewell(string message)
        {
            Console.WriteLine("Goodbye {0}.", message);
        }

        public void WhatTimeOfDay(TimeOfDay t)
        {
            switch(t)
            {
                case TimeOfDay.Morning:
                    Console.WriteLine("Good morning");
                    break;
                case TimeOfDay.Afternoon:
                    Console.WriteLine("Good Afternoon");
                    break;
                case TimeOfDay.Night:
                    Console.WriteLine("Good evening");
                    break;
                default:
                    Console.WriteLine("Its five o clock somewhere");
                    break;
            }
        }


    }
}
