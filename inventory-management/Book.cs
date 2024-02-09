using System;

namespace Project{
    class Book:Media<string>{
        private string author;
        public string Author{
            get=>author;
            set{
                if(value.Length!=0) author=value;
                else Console.WriteLine("Author name cannot be empty!");
            }
        }
        public Book(string title, int publish_year, string author, int id)
        :base(title, publish_year, id, "Book")=>this.author=author;
        public override void DisplayInfo(){
            base.DisplayInfo();
            Console.Write($"Author: {this.author}\n");
        }
    }
}