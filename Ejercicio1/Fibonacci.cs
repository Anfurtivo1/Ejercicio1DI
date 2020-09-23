using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1
{
	class Fibonacci
	{
		public static void sucesionF(int max)
		{
			int contador = 0;
			int numero = 1;
			int numero2 = 2;
			int resultado;
			bool ejecutar=true;
			Console.Clear();
			Console.WriteLine("Esta es la sucesion");
			if (max==1)
			{
				Console.WriteLine(numero);
				ejecutar = false;
			}

			if (max==2)
			{
				Console.WriteLine(numero);
				Console.WriteLine(numero2);
				ejecutar = false;
			}
			if (max>2)
			{
				Console.WriteLine(numero);
				Console.WriteLine(numero2);
			}
			while (contador<max && ejecutar)
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
