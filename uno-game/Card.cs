using System;

namespace Project
{
    class Card
    {

        string name;
        public int number;
        public bool special = false;
        public Card(string c)
        {
            name=c;
            number=0;
        }
        public Card(string c, int i)
        {
            name=c;
            number=i;
            special=true;
        }
        public override string ToString()=>$"{this.name}";
    }
}