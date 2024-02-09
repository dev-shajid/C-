using System;

namespace ErrorHandling{
    abstract class Shape{
        public double TotalDimension {get; set;}
        public abstract double CalculateArea();
        public abstract bool IsValid();
    }
}