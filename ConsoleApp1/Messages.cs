using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Messages
    {
        public static void WelcomeMessage()
        {
            Console.Write("Welcome to your schedule");
            Console.WriteLine("Please, enter the current date:");
        }

        public static void TypeMessage()
        {
            Console.Write("What type do you want, Recurring or Once?");
        }
        public static void DateMessage()
        {
            Console.Write("Please, write the date:");
        }

        public static void PeriodMessage(string timePeriod) 
        {
            Console.Write("Every: (type number of" + timePeriod +")");
        }


    }
}
