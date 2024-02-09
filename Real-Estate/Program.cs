using System;

namespace RealEstateProject{
    class Program{
        List<RealEstate> lists=new List<RealEstate>();

        void AddNewHouse(){
            Console.WriteLine("Enter the Length of the House: ");
            double length=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Width of the House: ");
            double width=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Location of the House: ");
            string location=Console.ReadLine();
            Console.WriteLine("Enter the Price of the House: ");
            int price=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("In which Year the house is Built in? ");
            int yearBuilt=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Total Bedroom in the House: ");
            int totalBedRoom=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Total Window in the House: ");
            int totalWindow=Convert.ToInt32(Console.ReadLine());
    
            House house = new House(location, price, yearBuilt, length, width, totalBedRoom, totalWindow);
            lists.Add(house);
        }

        void AddNewApartment(){
            Console.WriteLine("Enter the Location of the Apartment: ");
            string location=Console.ReadLine();
            Console.WriteLine("Enter the Price of the Apartment: ");
            int price=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("In which Year the house is Built in? ");
            int yearBuilt=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Total Bedroom in the Apartment: ");
            int totalBedRoom=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Total Window in the Apartment: ");
            int totalWindow=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Monthly Rent of the Apartment: ");
            int monthlyRent=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Is there any Garden? (type 1/0)");
            int garden=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Is there any Swiming Pool? (type 1/0)");
            int swimingPool=Convert.ToInt32(Console.ReadLine());
    
            Apartment apartment = new Apartment(location, price, yearBuilt, monthlyRent, garden==0?true:false, swimingPool==0?true:false, totalBedRoom, totalWindow);
            lists.Add(apartment);
        }

        public void ShowLists(){
            foreach(RealEstate item in lists) item.InfoDisplay();
        }

        public void ShowPrimaryMenu(){
            Console.WriteLine("Select an option: ");
            Console.WriteLine("1. Add House");
            Console.WriteLine("2. Add Apartment");
            Console.WriteLine("3. Show Lists");
            Console.WriteLine("4. Exit");
        }

        static void Main() {
            Console.Clear();
            Program program = new Program();
            while(true){
                program.ShowPrimaryMenu();
                int choose = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                if(choose==1) program.AddNewHouse();
                else if(choose==2) program.AddNewApartment();
                else if(choose==3) program.ShowLists();
                else if(choose==4) break;
                else Console.WriteLine("Invalid Key!");
            } 
        }
    }
}