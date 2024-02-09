using System;

namespace Project{
    class Players{
        public int total_winner=0;
        public List<Player> players=new List<Player>();
        public Players(int total){
            for(int i=1; i<=total; i++){
                Player player = new Player(players.Count+1);
                players.Add(player);
            }
        }
        public void Supply_Cards(int n){
            for(int i=0; i<n; i++){
                foreach(var player in players){
                    player.cards.Add(Cards.Supply_Card());
                }
            }
        }
    }
}