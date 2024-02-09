using System;

namespace Project{
    class Player{
        private string name;
        private int age;
        private double rating;
        public string Name{
            get=>name;
            set=>name=value;
        }
        public int Age{
            get=>age;
            set=>age=value;
        }
        public double Rating{
            get=>rating;
            set=>rating=value;
        }
        public Player(string name, int age, double rating){
            this.name=name;
            this.age=age;
            this.rating=rating;
        }
    }
}