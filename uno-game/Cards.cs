using System;

namespace Project
{
    static class Cards
    {
        public static List<Card> cards = new List<Card>();
        static List<string> colors = new List<string> { "Red", "Green", "Blue", "Yellow" };
        public static void Generate_Cards()
        {
            foreach (string color in colors)
            {
                for (int i = 0; i <= 9; i++) cards.Add(new Card($"{color} {i}"));
            }
            foreach (string color in colors)
            {
                for (int i = 0; i <4; i++) cards.Add(new Card($"+2", 2));
            }
            foreach (string color in colors)
            {
                for (int i = 0; i <4; i++) cards.Add(new Card($"+4", 4));
            }

            Shuffle_Cards();
        }

        static void Shuffle_Cards()
        {
            Random rnd = new Random();
            int n = cards.Count;
            while (n > 1)
            {
                int k = rnd.Next(n--);
                Card temp = cards[k];
                cards[k] = cards[n];
                cards[n] = temp;
            }
        }

        public static void Display(){
            foreach(var card in cards) Console.WriteLine(card);
        }

        public static Card Supply_Card(){
            if(cards.Count==0) return null;
            Card card=cards[0];
            cards.RemoveAt(0);
            return card;
        }
        
    }
}