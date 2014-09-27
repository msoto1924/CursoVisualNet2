using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNotasAlumno
{
    class Program
    {
        static void Main(string[] args)
        {
            float nota1, nota2, nota3, promedio;
			Console.WriteLine ("Ingrese Las Tres Notas Del ALumno");
			Console.WriteLine ("Ingrese La Primera Nota");
			nota1=float.Parse (Console.ReadLine ());
			Console.WriteLine ("Ingrese La segunda Nota");
			nota2=float.Parse (Console.ReadLine ());
			Console.WriteLine ("Ingrese La Tercera Nota");
			nota3=float.Parse (Console.ReadLine ());
			promedio = (nota1 + nota2 + nota3)/3;
			if (promedio >= 3.5) 
            {
				Console.WriteLine ("Promocionado");
			}
				else
			{
				Console.WriteLine ("Reprobo");
			}
            Console.ReadKey();
        }
    }
}