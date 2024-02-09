using System;

namespace GeometricWareHouse{
    class Triangle:Shape{
        private double side_a, side_b, side_c;
        public double Side_A{
            get{ return this.side_a; }
            set { this.side_a = value; }
        }
        public double Side_B{
            get{ return this.side_b; }
            set { this.side_b = value; }
        }
        public double Side_C{
            get{ return this.side_c; }
            set { this.side_c = value; }
        }

        public Triangle(){}
        public Triangle(double side_a, double side_b, double side_c){
            Side_A=side_a;
            Side_B=side_b;
            Side_C=side_c;
        }
        public override double Area(){
            double s=Perimeter()/2;
            return Math.Sqrt(s*(s-side_a)*(s-side_b)*(s-side_c));
        }
        public override double Perimeter()=> Side_A + Side_B + Side_C;
    }
}