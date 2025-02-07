using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsExercises
{
	public class Program
	{
		static void Main(string[] args)
		{
			//Un mensaje para que ingrese el primer numero
			//Darle entrada al primer numero
			//Un mensaje para que ingrese el segundo numero
			//Darle entrada al segundo numero
			//Operacion de suma del primer numero + segundo numero
			//Imprimimos la suma

			Console.WriteLine("Ingresa el primer numero");
			int numero1 = Convert.ToInt16(Console.ReadLine());
			Console.WriteLine("Ingresa el segundo numero");
			int numero2 = Convert.ToInt16(Console.ReadLine());

			HacerOperaciones(numero1, numero2);

			Console.WriteLine("Vamos a sumar otros numeros, ingresa otro numero");
			int a = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Vamos a sumar otros numeros, ingresa otro numero más");
			int b = Convert.ToInt32(Console.ReadLine());

			HacerOperaciones(a, b);

			Console.ReadLine();
		}

		public static void HacerOperaciones(int n1, int n2) // <- Parametros
		{
			int suma = HacerSuma(n1, n2);
			int rest = HacerResta(n1, n2);
			int mult = n1 * n2;
			int mod = n1 % n2;

			Console.WriteLine("Suma: " + suma);
			Console.WriteLine("Resta: " + rest);
			Console.WriteLine("Mult: " + mult);
			Console.WriteLine("Modulo: " + mod);
		}

		//[alcance de la función][static o no][típo de retorno] [nombre de la función] (parametros)  
		public static int HacerSuma(int n1, int n2)
		{
			return n1 + n2;
		}

		public static int HacerResta(int n1, int n2)
		{
			return n1 - n2;
		}

	}
}
