using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica7
{
    public class FabricaDeAlumnoMuyEstudioso : FabricaDeComparables
    {       
            public override Comparable crearAleatorio()
            {
                setManejador(cadenaDeResponsabilidades());      //ejercicio2 - practica7
    
                return new AlumnoMuyEstudioso(Nombre_aleatorio.Nombre_azar(), manejador.numeroAleatorio(48000000), manejador.numeroAleatorio(50000), manejador.numeroAleatorio(10));
            }

        public override Comparable crearPorTeclado()
            {
                setManejador(cadenaDeResponsabilidades());      //ejercicio2 - practica7

                Console.WriteLine("Ingrese un Alumno por teclado");
                Console.WriteLine("Nombre: ");
                string Nombre = manejador.stringPorTeclado();
                Console.WriteLine("DNI: ");
                int DNI = manejador.numeroPorTeclado();
                Console.WriteLine("Legajo: ");
                int Legajo = manejador.numeroPorTeclado();
                Console.WriteLine("Promedio: ");
                int Prom = manejador.numeroPorTeclado();
                Console.Clear();

            return new AlumnoMuyEstudioso(Nombre, DNI, Legajo, Prom);
            }
        public override Comparable crearPorArchivo()
        {
            setManejador(cadenaDeResponsabilidades());      //ejercicio3 - practica7

            Console.WriteLine("Ingrese el número de la línea del archivo para definir el Nombre y el DNI");
            Console.Write("Linea: ");
            int linea = int.Parse(Console.ReadLine());
            string Nombre = manejador.stringDesdeArchivo(linea);    //Solamente utilizo la clase Lector de archivos en Nombre y DNI
            int DNI = Convert.ToInt32(manejador.numeroDesdeArchivo(Convert.ToDouble(linea)));

            //a partir de acá se crean por teclado

            Console.Write("Legajo: ");
            int Legajo = manejador.numeroPorTeclado();
            Console.Write("Promedio: ");
            int Prom = manejador.numeroPorTeclado();
            Console.Clear();

            return new AlumnoMuyEstudioso(Nombre, DNI, Legajo, Prom);
        }
    }
    
}
