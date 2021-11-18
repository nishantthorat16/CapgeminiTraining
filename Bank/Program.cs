using System;

namespace Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            BasicAccount account            = new BasicAccount();
            PremiumAccount premiumAccount   = new PremiumAccount();

            Console.WriteLine(account.ToString());
            Console.WriteLine(premiumAccount.ToString());

            account.DisplayAccountInfo();*/

            //Console.WriteLine($"Basic : {account.IntrestRate} , {account.MinumumBalance}");
            //Console.WriteLine($"Premium : {premiumAccount.IntrestRate} , {premiumAccount.MinumumBalance}");

            BasicAccount account1 = new BasicAccount();
            account1.Name = "Sreehari Aranghat";
            account1.AccountNumber = 10001;
            account1.CashDeposit(40000);


            PremiumAccount account2 = new PremiumAccount();
            account2.Name           = "Sreehari Aranghat";
            account2.AccountNumber  = 10002;
            account2.CashDeposit(90000);

            /*
                +, -, ==, != , / , *
             */

            var consolidatdAccount = account1 + account2;
            var subtractAccount = account1 - account2;
            Console.WriteLine($"Consolicated Account = {consolidatdAccount.AccountBalance}");

        }
    }
}
