using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace uri1002 {
    internal class Program {
        static void Main(string[] args) {

            double PI = 3.14159;

            Console.WriteLine("Informe o valor do Raio");
            double R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double A = PI * R * R;

            Console.WriteLine("A = " + A.ToString("F4", CultureInfo.InvariantCulture));
            Console.ReadLine();


        }
    }
}
