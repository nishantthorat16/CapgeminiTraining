using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public abstract class Account
    {
        public long AccountNumber   { get; set; }
        public string Name          { get; set; }
        public string Email         { get; set; }
       
        public float AccountBalance { get; protected set; }
        public float IntrestRate    { get; protected set; }
        public float MinumumBalance  { get; protected set; }

        public abstract void CashDeposit(int depositAmount);
    }

    public sealed class BasicAccount : Account
    {
        public BasicAccount()
        {
            IntrestRate     = 4.0F;
            MinumumBalance = 10000;
        }

        public override void CashDeposit(int depositAmount)
        {
            if (depositAmount <= 50000)
                AccountBalance += depositAmount;
            else
                Console.WriteLine("You can only deposit up to 50K");
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
    }
}
