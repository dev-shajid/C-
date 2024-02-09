global using global::System;
global using global::System.Collections.Generic;
global using global::System.IO;
global using global::System.Linq;
global using global::System.Net.Http;
global using global::System.Threading;
global using global::System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using static System.Reflection.Metadata.BlobBuilder;
using System.Linq;
using System.Xml;
using System.ComponentModel.Design;

namespace MediaManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
           menu:
           Appscreen.Welcome();
            List<Media<string>> listmedia= new List<Media<string>>();// create a list of media name listmedia

           
            //Books book = new Books("Book 1", 1995, "200$", "minhaj");
            //listmedia.Add(book);
          
                listmedia.Add(new Books(1,"The dark knight rises", 1995, 2000, "Christopher nolan"));// these are previuosly created media
                listmedia.Add(new Books(2,"The End of humanity", 2010, 2340, "minhaj"));
                listmedia.Add(new CDs(3,"the lord of the rings", 2020, 3463, "Jahed"));
                listmedia.Add(new CDs(4,"A brief history of time", 2022, 0, "stephen hawkings"));
            listmedia.Add(new DVDs(5, "Inception", 2010, 148, "Christopher Nolan"));
            listmedia.Add(new DVDs(6, "The Lord of the Rings: The Fellowship of the Ring", 2001, 178, "Peter Jackson"));
            listmedia.Add(new DVDs(7, "The Lord of the Rings: The Two Towers", 2002, 179, "Peter Jackson"));
            listmedia.Add(new DVDs(8, "The Lord of the Rings: The Return of the King", 2003, 201, "Peter Jackson"));
            listmedia.Add(new DVDs(9, "The Dark Knight rises", 2008, 152, "Christopher Nolan"));
            listmedia.Add(new DVDs(10, "The untold history of pallestine", 2023, 152, "Minhaj Ali"));
            listmedia.Add(new DVDs(11, "free palestine", 2023, 152, "Minhaj Ali"));
            listmedia.Add(new CDs(12, "Gladiator", 2000, 155, "Ridley Scott"));
           listmedia.Add(new CDs(13, "The Matrix", 1999, 136, "Lana Wachowski"));
              listmedia.Add(new CDs(14, "The Matrix Reloaded", 2003, 138, "Lana Wachowski"));
            listmedia.Add(new CDs(15, "The Matrix Revolutions", 2003, 129, "Lana Wachowski"));
            listmedia.Add(new CDs(16, "Forrest Gump", 1994, 142, "Robert Zemeckis"));
            listmedia.Add(new Books(17, "Forrest Gump", 1994, 142, "Robert Zemeckis"));
            listmedia.Add(new Books(18, "The Matrix Revolutions", 2003, 129, "Lana Wachowski"));    
            listmedia.Add(new Books(19, "The Shawshank Redemption", 1994, 142, "Frank Darabont"));
            listmedia.Add(new Books(20, "Avatar", 2009, 162, "James Cameron"));
            
            // MediaLibrary mediaLibraryInstance = new MediaLibrary();
            // mediaLibraryInstance.Initializelist();

            int u = 19;//for adding next media list id will be incremented by 1

            function_class.firstlogin();//this is for first login log out sign in

            while (true)
            {
               Appscreen.printoptions();//all the printings are in appscreen class
                int y;
                //y = int.Parse(Console.ReadLine());
                y=Validator.Converter<int>("Enter your any option option"); // in validator method i have used try catch block so i dont need to use try catch block here

                if (y == 1)
                {
                    Console.WriteLine("-------------------------create new book----------------------------");
                    Console.WriteLine("====================================================================");
                    //Console.WriteLine("Enter book title:");
                    //string title = Console.ReadLine(); 
                    //Console.WriteLine("Enter book author:");
                    // string author = Console.ReadLine();
                    // Console.WriteLine("Enter book price:");
                    // string price = Console.ReadLine();
                    //Console.WriteLine("Enter book release year:");
                    //int releaseYear = int.Parse(Console.ReadLine());

                    // here i will use utility class getuserin method for removing redundancy problem

                    //string title = Utility.Getuserin("Enter book title:");                          
                    //string author = Utility.Getuserin("Enter book author:");
                    //int releaseYear = int.Parse(Utility.Getuserin("Enter book release year:"));
                    //string price = Utility.Getuserin("Enter book price:");

                    //now i will use validator class for removing redundancy problem of try catch block
                    //here validator class is static class so i can call it directly
                    //and i apply genaric for observe if try catch block is working or not

                    //here is the combination of utility and validator class for removing redundancy problem
                    u++;
                    string title = Validator.Converter<string>("Enter book title:");
                    string author = Validator.Converter<string>("Enter book author:");
                    int releaseYear;
                    bool ok = true;

                    /*try {
                        do
                        {
                            releaseYear = Validator.Converter<int>("Enter book release year from (1900 to 2023):");
                            if ((releaseYear < 1900) || (releaseYear > 2023))
                            {
                                Console.BackgroundColor = ConsoleColor.Red;
                                //throw new ArgumentException("release year can not be negative and must be 1900 to 2023");
                                throw new Exception("This is a custom exception.");
                                ok = false;

                            }


                        } while (!ok);
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine("invalid input");
                    }
                       */
                    //in this code i tried to creat custom exception but it is not working.as compiler thought that the realease year value might be un initialized if it gives argument exception
                    //the above code is not working properly so i will use this code


                    do
                    {
                        releaseYear = Validator.Converter<int>("Enter book release year from (1900 to 2023):");
                        if ((releaseYear < 1900) || (releaseYear > 2023))
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.WriteLine("release year can not be negative and must be 1900 to 2023");
                            ok = false;
                            Console.ResetColor();

                        }
                        else
                        {
                            ok = true;
                        }
                    } while (!ok);

                    int price = Validator.Converter<int>("Enter book price:");

                    u++;
                    Books book = new Books(u, title, releaseYear, price, author);
                    Console.WriteLine("Book created successfully! and added to media");

                    listmedia.Add(book);
                    Utility.presstocontinue();

                }
                else if (y == 2)
                {
                    Console.WriteLine("--------------------------------Enter new CDs----------------------------- ");
                    Console.WriteLine("=============================================================================");
                   
                    u++;
                    string title1 = Validator.Converter<string>("Enter CDs title:");
                    string artist = Validator.Converter<string>("Enter CD artist:");
                    int releaseYear;
                    bool ok = false;
                    do
                    {
                        releaseYear = Validator.Converter<int>("Enter book release year from (1900 to 2023):");
                        if ((releaseYear < 1900) || (releaseYear > 2023))
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.WriteLine("release year can not be negative and must be 1900 to 2023");
                            ok = false; Console.ResetColor();

                        }
                        else
                        {
                            ok = true;
                        }
                    } while (!ok);

                    int price = Validator.Converter<int>("Enter Cd price:");

                    CDs cd = new CDs(u, title1, releaseYear, price, artist);
                    Console.WriteLine("new Cd has been created successfully");
                    listmedia.Add(cd);
                    Utility.presstocontinue();
                }
                else if (y == 3)
                {
                    Console.WriteLine("--------------------------------Enter new DVDs----------------------------- ");
                    Console.WriteLine("=============================================================================");


                    u++;
                    string title1 = Validator.Converter<string>("Enter DVDs title:");
                    string director = Validator.Converter<string>("Enter DVD director:");
                    int releaseYear;
                    bool ok = false;
                    do
                    {
                        releaseYear = Validator.Converter<int>("Enter book release year from (1900 to 2023):");
                        if ((releaseYear < 1900) || (releaseYear > 2023))
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.WriteLine("release year can not be negative and must be 1900 to 2023");
                            ok = false;

                        }
                        else
                        {
                            ok = true;
                        }
                    } while (!ok);
                    int price = Validator.Converter<int>("Enter Cd price:");

                    CDs cd = new CDs(u, title1, releaseYear, price, director);
                    Console.WriteLine("new Cd has been created successfully");
                    listmedia.Add(cd);
                }
                else if (y == 4)
                {
                    Console.WriteLine("----------------------------remove media list by information--------------------------");
                    Console.WriteLine("======================================================================================");
                    function_class.newl();
                    Console.WriteLine("by which one you want to delete information");
                    function_class.newl();
                    Console.WriteLine("press 1 for title  ");
                    Console.WriteLine("press 2 for creator");
                    function_class.newl();

                    int x = Validator.Converter<int>("Enter your option");
                    if (x == 1)
                    {
                        // bool removed = RemoveMediaItem(mediaList, media => media.Title == "Book 1");

                        /*bool removed = RemoveMediaItem(listmedia, media => media.title == "Book 1");
                        if (removed)
                        {
                            Console.WriteLine("Media item removed successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Media item not found!");
                        }*/
                        Console.WriteLine("heres the list of title ");
                        function_class.newl();
                        int i = 1;
                        foreach (var item in listmedia)
                        {
                            Console.WriteLine(i + "::" + item.title);
                            i++;
                        }
                        Console.WriteLine("delete item by title");
                        
                        string title = Validator.Converter<string>("Enter title");
                        // function_class.Removetitle(title);

                        void Removetitle(string title)
                        {

                            int ok = listmedia.RemoveAll(b => b.title == title);
                            if (ok == 0)
                            {
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.WriteLine("not found");
                                Console.WriteLine("try again");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.WriteLine("found and removed");
                            }
                        }
                        Removetitle(title);
                    }
                    else if (x == 2)
                    {
                        function_class.newl();
                        string Box = "delete item by creeator";
                        Console.WriteLine($"Boxed:\n┌────────────┐\n│ {Box} │\n└────────────┘");
                        
                        function_class.newl();
                        //int p = int.Parse(Console.ReadLine());
                        Console.WriteLine("heres the list of creator");
                        function_class.newl();
                        foreach (var item in listmedia)
                        {
                            if (item is DVDs)
                            {
                                Console.WriteLine(" director :"+((DVDs)item).director);
                            }
                            else if (item is CDs)
                            {
                                Console.WriteLine(" artist "+((CDs)item).artist);
                            }
                            else if (item is Books)
                            {
                                Console.WriteLine(" auther "+((Books)item).auther);
                            }
                        }
                        function_class.newl();
                        function_class.newl();
                        Console.WriteLine("for which creator you want to delete \n1.director\n2.artist\n.auther");
                        int p = Validator.Converter<int>("Enter your option");
                        if (p == 1)
                        {
                            Console.WriteLine("Enter director name");
                            string director = Console.ReadLine();
                            void Removedvd(string director)
                            {
                                listmedia.RemoveAll(item => item is DVDs && ((DVDs)item).director == director);
                                if(listmedia.RemoveAll(item => item is DVDs && ((DVDs)item).director == director)==0)
                                {
                                    Console.BackgroundColor = ConsoleColor.Red;
                                    string Box = "Not found! tryagain";
                                    Console.WriteLine($"Boxed:\n┌────────────┐\n│ {Box} │\n└────────────┘");
                                   
                                    Console.ResetColor();
                                }
                                else
                                {
                                    Console.WriteLine("found and removed");
                                }
                            }

                            Removedvd(director);

                        }
                        else if (p == 2)
                        {
                            Console.WriteLine("Enter artist name");
                            //string artist = Console.ReadLine();
                            string artist = Validator.Converter<string>("Enter artist name");
                            void removedcd(string artist)
                            {
                                listmedia.RemoveAll(item => item is CDs && ((CDs)item).artist == artist);
                                if (listmedia.RemoveAll(item => item is CDs && ((CDs)item).artist == artist) == 0)
                                {
                                    Console.BackgroundColor = ConsoleColor.Red;
                                    string Box = "Not found! tryagain";
                                    Console.WriteLine($"Boxed:\n┌────────────┐\n│ {Box} │\n└────────────┘");
                                    Console.ResetColor();
                                }
                                else
                                {
                                    Console.WriteLine("found and removed");
                                }
                            }

                            removedcd(artist);

                        }//123456789
                        else if (p == 3)
                        {
                            Console.WriteLine("Enter auther name");
                            // string auther = Console.ReadLine();
                            string auther = Validator.Converter<string>("Enter auther name");
                            void Removebook(string auther)
                            {
                                listmedia.RemoveAll(m => m is Books && ((Books)m).auther == auther);
                                if (listmedia.RemoveAll(m => m is Books && ((Books)m).auther == auther) == 0)
                                {
                                    Console.BackgroundColor = ConsoleColor.Red;
                                    string Box = "Not found! tryagain";
                                    Console.WriteLine($"Boxed:\n┌────────────┐\n│ {Box} │\n└────────────┘");
                                    Console.ResetColor();
                                }
                                else
                                {
                                    Console.WriteLine("found and removed");
                                }
                            }

                            Removebook(auther);
                        }

                    }


                }

                else if (y == 5)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("--------------------------------update media list by information------------------------------");
                    Console.WriteLine("=============================================================================================");
                    Console.WriteLine("by which one you want to update information");
                    Console.WriteLine("enter option for 1.title ");
                    int x = int.Parse(Console.ReadLine());
                    if (x == 1)
                    {
                        string newtitle;
                        Console.WriteLine("heres the list of title ");
                        int i = 1;
                        foreach (var item in listmedia)
                        {
                            Console.WriteLine(item.id + "::   " + item.title);
                            
                            i++;
                        }
                        Console.WriteLine("update item by title");
                        function_class.newl();
                        //Console.WriteLine("Enter title");
                        string title = Validator.Converter<string>("Enter title");
                        if (listmedia.Any(d => d.title == title))
                        {
                            Console.WriteLine("found");
                            Console.WriteLine("Enter new title for replace");
                            newtitle = Validator.Converter<string>("Enter new title");
                            updatetitle(title, newtitle);

                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            string Box = "Not found! try again";
                            Console.WriteLine($"Boxed:\n┌─────-───────┐\n│ {Box} │\n└─────-───────┘");
                        }


                        void updatetitle(string title, string newstring)
                        {
                            var ok = listmedia.FirstOrDefault(d => d.title == title);
                            if (ok != null)
                            {
                                ok.title = newstring;//what the ....how is this possible
                                                     //listmedia.title= newstring;  //and how not this possible
                                string Box = "updated successfully";
                                Console.WriteLine($"Boxed:\n┌─────-───────┐\n│ {Box} │\n└─────-───────┘");
                            }
                        }
                      
                        Console.ResetColor();
                        function_class.newl();
                        //updatetitle(title,newtitle);
                        Console.ResetColor();
                    }
                }
                else if (y == 6)
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("sort the items by price ascendung order");
                    Console.WriteLine("=====================================================");
                    void SortByPrice()
                    {
                        //listmedia.Sort((a, b) => a.price.CompareTo(b.price));
                        //Orderbydescending is a linq method which is used for sorting the items in descending order.here i have used lambda expression.x is a parameter
                        int i = 1;
                        var sortedlist = listmedia.OrderByDescending(x => x.prise);
                        foreach (var item in sortedlist)
                        {
                            Console.WriteLine("\n|┌─────────-----------------------------───┐│");
                            Console.WriteLine($"{item.id}.{item.title} and prise is   :{item.prise}$");
                            
                            i++;
                        }

                    }
                    SortByPrice();
                    Console.ResetColor();
                }
                else if (y == 7)
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("-------------------------------------finding items/searching----------------------");
                    Console.WriteLine("==========================================================================");
                    void findmedia(string titl)
                    {
                        //firstordefault is a linq method which is used for finding the first item from the list.and it is used for searching.where titl is a parameter`
                        var media = listmedia.FirstOrDefault(t => t.title == titl);
                        if (media != null)
                        {
                            Console.WriteLine("found");
                            Console.WriteLine($"ID : {media.id}\nTitle : {media.title}");
                            Console.WriteLine($"prise :{media.prise}$");
                            Console.WriteLine($"REalease date :{media.releasedate}");
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            ConsoleColor.Red.ToString();
                            string Box = "Not found!";
                            Console.WriteLine($"Boxed:\n┌────────────┐\n│ {Box} │\n└────────────┘");

                        }
                    }
                    //Console.WriteLine("Enter title");
                    string title = Validator.Converter<string>("Enter title for finding");
                    findmedia(title);
                    Console.ResetColor();
                }
                else if (y == 8)
                {
                    function_class.newl();
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Green;
                    int i = 1;

                    //groupby is a method which is used for grouping the items
                    //groupby is a linq method
                    //(book => book.auther) is a lambda expression.where book is a parameter and book.auther is a property

                    Console.WriteLine("\n--------------------------------------grouping items----------------------------");
                    Console.WriteLine("=================================================================================");
                    var groupedbooksbyauther = listmedia.OfType<Books>().GroupBy(book => book.auther);
                    var groupedcdsbyartist = listmedia.OfType<CDs>().GroupBy(cd => cd.artist);
                    var groupeddvdsbydirector = listmedia.OfType<DVDs>().GroupBy(dvd => dvd.director);
                    Console.WriteLine("\ngrouping items by auther for books");
                    foreach (var item in groupedbooksbyauther)
                    {
                        Console.WriteLine($"\nAuther name:{item.Key}");
                        foreach (var item1 in item)
                        {
                            Console.WriteLine($"{item1.id}:{item1.title}---{item1.prise}$");
                            i++;
                        }
                    }
                    Console.WriteLine("\ngrouping items by artist for cds");
                    foreach (var item in groupedcdsbyartist)
                    {
                        Console.WriteLine($"\nartist name:{item.Key}");
                        foreach (var item1 in item)
                        {
                            Console.WriteLine($"{item1.id}:{item1.title}---{item1.prise}$");
                            i++;
                        }
                    }
                    Console.WriteLine("\ngrouping items by director for dvds");
                    foreach (var item in groupeddvdsbydirector)
                    {
                        Console.WriteLine($"\ndirector name:{item.Key}");
                        foreach (var item1 in item)
                        {
                            Console.WriteLine($"{item1.id}:{item1.title}---{item1.prise}$");
                            i++;
                        }
                    }
                    function_class.newl();
                    Console.ResetColor();
                    //failed attempted
                    //var groupedbooksbyauther = listmedia.OfType<Books>(Books => Books.auther);
                    //var groupedDVDs = dvds.GroupBy(dvd => dvd.Director);

                    // var groupedbooksbyauther = listmedia.GroupBy(item => item is Books && ((Books)item.auther);
                    //var groupedbooksbydirector = listmedia.GroupBy(listmedia.auther);
                    //(item => item is DVDs && ((DVDs)item).director == director)

                }
                else if (y == 9)
                {
                    double bookprise = 0, cdprise = 0, dvdprise = 0;
                    double totalprise = 0;
                    int bookcount = 0, cdcount = 0, dvdcount = 0;

                    foreach (var item in listmedia)
                    {
                        if (item is Books)
                        {
                            bookprise += (item.prise);
                            bookcount++;
                        }
                        else if (item is CDs)
                        {
                            cdprise += (item.prise);
                            cdcount++;
                        }
                        else if (item is DVDs)
                        {
                            dvdprise += (item.prise);
                            dvdcount++;
                        }
                    }
                    
                    Console.ResetColor();
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    function_class.newl();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("---------------------------------------statistics--------------------------");
                    Console.WriteLine("==============================================================================");
                    Console.WriteLine($"total book prise is {bookprise}");
                    Console.WriteLine($"total cd prise is {cdprise}");
                    Console.WriteLine($"total dvd prise is {dvdprise}");
                    totalprise = bookprise + cdprise + dvdprise;
                    Console.WriteLine($"total prise is {totalprise}");
                    Console.WriteLine($"total book count is {bookcount}");
                    Console.WriteLine($"total cd count is {cdcount}");
                    Console.WriteLine($"total dvd count is {dvdcount}");
                    Console.WriteLine($"total media count is {bookcount + cdcount + dvdcount}");
                    function_class.newl();
                    Console.WriteLine($"total media sell is :{function_class.buycount}");
                    Console.WriteLine($"total media sell prise :{function_class.totalsellprise}");
                    function_class.newl();
                }
             
                else if (y == 10)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("heres the list of media item ");
                    int i = 1;
                    foreach (var item in listmedia)
                    {
                        Console.WriteLine($"{i} :{item.title}   prise:: {item.prise}$");
                        Console.WriteLine();
                        i++;
                    }

                    function_class.logintobuy();
                    
                    

                    
                }

                else if (y == 12)
                {
                    Console.WriteLine("back to main menu");
                    Console.WriteLine("press any key to continue");
                    Console.ReadKey();
                    Console.Clear();
                    Console.ResetColor();
                    goto menu;
                }
                else if(y==11)
                {
                    Console.WriteLine("---------------------------------------------------filtering items--------------------------");
                    Console.WriteLine("============================================================================================");
                    Console.WriteLine("press 1 for filtering by year");
                    int p = Validator.Converter<int>("Enter your option");
                    if (p == 1)
                    {
                        Console.WriteLine("By which year you want to filter");
                        int year = Validator.Converter<int>("Enter year from which you want to filter");
                        Console.WriteLine("press 1 for books");
                        Console.WriteLine("press 2 for cds");
                            Console.WriteLine("press 3 for dvds");
                        int q = Validator.Converter<int>("Enter your option");
                        if(q== 1)
                        {
                           //ieunumerable is used for filtering.it is a interface and used in itteration
                           //ofType is used for access the specific type of data like here i want to access books type data
                           //to list is used for converting the data into list and getbyyear is a method which is in books class
                           
                            IEnumerable<Books> answerfilter = Books.getbyyear(listmedia.OfType<Books>().ToList(), year);
                            foreach (Books answer in answerfilter)
                            {
                                Console.WriteLine($"{answer.id} :{answer.title} prise:{answer.prise}");
                            }
                        }
                        else if (q == 2)
                        {
                            var filteredcds = CDs.getbyyear(listmedia.OfType<CDs>().ToList(), year);
                            foreach (var item in filteredcds)
                            {
                                Console.WriteLine($"{item.id} :{item.title}  prise :{item.prise}");
                            }
                        }
                        else if (q == 3)
                        {
                            var filtereddvds = DVDs.getbyyear(listmedia.OfType<DVDs>().ToList(), year);
                            foreach (var item in filtereddvds)
                            {
                                Console.WriteLine($"{item.id} :{item.title}  prise :{item.prise}");
                            }
                        }   
                    }
                }
                else if(y==13)
                {
                   Console.WriteLine("-----------------------------displaylist--------------------------");
                    Console.WriteLine("==================================================================");
                    int i = 1;
                    foreach (var item in listmedia)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.BackgroundColor = ConsoleColor.Black;
                            if (item is Books)
                            {
                               Console.WriteLine($" Books : id:{item.id}  title:{item.title}   prise:: {item.prise}");
                            }
                            else if (item is CDs)
                            {
                            Console.WriteLine($" CDs   : id:{item.id}  title:{item.title}   prise:: {item.prise}");
                        }
                            else if (item is DVDs)
                            {
                            Console.WriteLine($" Dvds  : id:{item.id}  title:{item.title}   prise:: {item.prise}");
                        }
                        
                    }
                    
                }
                else if (y == 14)
                {
                    Console.WriteLine("exit");
                    break;
                }
                else
                {
                    string Box = "invalid option try again";
                    Console.WriteLine($"Boxed:\n┌─────-───────┐\n│ {Box} │\n└─────-───────┘");
                    goto menu;
                }
            }
        }
    }
}
