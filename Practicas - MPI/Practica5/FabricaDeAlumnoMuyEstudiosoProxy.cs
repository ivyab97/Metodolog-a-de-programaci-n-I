using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica5
{
    public class FabricaDeAlumnoMuyEstudiosoProxy : FabricaDeComparables
    {
        GeneradorDeDatosAleatorios G = new GeneradorDeDatosAleatorios();
        public override Comparable crearAleatorio()
        {
            return new AlumnoProxy(Nombre_aleatorio.Nombre_azar(), G.numeroAleatorio(46000000), G.numeroAleatorio(50000), G.numeroAleatorio(10), 2);
        }

        public override Comparable crearPorTeclado()
        {
            Console.WriteLine("Ingrese un Alumno por teclado");
            Console.WriteLine("Nombre: ");
            string Nombre = Console.ReadLine();
            Console.WriteLine("DNI: ");
            int DNI = int.Parse(Console.ReadLine());
            Console.WriteLine("Legajo: ");
            int Legajo = int.Parse(Console.ReadLine());
            Console.WriteLine("Promedio: ");
            int Prom = int.Parse(Console.ReadLine());
            return new AlumnoProxy(Nombre, DNI, Legajo, Prom, 2);
        }
    }
}
