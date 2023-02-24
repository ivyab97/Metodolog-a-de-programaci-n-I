/*
 * Created by Metodologías de Programación I
 * Activity 7. 
 * Chain of responsability and Singleton patterns 
 *
 * Antes de usar este código el alumno deberá agregar a la variable "ruta_archivo" de la clase 
 * "LectorDeArchivos" la ruta correspondiente a su equipo donde haya guardado el archvo con los datos
 * provistos por la cátedra (archivo datos.txt)
 *
 * IMPORTANTE *  
 * El código que está en este archivo SI puede modificarse para resolver la actividad solicitada
 * 
 */

using System;
using System.IO;

namespace Practica7
{
	public class LectorDeArchivos : ManejadorObtencionDeDatos
	
	{
		
		// El alumno deberá agregar la ruta correspondiente a su equipo donde haya guardado el archvo con los datos
		private const string ruta_archivo = @"C:\Users\W10-PC\Desktop\Metodologia de programacion I\Practicas - MPI\Practicas\Practica7\datos3.txt";
        // --------------------------------------------------------------------------------------------------------
        private static LectorDeArchivos instanciaUnica;		//Patron Singleton  - ejercicio4 - practica7

        protected StreamReader lector_de_archivos1;
		protected StreamReader lector_de_archivos2;
		protected string word = null;

        private LectorDeArchivos(ManejadorObtencionDeDatos s) : base(s)
        {

		}
        public static LectorDeArchivos Get_instanciaUnica(ManejadorObtencionDeDatos s)     //Metodo estatico - Patron Singleton - ejercicio4 - practica7
        {
            if (instanciaUnica == null)                    
            {                                               
                instanciaUnica = new LectorDeArchivos(s);  
            }                                             
            return instanciaUnica;
        }
        public override double numeroDesdeArchivo(double num)
		{
			lector_de_archivos1 = new StreamReader(ruta_archivo);

			word = num + "_";
			string linea = lector_de_archivos1.ReadLine();
			return Double.Parse(linea.Substring((linea.IndexOf((word))+word.Length), 7)); //En el primer parametro tenemos el indice de linea, en el segundo hasta donde tiene que llegar tomando como referencia la posicion del indice de linea.
		}

		public override string stringDesdeArchivo(int cant){

			lector_de_archivos2 = new StreamReader(ruta_archivo);

			string cantidad = cant + "_";
			cant++;
			string cantidad2 = cant + "_";
			string linea = lector_de_archivos2.ReadLine();
			return linea.Substring(((linea.IndexOf(cantidad))+cantidad.Length+9), linea.IndexOf(cantidad2) - ((linea.IndexOf(cantidad)) + cantidad.Length + 9));
		}
	}
}

