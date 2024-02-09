using System;

namespace Project{
    class GAME{
        static void Main(){
            Console.Clear();
            Cards.Generate_Cards();
            
            Players players=new Players(5);
            players.Supply_Cards(7);

            System.Console.WriteLine(players.players[0]);
        }
    }
}