using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Heranca.Entities;

namespace Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region UPCASTING/DOWNCASTING
            //Account acc = new Account(1001, "Alex", 0.0);
            //BusinessAcount bacc = new BusinessAcount(1002, "Maria", 0.0, 500.0);

            ////UPCASTING - Conversão da subclasse para a superclasse

            //Account acc1 = bacc;
            //Account acc2 = new BusinessAcount(1003, "Bob", 0.0, 200.0);
            //Account acc3 = new SavingsAccount(1004, "Ana", 0.0, 0.01);

            ////DOWNCASTING - Conversão da superclasse para a subclasse 

            //BusinessAcount bacc1 = (BusinessAcount)acc2;
            //bacc1.Loan(100.0);

            //if (acc3 is BusinessAcount)
            //{
            //    //BusinessAcount bacc2 = (BusinessAcount)acc3;
            //    BusinessAcount bacc2 = acc3 as BusinessAcount; // Utiliza o (as) como outra forma de fazer o CASTING
            //    bacc2.Loan(200.0);
            //    Console.WriteLine("Loan!");
            //} else
            //{
            //    Console.WriteLine("Falhou!");
            //}
            #endregion

            Account acc1 = new Account(1001, "Alex", 500.0);
            Account acc2 = new SavingsAccount(1002, "Annar", 500.0, 0.01);

            acc1.WithDraw(10.0);
            acc2.WithDraw(10.0);

            Console.WriteLine("Account: " + acc1.Balance);
            Console.WriteLine("SavingsAccount: " + acc2.Balance);


            Console.ReadLine();
        }
    }
}
