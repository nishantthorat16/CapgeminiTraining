using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public abstract class Account
    {
        public long AccountNumber { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public float AccountBalance { get; protected set; }
        public float IntrestRate { get; protected set; }
        public float MinumumBalance { get; protected set; }

        public abstract void CashDeposit(int depositAmount);

        //Method Overloading
        public float WithDrawAmount(float amount)
        {
            AccountBalance -= amount;
            return AccountBalance;
        }

        //Method Overloading
        public float WithdrawAmount(float amount, int denomination)
        {
            AccountBalance -= amount;
            return AccountBalance;
        }

        //Method in base class
        public void DisplayAccountInfo()
        {
            Console.WriteLine($"ACC NO : {AccountNumber}\n" +
                             $"BALANCE : {AccountBalance}");
        }

        public static Account operator+(Account account1
                                      , Account account2)
        {
            BasicAccount account    = new BasicAccount();
            account.Name            = account1.Name;
            account.Email           = account1.Email;

            account.AccountBalance  = account1.AccountBalance 
                                    + account2.AccountBalance;

            return account;
        }

        public static Account operator-(Account account1
                                      , Account account2)
        {
            BasicAccount account = new BasicAccount();
            account.Name = account1.Name;
            account.Email = account1.Email;

            account.AccountBalance = account1.AccountBalance
                                    - account2.AccountBalance;

            return account;
        }

    }

    public sealed class BasicAccount : Account
    {
        public BasicAccount()
        {
            IntrestRate     = 4.0F;
            MinumumBalance = 10000;
        }

        //Same method name as in base class
        //Said to HIDE the base class member
        public new void DisplayAccountInfo()
        {
            Console.WriteLine($"ACC NO : {AccountNumber}\n" +
                             $"BALANCE : {AccountBalance}\n" +
                             $"NAME    : {Name}");
        }

        //Method overriding
        public override void CashDeposit(int depositAmount)
        {
            if (depositAmount <= 50000)
                AccountBalance += depositAmount;
            else
                Console.WriteLine("You can only deposit up to 50K");
        }

        public override string ToString()
        {
            return $"ACCOUNT NAME : BASIC, ACC NO : {AccountNumber}, ACCOUNT BALANCE :{ AccountBalance}";
        }
    }

    public sealed class PremiumAccount : Account
    {
        public PremiumAccount()
        {
            IntrestRate     = 7.0F;
            MinumumBalance = 50000;
        }

        public override void CashDeposit(int depositAmount)
        {
            if (depositAmount <= 100000)
                AccountBalance += depositAmount;
            else
                Console.WriteLine("You can only deposit up to 1L");
        }

        public override string ToString()
        {
            return $"ACCOUNT NAME : PREMIUM, ACC NO : {AccountNumber}, ACCOUNT BALANCE :{ AccountBalance}";
        }
    }
}
