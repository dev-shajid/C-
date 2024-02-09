using System;
using System.Collections.Generic;
using System.Linq;

namespace Project
{
    abstract partial class Media<T>
    {
        static List<Media<string>> mediaLists = new List<Media<string>>{
            new Book("Faith Of Light", 2005, "Shajid", 1),
            new Book("Warrior Of Wind", 2015, "Saimun", 2),
            new CD("Memory Of Hope", 2003, "Mahi", 3),
            new DVD("Python For DSA", 2005, "Shajid", 4),
            new Book("Journey to the Center of the Earth", 1864, "Sabbir", 5),
            new CD("Greatest Hits", 2000, "Yeaser", 6),
            new DVD("The Shawshank Redemption", 1994, "Ratul", 7),
            new Book("To Kill a Mockingbird", 1960, "Shajid", 8),
            new Book("The Lord of the Rings", 1954, "Sabbir", 9),
            new CD("Thriller", 1982, "Mahi", 10),
            new DVD("Inception", 2010, "Zarif", 11),
            new Book("Pride and Prejudice", 1813, "Yeaser", 12),
            new CD("Back in Black", 1980, "Saimun", 13),
            new DVD("The Godfather", 1972, "Shajid", 14),
            new Book("1984", 1949, "Ratul", 15),
            new Book("The Catcher in the Rye", 1951, "Shajid", 16),
            new CD("Rumors", 1977, "Sabbir", 17),
            new DVD("Schindler's List", 1993, "Mahi", 18),
            new Book("Brave New World", 1932, "Saimun", 19),
            new CD("Dark Side of the Moon", 1973, "Zarif", 20),
        };

        private string title;
        private string Type { get; }
        private int publish_year, id;
        public string Title
        {
            get => title;
            set
            {
                if (value.Length != 0) title = value;
                else Console.WriteLine("Title cannot be empty!");
            }
        }
        public int Publish_Year
        {
            get => publish_year;
            set => publish_year = value;
        }
        public int ID
        {
            // readonly
            get => id;
            private set { } 
        }
        public Media(string title, int publish_year, int id, string type)
        {
            this.title = title;
            this.publish_year = publish_year;
            this.id = id;
            this.Type = type;
        }
    }

