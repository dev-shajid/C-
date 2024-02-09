using System;

namespace OperatorOverloading{
    class Program{
        static void Main(){
            Console.Clear();
            Apartment a1=new Apartment("Vila1", 500000);
            Apartment a2=new Apartment("Vila2", 800000);
            Apartment a3=a1+a2;
            Console.WriteLine($"Name: {a3.Name}");
            Console.WriteLine($"Total Price: {a3.Price}");
        }
    }
}