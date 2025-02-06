using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationsExercise
{
	public class Program
	{
		static void Main(string[] args)
		{
			//condicion inicial
			int numero = 1;

			while (numero <= 10) //evaluación: -> true o false
			{
				if (numero % 2 == 0)
					Console.WriteLine(numero);
				//numero = numero + 1;
				numero++;
				//numero+=3 es igual a numero = numero + 3
			}

			Console.WriteLine("====================");
			for (int segundoNumero = 1; segundoNumero <= 10; segundoNumero++)
			{
				if (segundoNumero % 2 == 0)
					Console.WriteLine(segundoNumero);
			}


			Console.ReadKey();
		}
	}
}
