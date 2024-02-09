using System;
namespace RealEstateProject{
    class House:RealEstate{
        private double length, width;
        public double Length{
            get=>length;
            set=>length=value;
        }
        public double Width{
            get=>width;
            set=>width=value;
        }

        public House(){}
        public House(string location, int price, int yearBuilt, double length, double width, int totalBedRoom, int totalWindow)
        :base(location, price, yearBuilt, totalBedRoom, totalWindow){
            this.length=length;
            this.width=width;
        }

        public override void InfoDisplay(){
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Type:\t\tHouse");
            Console.WriteLine($"Price:\t\t{Price}");
            Console.WriteLine($"Location:\t{Location}");
            Console.WriteLine($"Built In:\t{YearBuilt}");
            Console.WriteLine($"Expensiveness:\t{Expensiveness()}");
            Console.WriteLine($"Total BedRoom:\t{TotalBedRoom}");
            Console.WriteLine($"Total Window:\t{TotalWindow}");
            Console.WriteLine($"Is Luxary?:\t{IsLuxary()}");
            Console.WriteLine("---------------------------------\n");
        }
        public double TotalSquareFeet()=>Length*Width;
        public double PricePerSqueareFeet()=>Price/TotalSquareFeet();
        public bool IsLuxary () => PricePerSqueareFeet()>=1000000 ? true : false;

    }
}