using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica6
{
    public abstract class FabricaDeComparables       //ejercicio4 - Practica3
    {
        GeneradorDeDatosAleatorios G=new GeneradorDeDatosAleatorios();
        public abstract Comparable crearAleatorio();
        public abstract Comparable crearPorTeclado();
        
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
            

            if (opcion2 == 1)                   //De acuerdo a la opcion2 elegida se creara un comparable aleatorio o por teclado
                return FM.crearAleatorio();
            else
                return FM.crearPorTeclado();                
        }

    }

    
}
