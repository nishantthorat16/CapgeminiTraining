using System;

namespace Bank
{
    public abstract partial class Account
    {
        public float LoanRate   { get; set; } 
        public float LoanTenure { get; set; }
    }
}
