using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica7
{
    public abstract class FabricaDeComparables
    {
        protected ManejadorObtencionDeDatos manejador;      //ejercicio2 - practica7
        public abstract Comparable crearAleatorio();
        public abstract Comparable crearPorTeclado();
        public abstract Comparable crearPorArchivo();       //ejercicio3 - practica7
        
        public static Comparable Crear_comparables(int opcion1, int opcion2)
        {
            

            FabricaDeComparables FM=null;     //de acuerdo a la opcion1 elegida se usara una FabricaDeAlumnos, una FabricaDeNumeros, una FabricaDeVendedores, una FabricaDeAlumnoProxy o una FabricaDeAlumnoMuyEstudiosoProxy
            if (opcion1 == 1)
                FM = new FabricaDeAlumnos();
            if (opcion1 == 2)
                FM = new FabricaDeNumeros();
            if (opcion1 == 3)
                FM = new FabricaDeAlumnoProxy();
            if (opcion1 == 4)
                FM = new FabricaDeAlumnoMuyEstudiosoProxy();
            if (opcion1 == 5)
                FM = new FabricaDeAlumnoMuyEstudioso();
            

            if (opcion2 == 1)                   //De acuerdo a la opcion2 elegida se creara un comparable aleatorio, por teclado o por archivo
                return FM.crearAleatorio();
            if (opcion2 == 2)
                return FM.crearPorTeclado();
            else
                return FM.crearPorArchivo();    //ejercicio3 - practica7
        }

        public void setManejador(ManejadorObtencionDeDatos M)      //ejercicio2 - practica7
        {
            manejador= M;
        }

        public ManejadorObtencionDeDatos cadenaDeResponsabilidades()      //ejercicio2 - practica7  //cadena de responsabilidades + Patron Singleton (ejercecio4 - practica7)
        {
            ManejadorObtencionDeDatos man1 = LectorDeDatos.Get_instanciaUnica(null);
            ManejadorObtencionDeDatos man2 = GeneradorDeDatosAleatorios.Get_instanciaUnica(man1);
            ManejadorObtencionDeDatos man3 = LectorDeArchivos.Get_instanciaUnica(man2);
            return man3;
        }
    }

    
}
