using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MediaManagement
{
    internal static class function_class
    {
        
        public static void newl() => Console.WriteLine();
        
        public static void createaccount(List<Cardholder> cardholders)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("creating account");
            //Console.WriteLine("enter your name");
            string firstname = Validator.Converter<string>("enter your firstname");
            string lastname = Validator.Converter<string>("enter your lastname");
            string cardnumber;
            //Console.ResetColor();
            //var check = cardholders.Any(a => a.Cardnum == cardnumber);
            do
            {
                cardnumber = Validator.Converter<string>("enter your card number");
                //while (cardholders.Any(a=>a.Cardnum == cardnumber) )
                if (cardholders.Any(a => a.Cardnum == cardnumber))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{firstname} {cardnumber}");
                    newl();
                    Console.WriteLine("card number already exist,pls try again with unique cardnumber");
                    Console.ResetColor();
                    //goto repeat;

                }
            }while(cardholders.Any(a => a.Cardnum == cardnumber));
            
            newl();
            Console.WriteLine("this card number is unique");newl();
            int userpin = Validator.Converter<int>("enter your pin");
            int balance = Validator.Converter<int>("enter your balance");
            cardholders.Add(new Cardholder(cardnumber, userpin, firstname, lastname,balance));
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("account created successfully");




            Console.WriteLine($"{firstname} {lastname} {cardnumber} {userpin}");
            Console.ResetColor();
        }

        public static void login(List<Cardholder> cardholders)
        {
            repeat:
            Console.WriteLine("login");
            string cardnumber = Validator.Converter<string>("enter your card number");

            newl();

            int userpin = Validator.Converter<int>("enter your pin");
            var cardholder = cardholders.FirstOrDefault(a=>a.Cardnum == cardnumber && a.Pin == userpin);
            if(cardholder == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                string Box = "invalid card number or pin";
                Console.WriteLine($"Boxed:\n┌─────-───────┐\n│ {Box} │\n└─────-───────┘");
                Console.ResetColor();
                goto repeat;
                //return;
            }
            else if(cardholder != null)
            {
                var holder = cardholders.FirstOrDefault(a => a.Cardnum == cardnumber);
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("login successfully");
                Console.WriteLine($"welcome to media management system  {holder.Firsname} {holder.Lastname}");
                Console.ResetColor();
            }
            
        }

        /*public static void logintobuy(List<Cardholder> cardholder)
        { Console.WriteLine("enter your pin number buy");
                   string cardnumber = Validator.Converter<string>("enter your card number");
        
                   newl();
        
                   int userpin = Validator.Converter<int>("enter your pin");
                   var cardhold = cardholder.Any(a => a.Cardnum == cardnumber && a.Pin == userpin);
                   if (cardhold == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("invalid card number or pin");
                Console.ResetColor();
                //goto repeat;
                //return;
            }
            else if (cardhold != null)
            {
                var holder = cardholder.FirstOrDefault(a => a.Cardnum == cardnumber);
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("login successfully");
                Console.WriteLine($"welcome to media management system  {holder.Firsname} {holder.Lastname}");
                Console.ResetColor();
            }
        }*/

       public static int buycount = 0;
      public  static  double totalsellprise = 0;
        public static void logintobuy()
        {
            List<Cardholder> cardholders = new List<Cardholder>
            {
                new Cardholder("123456789", 1234, "Minhaj", "Ali",2000000),
                new Cardholder("987654321", 4321, "Monjurul", "Hasan", 2000000),
                // Add more cardholders here
            };
            static void buy(List<Cardholder> cardholders)
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("---------------------------------------bye media item--------------------------");
                Console.WriteLine("================================================================================");


            previous:
                int userpin = Validator.Converter<int>("enter your pin");
                //var cardholder = cardholders.Any(a => a.Cardnum == cardnumber && a.Pin == userpin);
                var cardholder = cardholders.FirstOrDefault(a => a.Pin == userpin);
                
                if (cardholder == null)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("invalid card number or pin");
                    Console.ResetColor();
                    goto previous;
                    //return;
                }
                else if (cardholder != null)
                {
                    
                    var holder = cardholders.FirstOrDefault(a => a.Pin == userpin);
                   
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    string Box = "you can buy now";
                    Console.WriteLine($"Boxed:\n┌────────────┐\n│ {Box} │\n└────────────┘");

                    Console.WriteLine($"welcome to media management system  {holder.Firsname} {holder.Lastname}  Ballance:{holder.Balance}$");
                    //Console.ResetColor();
                    int id = Validator.Converter<int>("Enter  the id which you want to buy");
                    //var media = list.FirstOrDefault(a => a.Id == id);
                    //var media = listmedia.FirstOrDefault(a => a.Id == id);
                    MediaLibrary mediaLibraryInstance = new MediaLibrary();
                    mediaLibraryInstance.Initializelist();
                    var media = mediaLibraryInstance.listmedia.FirstOrDefault(a => a.id == id);
                    if(holder.Balance>=media.prise)
                    {
                        
                        Console.WriteLine($"Boxed:\n┌───────────-------------------------------------------─┐\n│");
                        Console.WriteLine($"you have parched {media.title} for {media.prise}$");
                        holder.Balance = holder.Balance - media.prise;
                        totalsellprise = totalsellprise + media.prise;
                        Console.WriteLine($"your current balance is    :{holder.Balance}$");
                        Console.WriteLine($"     └──--------------------------------------------------──────────┘");
                        buycount++;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.BackgroundColor = ConsoleColor.White;
                        string boxtext = "You dont have enough ballence";
                        Console.WriteLine($"Boxed:\n┌─────────-----------------------------───┐\n│ {boxtext} │\n└──────------------------------------------──────┘");
                    }
                  
                }
             }
            buy(cardholders);

        }

        public static void firstlogin()
        {
            
            loginmedia:
            newl();
            newl();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("In order to get access to the Media management system you have to login first");
            Console.WriteLine("chose an option ");
            newl();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("i tried to implement important concept of oop that is login by pin or password however after trying many times i still did not figuire out why after creating account it is notfound");
            Console.WriteLine("so i have to use card number and pin which i have created manually by list initializer and it is working");
            Console.WriteLine("for Monjurul sir cardnumber is 987654321 and pin 4321    ");
            newl();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("┌─────────------------------------------------───┐");
            Console.WriteLine("1.Already has account.log in");
            Console.WriteLine("2.Dont have account.sign up");
            Console.WriteLine("3.log out");
            Console.WriteLine("└──────------------------------------------──────┘");
            newl();
            newl();
           
            int option = Validator.Converter<int>("enter your option");
            List<Cardholder> cardholders = new List<Cardholder>
            {
                new Cardholder("123456789", 1234, "Minhaj", "Ali",2000000),
                new Cardholder("987654321", 4321, "Monjurul", "Hasan", 2000000),
                // Add more cardholders here
            };

            if (option == 1)
            { 
                login(cardholders);

                newl();
                Console.WriteLine("log in successfully you can access the media management system");
               
            }
            else if(option == 2)
            {
                Console.WriteLine("sign up");
                createaccount(cardholders);
                newl();
                Console.WriteLine("log in successfully you can access the media management system");

            }
            else if(option == 3)
            {
                Console.WriteLine("log out");
                goto loginmedia;

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;

                string Box = "invalid option try again";
                Console.WriteLine($"Boxed:\n┌─────-───────┐\n│ {Box} │\n└─────-───────┘");
                goto loginmedia;

            }
            Console.ResetColor();

        }

    }

}
