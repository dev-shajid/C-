using System;
namespace GeometricWareHouse{
    class Circle:Shape{
        public static double pi = 3.1416;
        private double radius;
        public double Radius{
            get{ return this.radius; }
            set { this.radius = value; }
        }
        public Circle(){}
        public Circle(double radius){
            this.radius = radius;
        }
        public override double Area()=>pi*radius*radius;
        public override double Perimeter()=>2*pi*Radius;
    }
}