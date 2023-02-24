using System;

namespace Practica4
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Patron Adapter, presione 1 (ejercicio4 - practica4)");
			Console.WriteLine("Patron Decorator, predione 2 (ejercicio8 - practica8)");

			int option = int.Parse(Console.ReadLine());

            if (option==1)
            {
                Funciones_Main.ejercicio4_practica4();         //ejercicio4 - Practica4
            }
			else
				Funciones_Main.ejercicio8_practica4();          //ejercicio8 - Practica4

            Console.ReadKey(true);
		}
			
	}
}