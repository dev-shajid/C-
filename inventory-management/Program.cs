using System;

namespace Project
{
    class Program
    {
        public static void AddItem()
        {
            int choice = Menu2();
            if (choice == -1) return;
            Media<string>.AddItem(choice);
        }
        public static int Menu1()
        {
            List<string> choiceList=new List<string>(){
                "Add Item",
                "Update Item",
                "Delete Item",
                "Search Item",
                "Show Items",
                "Show Items By Grouping",
                "Exit",
            };
            return Media<string>.InputDynamicMenu(choiceList, "Choice");
        }
        public static int Menu2()
        {
            List<string> choiceList=new List<string>(){
                "Book",
                "CD",
                "DVD",
                "Cancel",
            };
            return Media<string>.InputDynamicMenu(choiceList, "Choice");
        }

        static void Main(string[] args)
        {
            Console.Clear();
            while (true)
            {
                int choice = Menu1();
                if (choice == 1) AddItem();
                else if (choice == 2) Media<string>.UpdateItem(); // Update Item By ID
                else if (choice == 3) Media<string>.DeleteItem(); // Delete Item By ID, Title or Name
                else if (choice == 4) Media<string>.SearchItem(); // Search
                else if (choice == 5) Media<string>.ShowItems(); // Show Lists
                else if (choice == 6) Media<string>.ShowItemsByGrouping(); // Show Lists by Grouping(name & item)
                else if (choice == 7) break;
                else Console.WriteLine("Invalid Input!");
            }
        }
    }
}