using System;

namespace GeometricWareHouse{
    class Cube:Shape{
        private double height;
        public double Height{
            get{ return this.height; }
            set { this.height = value; }
        }
        public Cube(){}
        public Cube(double height)=>Height = height;
    
        public override double Area()=>6*Height*Height;        
        public override double Perimeter()=> 24*Height;
        public double Diagonal()=>Math.Sqrt(3)*Height;
    }
}