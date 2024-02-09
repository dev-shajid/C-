using System;

namespace Project{
    class CD:Media<string>{
        private string artist;
        public string Artist{
            get=>artist;
            set{
                if(value.Length!=0) artist=value;
                else Console.WriteLine("Artist's name cannot be empty!");
            }
        }
        public CD(string title, int publish_year, string artist, int id)
        :base(title, publish_year, id, "CD") => this.artist=artist;
        public override void DisplayInfo(){
            base.DisplayInfo();
            Console.Write($"Artist: {Artist}\n");
        }
    }
}