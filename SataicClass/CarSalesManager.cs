using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SataicClass
{
    public static class GlobalSalesManager
    {
        public static int TotalCarsSold { get; set; }
    }

    public class CarSalesManager
    {
        public int TotalCarsSold { get; private set; }
        public string CityName { get; private set; }

        public CarSalesManager(string cityName)
        {
            CityName = cityName;
        }

        public void SellCar()
        {
            GlobalSalesManager.TotalCarsSold += 1;
            TotalCarsSold += 1;
        }

        public override string ToString()
        {
            return $"CITY : {CityName}, TOTAL CARS SOLD : {TotalCarsSold}";
        }
    }
}
