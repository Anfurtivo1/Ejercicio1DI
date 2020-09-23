using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1
{
	class sumaIntervalo
	{
		public static int calcularIntervalo(int numeroMin,int numeroMax)
		{
			Console.Clear();
			Console.WriteLine("La suma desde el "+ numeroMin+ " hasta el "+ numeroMax+ " es:");
			int aux = 0;
			int resultado;
			for (int i = 0; i < numeroMax; i++)
			{
				resultado = numeroMin + aux;
				aux = resultado;
				numeroMin++;

			}
			Console.WriteLine(aux);
			return aux;
		}
	}
}
