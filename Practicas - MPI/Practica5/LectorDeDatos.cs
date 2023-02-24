using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica5
{
    public class LectorDeDatos      //ejercicio3 - Practica3
    {
        public int numeroPorTeclado()
        {
            int numero = int.Parse(Console.ReadLine());
            return numero;
        }
        public string stringPorTeclado()
        {
            string str = Console.ReadLine();
            return str;
        }
    }
}