    // Partial Class for Action handling
    partial class Media<T>
    {
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"\nType: {Type}");
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Publish Year: {publish_year}");
        }
        public static void AddItem(int choice)
        {
            string title = InputString("Title");
            int year = InputYearInt();
            int id = 1;
            if (mediaLists.Count != 0) id = mediaLists.Last().ID + 1;
            if (choice == 1) mediaLists.Add(new Book(title, year, InputString("Author's Name"), id));
            else if (choice == 2) mediaLists.Add(new CD(title, year, InputString("Artist's Name"), id));
            else if (choice == 3) mediaLists.Add(new DVD(title, year, InputString("Director's Name"), id));
            mediaLists.Last().DisplayInfo();
            Console.WriteLine("\nSuccessfully Added Item!");
        }
        public static void ShowItems()
        {
            // Sending List of choice & message
            int choice = InputDynamicMenu(new List<string>() { "All", "Book", "CD", "DVD" }, "Choose");
            List<Media<string>> items = mediaLists.Where(x =>
            {
                return
                choice == 2 ? x is Book :
                choice == 3 ? x is CD :
                choice == 4 ? x is DVD :
                true;
            }).ToList();
            ShowListItems(items, true);
        }
        public static void ShowItemsByGrouping()
        {
            var items = mediaLists.GroupBy(x => x.Type);
            // Sending List of choice & message
            int choice = InputDynamicMenu(new List<string>() { "Item Type", "Author/Artist/Director" }, "Group By:");
            if(choice==2){
                items=mediaLists.GroupBy(x=>{
                    if(x is Book b) return b.Author;
                    else if(x is CD c) return c.Artist;
                    else if(x is DVD d) return d.Director;
                    return x.Type;
                }).ToList();
            }
            if(items.Count()==0){
                Console.WriteLine("No Item is found");
                return;
            }
            Console.WriteLine("\n***********************");
            foreach (var item in items)
            {
                Console.WriteLine($"{item.Key}: {item.Count()} items");
                Console.WriteLine("---------------------");
                foreach (var media in item)
                {
                    if (media is Book b) b.DisplayInfo();
                    else if (media is CD c) c.DisplayInfo();
                    else if (media is DVD d) d.DisplayInfo();
                }
                Console.WriteLine("---------------------");

            }
            Console.WriteLine("***********************");
        }
        public static void ShowListItems(List<Media<string>> items, bool sort = false)
        {
            if (items.Count == 0)
            {
                Console.WriteLine("No Items is Found!");
                return;
            }

            // Sorting functionality
            bool wantSorted = sort && InputBoolean("Want to sort");
            if (wantSorted)
            {
                int n = InputCriterion(4); // choose field to be sorted
                int orderBy = InputOrderBy(); // 1 for asc & 2 for des

                if (n == 1 && orderBy == 1) items = items.OrderBy(x => x.ID).ToList();
                else if (n == 2 && orderBy == 1) items = items.OrderBy(x => x.Title).ToList();
                else if (n == 3 && orderBy == 1) items = items.OrderBy(x =>
                {
                    return
                    x is Book b ? b.Author :
                    x is CD c ? c.Artist :
                    x is DVD d ? d.Director :
                    null;
                }).ToList();
                else if (n == 4 && orderBy == 1) items = items.OrderBy(x => x.Publish_Year).ToList();
                else if (n == 1 && orderBy == 2) items = items.OrderByDescending(x => x.ID).ToList();
                else if (n == 2 && orderBy == 2) items = items.OrderByDescending(x => x.Title).ToList();
                else if (n == 3 && orderBy == 2) items = items.OrderByDescending(x =>
                {
                    return
                    x is Book b ? b.Author :
                    x is CD c ? c.Artist :
                    x is DVD d ? d.Director :
                    null;
                }).ToList();
                else if (n == 4 && orderBy == 2) items = items.OrderByDescending(x => x.Publish_Year).ToList();
            }


            Console.WriteLine("---------------------");
            foreach (Media<string> item in items)
            {
                if (item is Book b) b.DisplayInfo();
                else if (item is CD c) c.DisplayInfo();
                else if (item is DVD d) d.DisplayInfo();
            }
            Console.WriteLine();
            Console.WriteLine("---------------------");
            Console.WriteLine($"Total Items: {items.Count}");
        }
        public static void DeleteItem()
        {
            Console.WriteLine();
            int choice = InputCriterion();
            if (choice == 1)
            {
                int index = InputIDForItem();
                if (index == -1) return;
                mediaLists.RemoveAt(index);
            }
            else if (choice == 2)
            {
                string title = InputString("Title");
                var items = mediaLists.Where(x => x.Title.Contains(title)).ToList();
                if (items.Any())
                {
                    ShowListItems(items);
                    string all = "";
                    if (mediaLists.Count > 1) all = " all";
                    if (InputBoolean($"{items.Count} items is found, do you want to delete{all}"))
                    {
                        mediaLists.RemoveAll(x => x.Title.Contains(title));
                    }
                    else
                    {
                        Console.WriteLine("Ok!");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("No items is found!");
                    return;
                }
            }
            else if (choice == 3)
            {
                string value = InputString("Author/Artist/Director");
                var items = mediaLists.Where(x =>
                    {
                        if (x is Book b) return b.Author == value;
                        else if (x is CD c) return c.Artist == value;
                        else if (x is DVD d) return d.Director == value;
                        else return false;
                    }).ToList();
                if (items.Any())
                {
                    ShowListItems(items);
                    string all = "";
                    if (mediaLists.Count > 1) all = " all";
                    if (InputBoolean($"{items.Count} items is found, do you want to delete{all}"))
                    {
                        mediaLists.RemoveAll(x =>
                        {
                            if (x is Book b) return b.Author == value;
                            else if (x is CD c) return c.Artist == value;
                            else if (x is DVD d) return d.Director == value;
                            else return false;
                        });
                    }
                    else
                    {
                        Console.WriteLine("Ok!");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("No items is found!");
                    return;
                }
            }
            else return;

            Console.WriteLine();
            ShowListItems(mediaLists);
            Console.WriteLine("\nSuccessfully Deleted Item!");
        }
        public static void SearchItem()
        {
        Again:
            Console.WriteLine();
            int choice = InputCriterion(4);
            if (choice == 1)
            {
                int index = InputIDForItem();
                if (index == -1) return;
                Console.WriteLine();
                mediaLists[index].DisplayInfo();
                Console.WriteLine();
                return;
            }
            else if (choice == 2) ShowListItems(SearchItemByTitle());
            else if (choice == 3)
            {
                string value = InputString("Author/Artist/Director");
                var items = mediaLists.Where(x =>
                    {
                        return
                            x is Book b ? b.Author == value :
                            x is CD c ? c.Artist == value :
                            x is DVD d ? d.Director == value :
                            false;
                    }
                ).ToList();
                ShowListItems(items);
            }
            else if (choice == 4) ShowListItems(SearchItemByPublishYear());
            else goto Again;
        }

        public static void UpdateItem()
        {
            Console.WriteLine();

            int index = InputIDForItem();
            if (index == -1) return;

            if (InputBoolean("Want to Update Title"))
            {
                string title = InputString("New Title");
                mediaLists[index].Title = title;
            }
            if (InputBoolean("Want to Update Publish Year"))
            {
                int publish_year = InputYearInt("New Publish Year");
                mediaLists[index].Publish_Year = publish_year;
            }
            if (mediaLists[index] is Book book && InputBoolean("Want to Update Author"))
            {
                string author = InputString("New Author");
                book.Author = author;
            }
            else if (mediaLists[index] is CD cd && InputBoolean("Want to Update Artist"))
            {
                string artist = InputString("New Artist");
                cd.Artist = artist;
            }
            else if (mediaLists[index] is DVD dvd && InputBoolean("Want to Update Director"))
            {
                string director = InputString("New Director");
                dvd.Director = director;
            }

            Console.WriteLine();
            mediaLists[index].DisplayInfo();
            Console.WriteLine("\nSuccessfully Updated Item!");
        }

    }


    // Partial Class for Taking Input with error handling
    abstract partial class Media<T>
    {
        public static string InputString(string message)
        {
        Again:
            string name;
            try
            {
                Console.WriteLine($"Insert the {message}:");
                name = Console.ReadLine();
                if (name!.Length < 2) throw new Exception("Should have atleast 3 characters");
            }
            catch (Exception err)
            {
                Console.WriteLine($"Error: {err.Message}");
                goto Again;
            }
            return name!;
        }
        public static int InputYearInt(string message = "Publish Year")
        {
        Again:
            int publish_year;
            try
            {
                Console.WriteLine($"Insert the {message}:");
                publish_year = Convert.ToInt32(Console.ReadLine());
                if (publish_year < 1000) throw new Exception("Cannot be less 1000");
                if (publish_year > DateTime.Now.Year) throw new Exception("Cannot be greater then current year!");
            }
            catch (Exception err)
            {
                System.Console.WriteLine($"Error: {err.Message}");
                goto Again;
            }
            return publish_year;
        }
        public static int InputIDForItem(string message = "ID")
        {
            // Again:
            int value = -1, index = -1;
            try
            {
                Console.WriteLine($"Insert the {message}:");
                value = Convert.ToInt32(Console.ReadLine());
                index = mediaLists.FindIndex(x => x.ID == value);
                if (index == -1) throw new Exception("Do not exist!");
            }
            catch (Exception err)
            {
                Console.WriteLine($"Error: {err.Message}\n");
                return -1;
                // goto Again;
            }
            return index;
        }
        public static bool InputBoolean(string message = "")
        {
        Again:
            int value = 0;
            try
            {
                Console.WriteLine($"{message}? (1/0)");
                value = Convert.ToInt32(Console.ReadLine());
                if (value != 1 && value != 0) throw new Exception("Insert Only 1 or 0");
            }
            catch (Exception err)
            {
                System.Console.WriteLine($"Error: {err.Message}");
                goto Again;
            }
            return value == 1 ? true : false;
        }
        public static int InputCriterion(int item = 3)
        {
            int value;
            try
            {
                Console.WriteLine("Based On:");
                Console.WriteLine("1. ID");
                Console.WriteLine("2. Title");
                Console.WriteLine("3. Author/Artist/Director");
                if (item == 4) Console.WriteLine("4. Publish Year");

                value = Convert.ToInt32(Console.ReadLine());
                if (value < 1 || value > item) throw new Exception("Invalid Input!");
            }
            catch (Exception err)
            {
                Console.WriteLine($"Error: {err.Message}\n");
                return 0;
            }
            return value;
        }
        public static int InputOrderBy()
        {
            int orderBy;
        Again:
            try
            {
                Console.WriteLine();
                Console.WriteLine("Order by:");
                Console.WriteLine("1. Ascending");
                Console.WriteLine("2. Descending");
                orderBy = Convert.ToInt32(Console.ReadLine());
                if (orderBy != 1 && orderBy != 2) throw new Exception("Invalid Choice!");
            }
            catch (Exception err)
            {
                Console.WriteLine($"Error: {err.Message}");
                goto Again;
            }
            return orderBy;
        }
        public static List<Media<string>> SearchItemByTitle()
        {
            string title = InputString("Title");
            return mediaLists.Where(x => x.Title.Contains(title)).ToList();
        }
        public static List<Media<string>> SearchItemByPublishYear()
        {
            int year = InputYearInt("Publish Year");
            return mediaLists.Where(x => x.Publish_Year == year).ToList();
        }
        public static int InputDynamicMenu(List<string> groupList, string message)
        {
            int choice;
        Again:
            try
            {
                int index = 1;
                Console.WriteLine();
                Console.WriteLine($"{message}");
                foreach (var item in groupList)
                {
                    Console.WriteLine($"{index++}. {item}");
                }
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice < 1 || groupList.Count < choice) throw new Exception("Invalid Choice!");
                else if (groupList[choice - 1] == "Cancel")
                {
                    Console.WriteLine("OK!");
                    return -1;
                }
            }
            catch (Exception err)
            {
                Console.WriteLine($"Error: {err.Message}");
                goto Again;
            }
            return choice;
        }





    }
}
