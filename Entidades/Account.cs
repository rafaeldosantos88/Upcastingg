using System;
using System.Collections.Generic;
using System.Text;

namespace Upcasting.Entidades
{
    class Account    //Classe conta
    {
        public int Number { get; set; }        // Numero Conta
        public string Holder { get; set; }    //Titular conta
        public double Balance { get; protected set; }  //Saldo da conta

        public Account()                    //Construtor padrão
        {

        }

        public Account(int number, string holder, double balance) //Construtor com argumentos
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }
        public void withdraw(double amount) //Operação Saque(WIthdraw) recebendo uma quantia(amount)
        {
            Balance -= amount; //Para fazer o saque fazemos o Calculo Balance(saldo)- amount(quantia)

        }
        public void Deposit(double amount) // Operação deposito
        {
            Balance += amount;

        }

    }
}
