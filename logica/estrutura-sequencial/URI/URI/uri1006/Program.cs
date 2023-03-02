using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace uri1006 {
    internal class Program {
        static void Main(string[] args) {

            double A, B, C, MEDIA;

            Console.Write("Informe o valor de A: ");
            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Informe o valor de B: ");
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Informe o valor de C: ");
            C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            MEDIA = (A * 2.0 + B * 3.0 + C * 5.0) / 10.0;

            Console.WriteLine("MEDIA = " + MEDIA.ToString("F1", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
