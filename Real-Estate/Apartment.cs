using System;

namespace RealEstateProject{
    class Apartment:RealEstate{
        private double monthlyRent;
        private bool garden=false, swimingPool=false;
        public double MonthlyRent{
            get=>monthlyRent;
            set=>monthlyRent=value;
        }
        public bool Garden{
            get=>garden;
            set=>garden=value;
        }
        public bool SwimingPool{
            get=>swimingPool;
            set=>swimingPool=value;
        }

        public Apartment(){}
        public Apartment(string location, int price, int yearBuilt, int monthlyRent, bool garden, bool swimingPool, int totalBedRoom, int totalWindow)
        :base(location, price, yearBuilt, totalBedRoom, totalWindow){
            this.monthlyRent=monthlyRent;
            this.garden=garden;
            this.swimingPool=swimingPool;
        }

        public override void InfoDisplay(){
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Type:\t\tAppartment");
            Console.WriteLine($"Price:\t\t{Price}");
            Console.WriteLine($"Location:\t{Location}");
            Console.WriteLine($"Built In:\t{YearBuilt}");
            Console.WriteLine($"Expensiveness:\t{Expensiveness()}");
            Console.WriteLine($"Total BedRoom:\t{TotalBedRoom}");
            Console.WriteLine($"Total Window:\t{TotalWindow}");
            Console.WriteLine($"Is Luxary?:\t{IsLuxary()}");
            Console.WriteLine("---------------------------------\n");
        }
        public double AnnualIncome()=>MonthlyRent*12;
        public bool IsLuxary () => Garden || SwimingPool;

    }
}