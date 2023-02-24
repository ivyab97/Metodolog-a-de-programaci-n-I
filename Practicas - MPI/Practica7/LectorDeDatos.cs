using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica7
{
    public class LectorDeDatos : ManejadorObtencionDeDatos    //ejercicio1 - Practica7
    {
        private static LectorDeDatos instanciaUnica;		//Patron Singleton  - ejercicio4 - practica7

        private LectorDeDatos(ManejadorObtencionDeDatos s) : base(s)
        {
        }
        public static LectorDeDatos Get_instanciaUnica(ManejadorObtencionDeDatos s)     //Metodo estatico - Patron Singleton - ejercicio4 - practica7
        {
            if (instanciaUnica == null)
            {
                instanciaUnica = new LectorDeDatos(s);
            }
            return instanciaUnica;
        }

        public override int numeroPorTeclado()
        {
            int numero = int.Parse(Console.ReadLine());
            return numero;
        }
        public override string stringPorTeclado()
        {
            string str = Console.ReadLine();
            return str;
        }
    }
}
