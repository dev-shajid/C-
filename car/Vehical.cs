using System;
namespace Project
{
    public class Vehical
    {
        private string Make;
        private string Model;
        private int Year;
        public string make
        {
            get; set;
        }
        public string model
        {
            get; set;
        }
        public int year
        {
            get => year;
            set
            {
                if (value >= 1 && value < 100)
                {
                    year += 2000;
                }
                else if (value >= 2000 && value <= 2100)
                {
                    year = value;
                }
                else
                {
                    Console.WriteLine("Invalid Year ,Please Provide a valid year...");
                }
            }
        }
        public double FuelEfficiency
        {
            get => calculateFuelEfficiency();
            
        }
        public double calculateFuelEfficiency()
        {
            int currY = DateTime.Now.Year;
            int carAge = currY - year;
            return 30 - (2 * carAge);
        }
        public Vehical(string make, string model, int year)
        {
            this.make = make;
            this.model = model;
            this.year = year;
        }
        public virtual void showInfo()
        {
            Console.WriteLine($"Make:{make}, Model:{model}, Year:{year}, FuelEfficiency :{FuelEfficiency}");
        }
        public virtual void showMaintenences()
        {
            Console.WriteLine("Maintenences Record :");
            foreach (string auto in maintenences)
            {
                if (auto != null)
                {
                    Console.WriteLine(auto);
                }
            }
        }
        public string[] maintenences = new string[10];
        int index = 0;
        public virtual void NewMaintenences(DateTime dateTime, string description)
        {
            if (index < maintenences.Length)
            {
                string maintenencesRecord = $"{dateTime.ToShortDateString()} : {description}";
                maintenences[index++] = maintenencesRecord;
            }
            else
            {
                Console.WriteLine("Storage is Full");
            }
        }
    }
}