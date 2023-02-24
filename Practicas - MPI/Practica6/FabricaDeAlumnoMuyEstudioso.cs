using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica6
{
    public class FabricaDeAlumnoMuyEstudioso:FabricaDeComparables
    {
       
            GeneradorDeDatosAleatorios G = new GeneradorDeDatosAleatorios();
            public override Comparable crearAleatorio()
            {
                return new AlumnoMuyEstudioso(Nombre_aleatorio.Nombre_azar(), G.numeroAleatorio(48000000), G.numeroAleatorio(50000), G.numeroAleatorio(10));
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
                return new AlumnoMuyEstudioso(Nombre, DNI, Legajo, Prom);
            }
        }
    
}
