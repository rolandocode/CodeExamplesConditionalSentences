using System;
using System.Runtime.InteropServices.ComTypes;

namespace IfExample
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//1- declarar una variable que guarde el numero
			//2- leer ese numero del teclado
			//3  Si numero MOD 2 es cero
			//4- Imprimir 'es par'
			//5- Sino Imprimir 'no es par'

			//1
			double numero;

			//2

			do
			{
				Console.WriteLine("Ingresa los numeros que quieras, cuando quiera parar introduce -1: ");
				//numero = Convert.ToInt32(Console.ReadLine());
				string numString = Console.ReadLine();
				numero = double.Parse(numString);

				if (numero == -1)
					break;
				//3
				if (numero % 2 == 0)
				{
					// 4
					Console.WriteLine("Éste número es par");
				}
				else
				{
					//5
					Console.WriteLine("Este numero no es par");
				}
			}
			while (numero != -1);

			Console.ReadKey();

		}
	}
}
