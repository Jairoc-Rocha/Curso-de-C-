using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas {
    internal class Program {
        static void Main(string[] args) {

            List<string> list = new List<string>();

            list.Add("Maria"); // o Add() Adiciona um elemento no final da lista
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Insert(2, "Marco"); // O Insert você pode especificar qual posição pode inserir um elemento

            foreach(string obj in list) {
                Console.WriteLine(obj);
            }

            Console.WriteLine("List count: " + list.Count); // O Count retorna o tamanho da lista

            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A': " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': " + s2);

            int pos1= list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position 'A': " + pos2);

            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("---------------------------------");
            foreach(string obj in list2) {
                Console.WriteLine(obj);
            }

            list.Remove("Alex");
            Console.WriteLine("---------------------------------");
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("---------------------------------");
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            Console.ReadLine();
        }
    }
}
