using System;

namespace SataicClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarSalesManager bangaloreSales  = new CarSalesManager("Bangalore");
            CarSalesManager mumbaiSales     = new CarSalesManager("Mumbai");

            //On 19/11/2021
            bangaloreSales.SellCar();
            bangaloreSales.SellCar();
            mumbaiSales.SellCar();

            //On 20/11/2021
            bangaloreSales.SellCar();
            mumbaiSales.SellCar();
            mumbaiSales.SellCar();

            //On 21/11/2021
            mumbaiSales.SellCar();
            mumbaiSales.SellCar();

            Console.WriteLine(mumbaiSales);
            Console.WriteLine(bangaloreSales);

            Console.WriteLine("Total Cars Sold : " 
                + GlobalSalesManager.TotalCarsSold);
        }
    }
}
