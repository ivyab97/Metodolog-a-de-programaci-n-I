using System;

namespace Practica5
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Patron Adapter, presione 1 (ejercicio4 - practica4)");
			Console.WriteLine("Patron Decorator, presione 2 (ejercicio8 - practica4)");
			Console.WriteLine("Patron Proxy, presione 3 (ejercicio2 - practica5)");
			Console.WriteLine("Patron Command, predione 4 (ejercicio10 - practica5)");

			int option = int.Parse(Console.ReadLine());

            if (option==1)
            {
                Funciones_Main.ejercicio4_practica4();         //ejercicio4 - Practica4
            }
            if (option==2)
            {
				Funciones_Main.ejercicio8_practica4();          //ejercicio8 - Practica4
			}

            if (option==3)
            {
				Funciones_Main.ejercicio2_practica5();			//ejercicio2 - Practica5
            }

			if (option == 4)
            {
				Funciones_Main.ejercicio10_practica5();			//ejercicio10 - Practica5
            }

			Console.ReadKey(true);
		}
			
	}
}