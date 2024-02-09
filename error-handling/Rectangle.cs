using System;

namespace ErrorHandling{
    class Rectangle:Shape{
        public double Height {get; set;}
        public double Width {get; set;}
        public double Ang1 {get; set;}
        public double Ang2 {get; set;}
        public double Ang3 {get; set;}
        public double Ang4 {get; set;}
        public Rectangle(){}
        public Rectangle(double height, double width, double a1, double a2, double a3, double a4){
            Height = height;
            Width = width;
            Ang1=a1;
            Ang2=a2;
            Ang3=a3;
            Ang4=a4;
        }
        public override double CalculateArea()=>Height*Width;
        public override bool IsValid()=>Height>=0 && Width>=0 && Ang1+Ang2+Ang3+Ang4==360;
    }
}