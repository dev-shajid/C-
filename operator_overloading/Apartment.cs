using System;

namespace OperatorOverloading{
    class Apartment{
        private string name;
        private int price;
        public string Name{
            get=>name;
            set=>name=value;
        }
        public int Price{
            get=>price;
            set=>price=value;
        }
        public Apartment(string name, int price){
            this.name=name;
            this.price=price;
        }
        public static Apartment operator +(Apartment a, Apartment b)=>new Apartment(a.name+" "+b.name, a.price+b.price);
    }
}