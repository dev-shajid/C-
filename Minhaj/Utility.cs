using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MediaManagement
{
    internal static class Utility
    {
        public static void printmassage(string msg,bool success =true)
        {
            if (success)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.White;
            }
            Console.WriteLine(msg);
            Console.ResetColor();
            presstocontinue();
        }
        public static string Getuserin(string message)
        {
            //string Box = message;
            //Console.WriteLine($"┌─────-───────┐\n│ {Box} │\n└─────-───────┘");
            Console.WriteLine(message);
            return Console.ReadLine();
        }
        public static void presstocontinue()
        {
            Console.WriteLine("Press any key to continue...");
            function_class.newl();
            Console.ReadKey();
            function_class.newl();
        }
    }
}
