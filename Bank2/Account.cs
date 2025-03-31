using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank;



namespace Bank
{
    internal class Account
    {
        public string Number { get; private set; }
        public string Owner { get; private set; }
        public float Balance { get; private set; }

        public Account(string number, string owner, float balance)
        {
            Number = number;
            Owner = owner;
            Balance = balance;
        }
        public void abheben(float summe)
        {
            Balance -= summe;
        }
        public void einzahlen(float summe)
        {
            Balance = summe + Balance;
        }
        public float kontostand()
        {
            return Balance;
        }
    }
}
