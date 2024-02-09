using System;

namespace Project{
    class Program{
        static void Main(){
            try{
                Player b1=new Player("Shakib", 30, 6.7);
                Player b2=new Player("Tamim", 25, 4.3);
                Player b3=new Player("Mushfiq", 24, 8.4);
                Player b4=new Player("Miraz", 26, 5.5);
                Player b5=new Player("Taskin", 33, 6);

                Player p1=new Player("Babar", 21, 8);
                Player p2=new Player("Rizwan", 24, 8.3);
                Player p3=new Player("Faqqar", 30, 6.4);
                Player p4=new Player("Imam", 37, 4.3);
                Player p5=new Player("Rashid", 21, 5);

                Team bangladesh = new Team("Bangladesh");
                Player[] bd=new Player[] {b3,b4,b5};
                // single player adding in team
                bangladesh.AddPlaer(b1);
                bangladesh.AddPlaer(b2);
                // adding player list in team
                bangladesh.AddPlaer(bd);

                Team pakistan = new Team("Pakistan");
                Player[] pk=new Player[] {p3,p4,p5};
                // single player adding in team
                pakistan.AddPlaer(p1);
                pakistan.AddPlaer(p2);
                // adding player list in team
                pakistan.AddPlaer(pk);

                if(bangladesh < pakistan){
                    Console.WriteLine("Bangladesh has better rating!");
                }
                if(bangladesh>pakistan){
                    Console.WriteLine("Pakistan has better rating!");
                }
            }catch(Exception error){
                Console.WriteLine($"Error: {error}");
            }

        }
    }
}