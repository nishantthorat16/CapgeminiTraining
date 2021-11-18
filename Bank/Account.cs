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
       
        public float IntrestRate    { get; protected set; }
        public float MinumumBalace  { get; protected set; }
    }

    public sealed class BasicAccount : Account
    {
        public BasicAccount()
        {
            IntrestRate     = 4.0F;
            MinumumBalace   = 10000;
        }
    }

    public sealed class PremiumAccount : Account
    {
        public PremiumAccount()
        {
            IntrestRate     = 7.0F;
            MinumumBalace   = 50000;
        }
    }
}
