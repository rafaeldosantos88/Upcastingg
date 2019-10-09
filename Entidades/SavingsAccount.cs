using System;
using System.Collections.Generic;
using System.Text;

namespace Upcasting.Entidades
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; } //TAXA DE JUROS

        public SavingsAccount()
        {

        }
        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = InterestRate;
        }
        public void UpdateBalance()
        {
            Balance += Balance * InterestRate; // Vai atualizar o saldo da conta baseado na taxa de juros InteresRate
        }
    }
}