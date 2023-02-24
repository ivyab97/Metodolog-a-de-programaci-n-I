using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica6
{
    public class FabricaDeAlumnos : FabricaDeComparables    //ejercicio5 - Practica3
    {
        GeneradorDeDatosAleatorios G=new GeneradorDeDatosAleatorios();
        public override Comparable crearAleatorio()
        {
            return new Alumno(Nombre_aleatorio.Nombre_azar(), G.numeroAleatorio(48000000), G.numeroAleatorio(50000), G.numeroAleatorio(10));
        }
        public Comparable crearAleatorioAlumnoME()      //tuve que implementar este metodo para resolver el ejercicio4 de la practica4
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
            int Legajo =int.Parse(Console.ReadLine());
            Console.WriteLine("Promedio: ");
            int Prom =int.Parse(Console.ReadLine());
            return new Alumno(Nombre, DNI, Legajo, Prom);
        }
    }
}
