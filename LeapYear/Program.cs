using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear
{
	public class Program
	{
		static void Main(string[] args)
		{
			//declaramos la variable year
			//leemos la variable year
			//Si year MOD 4 == 0
			//Imprimir es biciesto
			//Si no
			//Imprimir no es biciesto

			Console.WriteLine("Ingresa un año cualquiera");


			int year;
			year = Convert.ToInt32(Console.ReadLine());

			if (year <= 0)
				Console.WriteLine("Error, los años deben ser positivos");

			if (year % 4 == 0)
				Console.WriteLine("El año es biciesto");
			else
				Console.WriteLine("El año no es biciesto");

			Console.ReadKey();
		}
	}
}
