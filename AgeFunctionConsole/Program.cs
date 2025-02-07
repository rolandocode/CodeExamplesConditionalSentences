using MyUtilFunctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeFunctionConsole
{
	public class Program
	{
		static void Main(string[] args)
		{

			int age;
			Console.WriteLine("Ingresa tu edad: ");
			age = Convert.ToInt32(Console.ReadLine());

			Utilities.DeterminarSiEsMayorDeEdad(age);

			Console.ReadLine();

			//Funcion Non static -> tengo que instanciar un objeto para usar el metodo o funcion
			//Perro perro1 = new Perro();
			//perro1.Ladrar();

			//Function static -> Para no tener que declar o instanciar el objeto
			//Perro.Dormir();

		}

	
	}
}
