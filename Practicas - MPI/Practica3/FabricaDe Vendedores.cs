using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3
{
    public class FabricaDeVendedores : FabricaDeComparables //Fabrica concreta //ejercicio9_practica3
    {
        GeneradorDeDatosAleatorios G=new GeneradorDeDatosAleatorios();
        public override Comparable crearAleatorio()
        {
            return new Vendedor(Nombre_aleatorio.Nombre_azar(), G.numeroAleatorio(48000000), G.numeroAleatorio(10000));
        }

        public override Comparable crearPorTeclado()
        {
            Console.WriteLine("Nombre: ");
            string Nombre = Console.ReadLine();
            Console.WriteLine("DNI: ");
            int DNI = int.Parse(Console.ReadLine());
            Console.WriteLine("Sueldo Basico: ");
            int SueldoB = int.Parse(Console.ReadLine());
            return new Vendedor(Nombre, DNI, SueldoB);
        }
    }
}
