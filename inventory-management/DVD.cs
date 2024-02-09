using System;

namespace Project{
    class DVD:Media<string>{
        private string director;
        public string Director{
            get=>director;
            set{
                if(value.Length!=0) director=value;
                else Console.WriteLine("Director's name cannot be empty!");
            }
        }
        public DVD(string title, int publish_year, string director, int id)
        :base(title, publish_year, id, "DVD") => this.director=director;
        public override void DisplayInfo(){
            base.DisplayInfo();
            Console.Write($"Director: {Director}\n");
        }
    }
}