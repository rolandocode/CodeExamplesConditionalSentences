using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUtilFunctions
{
    public class Utilities
    {
		public static void DeterminarSiEsMayorDeEdad(int yearsOld)
		{
			if (yearsOld < 18)
			{
				Console.WriteLine("La persona es menor de edad x_x");
			}
			else
				Console.WriteLine("La persona es mayor de edad :D");
		}
		public double CelsiusToFahrenheit(double celsius)
		{
			return (celsius * 9 / 5) + 32;
		}

		// Example of a Fahrenheit to Celsius conversion (for completeness)
		public double FahrenheitToCelsius(double fahrenheit)
		{
			return (fahrenheit - 32) * 5 / 9;
		}

		public static void Saludar()
		{
			Console.WriteLine("Hola!!, bienvenido a mis programas!!!");
		}

		public static int SumarNumeros (int[] numeros)
		{
			int indice = 0;
			int suma = 0;

			while (indice < numeros.Length)
			{
				suma = suma + numeros[indice];
				indice++;
			}

			return suma; 
		}
	}
}
