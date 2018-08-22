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

        public int Id {
            get { return this.id;}
            set { this.id = value; }
        }

        public double Balance {
            get { return this.balance; }
            set { this.balance = value; }
        }
    }
}
