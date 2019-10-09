using System;
using Upcasting.Entidades;

namespace Upcasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(001, "Rafael", 0.0); //Foi instanciado um objeto do tipo Account(conta)
            BusinessAccount bacc = new BusinessAccount(002, "Diva", 0.0, 500.00);

            //Upcasting →Conversão da subclasse para superClasse
            Account acc1 = bacc;  //Uma variavel de BusinessAcount(Bacc),essa conversão de BusinessAccount para uma variavel Account ela é perfeitamente Legal.Na herança a relação é pra 1 ou seja um BussinesAccount é um Account Eu posso atribuir sem problema nenhum
            Account acc2 = new BusinessAccount(003, "Niko", 0.0, 200.00);
            Account acc3 = new SavingsAccount(004, "Fecha", 0.0, 0.01);

            //DownCasting que é conversão da superClasse para subclasse
            //BusinessAccount acc4 = acc2;    → Vai dar o erro,Porque?Ele vai dizer que não pode converte implicitamente um Account para BusinessAccount.
            //Se Eu quiser Converte um Account acc4 para uma variavel BusinessAccount vou ter que fazer um Casting
            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.00);

            //BusinessAccount acc5 = (BusinessAccount)acc3;  Não vai dar erro no compilador mais porém o Acc3 foi instanciado acima com SavingsAccount não é compativel com BusinessAccount.Quando execultar vair dar um erro
            //Vai dar mensagem que nao foi possivel converte o objeto SavingsAccount para BusinessAccount
            //Compilador não preve esse erro.
            //O uso do DownCasting deve ser feito somente quando for necessario.

            if (acc3 is BusinessAccount) //Se a variavel acc3 for uma instancia de BusinessAccount
            {                          //Ai vou fazer conversão Do BusinessAccount acc5,convertendo com casting do acc3
                                       //No caso do If ele vai pular ou falhar,porque o acc3 não é uma instancia BusinessAccount e ai o programa vai pular esse Casting aonde não vai dar nenhum erro...
                BusinessAccount acc5 = (BusinessAccount)acc3;
                acc5.Loan(200.0);     //fazemos o teste para ver se conseguimos fazer o emprestimo

                Console.WriteLine("Loan");
            }

            if (acc3 is SavingsAccount)
            {
                SavingsAccount acc5 = (SavingsAccount)acc3;
                acc5.UpdateBalance();
                Console.WriteLine("update !");
            }
        }
    }
}
