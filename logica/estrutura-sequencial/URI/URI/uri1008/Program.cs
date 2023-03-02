using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace uri1008 {
    internal class Program {
        static void Main(string[] args) {

            int numeroFuncionario;
            double numeroHorasTrabalhadas, valorHoraTrabalhada, salario;

            Console.Write("Digite o número do funcionário: ");
            numeroFuncionario = int.Parse(Console.ReadLine());
            Console.Write("Digite o número de horas trabalhas: ");
            numeroHorasTrabalhadas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o valor da hora trabalhada: ");
            valorHoraTrabalhada = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = numeroHorasTrabalhadas * valorHoraTrabalhada;

            Console.WriteLine("NÚMERO = " + numeroFuncionario);
            Console.WriteLine("SALÁRIO = " + " U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
            
            Console.ReadLine();


        }
    }
}
