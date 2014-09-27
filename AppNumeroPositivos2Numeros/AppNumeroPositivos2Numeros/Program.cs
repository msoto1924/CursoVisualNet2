using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Se ingresa por teclado un número positivo de uno o dos dígitos (1..99) mostrar un mensaje indicando si el número 
//tiene uno o dos dígitos.(Tener en cuenta que condición debe cumplirse para tener dos dígitos, un número entero)

namespace AppNumeroPositivos2Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            string num;
            int digitos;
            Console.WriteLine("Programa Digitos Numeros Positivos");
            Console.WriteLine("Ingrese Su Numero De 1 Al 99");
            num = Console.ReadLine();
            digitos = int.Parse(num);
            if (num.Length<=2 && digitos > 0)
            {
                Console.WriteLine("Su Numero Es Positivo");
                if (num.Length == 2)
                {
                    Console.WriteLine("El Numero Tiene Dos Digitos");
                }
                else
                {
                    Console.WriteLine("El Numero Tiene Un Digito");
                }
            }
                else
                {
                    Console.WriteLine("Su Numero Es Negativo Y Tiene Un Digito");
                }
            Console.ReadKey();
        }
    }
}
