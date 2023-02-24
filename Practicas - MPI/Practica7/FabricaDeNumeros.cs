using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica7
{
    public class FabricaDeNumeros : FabricaDeComparables
    {

        public override Comparable crearAleatorio()
        {
            setManejador(cadenaDeResponsabilidades());      //ejercicio2 - practica7

            return new Numero(manejador.numeroAleatorio(1000));
        }


        public override Comparable crearPorTeclado()
        {
            setManejador(cadenaDeResponsabilidades());      //ejercicio2 - practica7

            Console.Write("Numero: ");

            int N = manejador.numeroPorTeclado();      //ejercicio2 - practica7

            return new Numero(N);
        }
        public override Comparable crearPorArchivo()
        {
            setManejador(cadenaDeResponsabilidades());      //ejercicio3 - practica7
            
            Console.Write("Numero de línea del archivo: ");

            double max = double.Parse(Console.ReadLine());

            double N = manejador.numeroDesdeArchivo(max);      //ejercicio3 - practica7

            return new Numero(N);

        }
    }
}
