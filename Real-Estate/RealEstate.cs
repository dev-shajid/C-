using System;

namespace RealEstateProject{
    class RealEstate{
        private string location;
        private int type, yearBuilt, price, totalBedRoom, totalWindow;
        public int Type{
            get=>this.type;
            set=>this.type=value;
        }
        public string Location{
            get=>this.location;
            set=>this.location=value;
        }
        public int Price{
            get=>this.price;
            set=>this.price=value;
        }
        public int YearBuilt{
            get=>this.yearBuilt;
            set=>this.yearBuilt=value;
        }
        public int TotalBedRoom{
            get=>this.totalBedRoom;
            set=>this.totalBedRoom=value;
        }
        public int TotalWindow{
            get=>this.totalWindow;
            set=>this.totalWindow=value;
        }

        public RealEstate(){}
        public RealEstate(string location, int price, int yearBuilt, int totalBedRoom, int totalWindow){
            this.type=type;
            this.location=location;
            this.price=price;
            this.yearBuilt=yearBuilt;
            this.totalBedRoom=totalBedRoom;
            this.totalWindow=totalWindow;
        }

        public virtual void InfoDisplay(){
            // Console.WriteLine("Type:", Type==1?"House":"Apartment");
            // Console.WriteLine("Expensivness:", Expensiveness());
            Console.WriteLine($"Other\t\t{Price}\t\t{Location}\t\t{YearBuilt}\t\t{Expensiveness()}");
        }
        public string Expensiveness(){
            if(Price>50000) return "Expensive";
            else if(Price>30000) return "Medium";
            else return "Inexpensive";
        }
    }
}