using System;

namespace Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BasicAccount account            = new BasicAccount();
            PremiumAccount premiumAccount   = new PremiumAccount();

            Console.WriteLine($"Basic : {account.IntrestRate} , {account.MinumumBalace}");
            Console.WriteLine($"Premium : {premiumAccount.IntrestRate} , {premiumAccount.MinumumBalace}");
        }
    }
}
