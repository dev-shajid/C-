using System;

namespace Project
{
    class Team
    {
        private string name;
        private int index = 0;
        Player[] lists = new Player[100];
        public string Name
        {
            get => name;
            set => name = value;
        }
        public Team(string name)
        {
            this.name = name;
        }

        public void AddPlaer(Player player)
        {
            try
            {
                if(player.Name.Count()<3) throw new Exception("Player's name size should be atleast 3!");
                if(player.Age<18) throw new Exception("Player should be atleast 18 years old!");
                lists[index++] = player;
            }
            catch (Exception error)
            {
                Console.WriteLine($"Error: {error.Message}");
            }
        }
        public void AddPlaer(Player[] players)
        {
            try
            {
                foreach (Player player in players){
                    if(player.Name.Count()<3) throw new Exception("Player's name size should be atleast 3!");
                    if(player.Age<18) throw new Exception("Player should be atleast 18 years old!");
                    lists[index++] = player;
                }
            }
            catch (Exception error)
            {
                Console.WriteLine($"Error: {error.Message}");
            }
        }
        public double CalculateTeamRating()
        {
            double rating = 0;
            for(int i=0; i<index; i++) rating += lists[i].Rating;
            if (index > 0) rating = rating / index;
            return rating;
        }

        public static bool operator < (Team a, Team b) => a.CalculateTeamRating() < b.CalculateTeamRating();
        public static bool operator > (Team a, Team b) => a.CalculateTeamRating() > b.CalculateTeamRating();
    }
}