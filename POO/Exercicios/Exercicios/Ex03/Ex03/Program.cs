using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Ex03 {
    internal class Program {
        static void Main(string[] args) {

            Funcionario f = new Funcionario();

            Console.WriteLine("Dados de um funcionario");
            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();

            Console.WriteLine("Funcionário: " + f);
            Console.WriteLine();

            Console.Write("Digite o porcentual para aumentar o salário: ");
            double aumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f.AumentarSalario(aumento);

            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: " + f);

            Console.ReadLine();
        }
    }
}
