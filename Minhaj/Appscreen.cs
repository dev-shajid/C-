using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MediaManagement
{
    public static class Appscreen
    {
        public static void Welcome()
        {
            Console.Clear();
            //Console.WriteLine("Welcome to media management!");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("");
            Console.WriteLine("||----------------------------------welcome to media management system----------------------------------||");
            function_class.newl();
            Console.WriteLine("||----------------------------------pls follow the instruction before giving input---------------------------||");         
            Console.WriteLine("================================================================================================================");


            function_class.newl();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("you can enter string as invalid input to watch red color line i have used for try catch block");
            Console.Title = "Media Management";//sets title
            
            Console.ResetColor();

           
        }
        public static void printoptions()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.BackgroundColor = ConsoleColor.White;
            function_class.newl();
            Console.WriteLine("||----------------------------------###############################---------------------------||");
            Console.WriteLine("Enter any option\n");
            //Console.WriteLine("1.Enter for books\n 2.Enter for CD \n3.Enter for DVD \n4. back\n4. exit");
            Console.WriteLine("1. Enter for books");
            Console.WriteLine("2. Enter for CD");
            Console.WriteLine("3. Enter for DVD");
            Console.WriteLine("4. Enter for remove media items");
            Console.WriteLine("5. Enter for updating media items");
            Console.WriteLine("6. sort the items by price");
            Console.WriteLine("7. finding items");
            Console.WriteLine("8. grouping items");
            Console.WriteLine("9. statistics");
            Console.WriteLine("10. buy media item");
            Console.WriteLine("11. filtering item ");
            Console.WriteLine("12.back to main menu");
            Console.WriteLine("13. displaydetails");
            Console.WriteLine("14.exit");
            function_class.newl();
            Console.WriteLine("||----------------------------------###############################---------------------------||");
        }
    }
}
