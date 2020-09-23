using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1
{
	class Fibonacci
	{
		public static void sucesionF()
		{
			int contador = 0;
			int numero = 1;
			int numero2 = 2;
			int resultado;
			Console.WriteLine("Esta es la sucesion");

			while (contador<5)
			{
				resultado = numero + numero2;
				numero = numero2;
				numero2 = resultado;
				contador++;
				Console.WriteLine(resultado);
			}

		}
	}
}
