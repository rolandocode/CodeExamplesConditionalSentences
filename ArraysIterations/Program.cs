using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysIterations
{
	public class Program
	{
		static void Main(string[] args)
		{
			int[] numeros = new int[] { 12, 16, 90, 34, 41, 90 };

			//Console.WriteLine(numeros[0]);
			//Console.WriteLine(numeros[1]);
			//Console.WriteLine(numeros[2]);
			//Console.WriteLine(numeros[3]);

			int indice = 0;
			while (indice < numeros.Length)
			{
				Console.WriteLine(numeros[indice]);
				indice++;
			}

			Console.WriteLine("==========================");

			for (int index = 0; index < numeros.Length; index++)
			{
				Console.WriteLine(numeros[index]);
			}

			Console.WriteLine("==========================");

			foreach (int itemNumero in numeros) {
				Console.WriteLine(itemNumero);
			}


			Console.ReadLine();



		}
	}
}
