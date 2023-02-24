using System;

namespace Practica7
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Patron Adapter, presione 1 (ejercicio4 - practica4)");
			Console.WriteLine("Patron Decorator, presione 2 (ejercicio8 - practica4)");
			Console.WriteLine("Patron Proxy, presione 3 (ejercicio2 - practica5)");
			Console.WriteLine("Patron Command + chain of responsability, predione 4 (ejercicio10 - practica5)");
			Console.WriteLine("Patron Composite, presione 5 (ejercicio2 - practica6)");
			Console.WriteLine("Patron Template method, presione 6 (ejercicio6 - practica6)");
			Console.WriteLine("Patron Change of responsability + Singleton, presion 7 (ejercicio3 y 4- practica7)");

			int option = int.Parse(Console.ReadLine());
			Console.Clear();
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

            if (option == 5)
            {
				Funciones_Main.ejercicio2_practica6();			//ejecicio2 - Practica6
            }

			if (option == 6)
            {
				Funciones_Main.ejercicio6_practica6();			//ejercicio6 - Practica6
            }

			if (option == 7)
			{
				Funciones_Main.ejercicio3y4_practica7();          //ejercicio3 y 4 - Practica7
			}
            if (option == 8)
            {
				Funciones_Main.prueba();
            }
		}
			
	}
}