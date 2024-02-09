using System;

namespace GeometricWareHouse{
    class Rectangle:Shape{
        private double height, width;
        public double Height{
            get{ return this.height; }
            set { this.height = value; }
        }
        public double Width{
            get{ return this.height; }
            set { this.height = value; }
        }

        public Rectangle(){}
        public Rectangle(double height, double width){
            this.height = height;
            this.width = width;
        }
        public override double Area()=>this.height*this.width;
        public override double Perimeter()=>2*(Height+Width);
    }
}