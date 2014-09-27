using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            string numero;
            Console.WriteLine("Programa Caracter A Numero");
            Console.WriteLine("Digite Solo Numeros De uno a Cinco");
            numero = Console.ReadLine();
            switch (numero)
            {
                case "1":
                    Console.WriteLine("Uno");
                    break;
                case "2":
                    Console.WriteLine("Dos");
                    break;
                case "3":
                    Console.WriteLine("Tres");
                    break;
                case "4":
                    Console.WriteLine("Cuatro");
                    break;
                case "5":
                    Console.WriteLine("Cinco");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
            Console.ReadKey();
        }
    }
}