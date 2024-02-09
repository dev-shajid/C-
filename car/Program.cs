using System;
namespace Project
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("hello from main class");
            Vehical vehical = new Vehical("Saimun", "XSR", 2020);
            //vehical.NewMaintenences(DateTime.Now, "oil Change");
            DateTime oilChangeDate = DateTime.ParseExact("01-01-2023", "dd-mm-yyyy", null);
            vehical.NewMaintenences(oilChangeDate, "oil change");
            vehical.showInfo();
            vehical.showMaintenences();
        }
    }
}