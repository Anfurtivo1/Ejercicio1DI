using System;

namespace Ejercicio1
{
	class Program
	{
		static void Main(string[] args)
		{   //1-Pide al usuario dos numeros enteros y calcula la resta de forma que siempre se vuelva un valor positivo. 
			//Verifica los datos que el usuario introduce deben ser numeros enteros con la funcion TryParse

			//2- Pide al usuario un numero entero de no mas de 5 cifras y calcula las cifras que tiene dicho numero
			
			int opcionV;

			Console.WriteLine("Indica una de las opciones");
			Console.WriteLine("1- Resta positiva");
			Console.WriteLine("2-Contar cifras numero");
			Console.WriteLine("3-Sumar intervalos");
			Console.WriteLine("4-Fibonacci");
			Console.WriteLine("5-Salir");
			opcionV = int.Parse(Console.ReadLine());

			switch (opcionV)
			{
				case 1:

					int numero1;
					int numero2;
					bool valido;

					Console.WriteLine("Indica un numero");
					valido = int.TryParse(Console.ReadLine(), out numero1);

					Console.WriteLine("Indica otro numero");
					valido = int.TryParse(Console.ReadLine(), out numero2);

					Resta.comprobacion(numero1, numero2);
					break;

				case 2:
					int numero3;
					Console.WriteLine("Indica un numero");
					numero3 = int.Parse(Console.ReadLine());
					cifrasNumero.contarCifras(numero3);
					break;

				case 3:
					int numeroMin;
					int numeroMax;
					Console.WriteLine("Indica el numero minimo");
					numeroMin = int.Parse(Console.ReadLine());
					Console.WriteLine("Indica el numero maximo");
					numeroMax = int.Parse(Console.ReadLine());
					sumaIntervalo.calcularIntervalo(numeroMin,numeroMax);
					break;

				case 4:
					int max;
					Console.WriteLine("Indica cuantos numeros de Fibonacci quieres sacar");
					max = int.Parse(Console.ReadLine());
					Fibonacci.sucesionF(max);
					break;

				case 5:
					Console.WriteLine("Adios");
					break;

			}

			



		}

	}	
}
