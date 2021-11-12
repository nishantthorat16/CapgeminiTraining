using System;

namespace TaxCalcualtor
{
    public class Program
    {
        static void Main(string[] args)
        {
            int totalCtc;
            float taxPercentage;

            //GetCtc(out totalCtc);
            totalCtc = GetCtc();

            CalculateTaxPercentage(out taxPercentage, totalCtc);
            CalculateAndDisplayTax(totalCtc, taxPercentage);
        }

        static void GetCtc(out int totalCtc)
        {
            Console.Write("Enter your annual salary :");
            totalCtc = int.Parse(Console.ReadLine());
        }

        static int GetCtc()
        {
            Console.Write("Enter your annual salary :");
            int totalCtc = int.Parse(Console.ReadLine());
            return totalCtc;
        }

        static void CalculateTaxPercentage(out float taxPercentage,int totalCtc)
        {
            taxPercentage = 0.0F;
            if (totalCtc >= 200000 && totalCtc < 500000)
                taxPercentage = 0.10F;
            else if (totalCtc >= 500000 && totalCtc < 700000)
                taxPercentage = 0.20F;
            else if (totalCtc >= 700000)
                taxPercentage = 0.30F;
        }

        static void CalculateAndDisplayTax(int totalCtc,float taxPercentage)
        {
            float totalTaxPayable = totalCtc * taxPercentage;
            Console.WriteLine($"You have to pay a total tax of {totalTaxPayable}");
        }
    }
}
