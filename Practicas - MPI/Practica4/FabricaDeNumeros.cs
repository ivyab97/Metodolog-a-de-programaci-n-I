using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    public class FabricaDeNumeros : FabricaDeComparables    //ejercicio5 - Practica3
    {
        GeneradorDeDatosAleatorios G = new GeneradorDeDatosAleatorios();
        public override Comparable crearAleatorio()
        {
            return new Numero(G.numeroAleatorio(1000));
        }

        public override Comparable crearPorTeclado()
        {
            Console.Write("Numero: ");
            int N = int.Parse(Console.ReadLine());
            return new Numero(N);
        }
    }
}
