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
            BusinessAcount account = new BusinessAcount(8010, "Bob Brown", 100.00, 500.0);


            Console.WriteLine(account.Balance);

            Console.ReadLine();
        }
    }
}
