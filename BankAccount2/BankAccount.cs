using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount2
{
    class BankAccount
    {
        private int id;

        private double balance;

        public BankAccount()
        {
            this.Id = id;
            this.Balance = balance;
        }

        public int Id { get; set; }

        public double Balance { get; set; }
    }
}
