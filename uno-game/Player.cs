using System;

namespace Project{
    class Player{
        public int player_id, winner=0;
        public List<Card> cards=new List<Card>();
        public Player(int id){
            player_id = id;
        }
        public void Display(){
            Console.WriteLine();
            Console.WriteLine("Player "+player_id+" has the following cards:");
            for(int i=0; i<cards.Count; i++) Console.WriteLine($"{i+1}. {cards[i]}");
            Console.WriteLine();
        }
        public override string ToString()
        {
            Display();
            return "";
        }
        public void TakeCard(){
            cards.Add(Cards.Supply_Card());
        }
        public void Play(){
            Display();

            Again:
            int choose=Convert.ToInt32(Console.ReadLine());
            if(choose>cards.Count+1){
                System.Console.WriteLine("Invalid Input!");
                goto Again;
            }
            // TODO: Start here!
        }
    }
}