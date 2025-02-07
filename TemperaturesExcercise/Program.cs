using MyUtilFunctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperaturesExcercise
{
	public class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Ingresa la temperatue en grados Celcius: ");
			double tempC = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Ingresa la temperatue en grados Farenheit: ");
			double tempF = Convert.ToDouble(Console.ReadLine());

			Utilities ut = new Utilities();

			//inferencia de datos
			var convertedFarenheit = ut.CelsiusToFahrenheit(tempC);
			double convertedCelcius = ut.FahrenheitToCelsius(tempF);


		}
	}
}
