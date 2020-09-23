using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1
{
	class Resta
	{
		public static bool comprobacion(int num1, int num2)
		{
			bool valido=true;
			int resultado;

			resultado = num1 - num2;
			while (resultado<0)
			{
				Console.WriteLine("Indica otros numeros");
				valido = int.TryParse(Console.ReadLine(), out num1);
				valido = int.TryParse(Console.ReadLine(), out num2);
				resultado = num1 - num2;
				Console.Clear();
			}
			
			Console.WriteLine("La resta de ambos numeros es " + resultado);
			return valido;
		}
	}
}
