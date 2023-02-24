using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica6
{
    public class Funciones_Main
    {
        public static string Nombre_azar()      //helper (ayuda) ejercicio12 - Practica1
        {
            Random r = new Random();
            List<string> l = new List<string>();

            l.Add("Ivan");
            l.Add("Ian");
            l.Add("Lucas");
            l.Add("Esteban");
            l.Add("Marcos");
            l.Add("Adrian");
            l.Add("Maria");
            l.Add("Teresa");
            l.Add("Lourdes");
            l.Add("Estefania");
            l.Add("Marcela");
            l.Add("Celia");
            l.Add("Alfonso");
            l.Add("Francisca");
            l.Add("Ivana");
            l.Add("Ana");
            l.Add("Juana");
            l.Add("Agustina");
            l.Add("Macarena");
            l.Add("Patricio");
            l.Add("Leonel");
            l.Add("Brenda");
            l.Add("Brisa");
            l.Add("Belen");
            l.Add("Gustavo");
            l.Add("Rodolfo");
            l.Add("Roberto");
            l.Add("Kevin");
            l.Add("Nelson");
            l.Add("Gaston");

            return l[r.Next(0, 29)];
        }

       
        public static void informarAlumnos(Coleccionable o)  //Modificado para adaptarlo al ejercicio10 - Practica2 
        {
            Console.WriteLine("Los alumnos Maximo y minimo son:");
           ((Alumno)(o.Maximo())).toString();
           ((Alumno)(o.Minimo())).toString();
        }



        public static void imprimirElementos(Coleccionable Cll) //ejercicio7 - Practica2
        {
            Iterador it = Cll.crear_iterador();

            while (!it.Fin())
            {
                ((Comparable)(it.Actual())).toString();
                it.Siguiente();
            }
        }

        public static void cambiarEstrategia(Coleccionable CL, StrategyComparer estrategia)  //Ejercicio 9 - Practica 2
        {
            Iterador It = CL.crear_iterador();

            while (!It.Fin())
            {
                ((Alumno)(It.Actual())).SetEstartegiaDeComparacion(estrategia);
                It.Siguiente();
            }
        }


        public static void llenar(Coleccionable C, int opcion)  //ejercicio6_practica3
        {
            Console.Write("Ingrese 1 para crear el comparable de forma aleatoria, o 2 para crearlo por teclado: ");
            int opcion2=int.Parse(Console.ReadLine());
            int cont = 20;
                       
                while (cont > 0)
                {
                    Comparable Comp = FabricaDeComparables.Crear_comparables(opcion, opcion2);
                    C.Agregar(Comp);
                    cont--;
                }
        }

        public static void informar(Coleccionable C, int opcion)  //ejercicio6_practica3
        {
            Console.WriteLine("Cantidad de Comparables: "+C.Cuantos());
            Console.WriteLine("Elemento maximo y minimo: ");
            C.Minimo().toString();
            C.Maximo().toString();
            Console.WriteLine("Ingrese el elemento a comparar: ");
            Comparable comp= FabricaDeComparables.Crear_comparables(opcion, 2);
            if (C.Contiene(comp))
            {
                Console.WriteLine("El elemento leido esta en la coleccion");
            }
            if (!(C.Contiene(comp)))
            {
                Console.WriteLine("El elemento leido no esta en la coleccion");
            }
        }

        public static void ejercicio4_practica4()       //ejercicio4_practica4
        {
            //Main

            Teacher teach = new Teacher();

            FabricaDeAlumnos Fab = new FabricaDeAlumnos();

            for (int i = 0; i < 10; i++)
            {
                Alumno A = (Alumno)Fab.crearAleatorio();
                Alumno Ame = (AlumnoMuyEstudioso)Fab.crearAleatorioAlumnoME();

                AdapterAlumno AAd = new AdapterAlumno(A);
                AdapterAlumno AAdme = new AdapterAlumno(Ame);
                teach.goToClass(AAd);
                teach.goToClass(AAdme);
            }
            teach.teachingAClass();
        }


        public static void ejercicio8_practica4()       //ejercicio8_practica4  (ejercicio4 modificado)
        {
            //Main

            Teacher teach = new Teacher();

            FabricaDeAlumnos Fab = new FabricaDeAlumnos();

            for (int i = 0; i < 10; i++)
            {
                Alumno A = (Alumno)Fab.crearAleatorio();          //Alumno "normal"
                Alumno Ame = (AlumnoMuyEstudioso)Fab.crearAleatorioAlumnoME();  //Alumno Muy Estudioso
               
                Nota_letras nota_Letras1 = new Nota_letras(A);              //decoro al Alumno "normal"
                Print_Legajo print_Legajo1 = new Print_Legajo(nota_Letras1);
                Prom_Apro_Desapro prom_Apro_Desapro1 = new Prom_Apro_Desapro(print_Legajo1);
                Cuadro_aster cuadro_Aster1 = new Cuadro_aster(prom_Apro_Desapro1);

                Nota_letras nota_Letras2 = new Nota_letras(Ame);            //decoro al AlumnoMuyEstudioso 
                Print_Legajo print_Legajo2 = new Print_Legajo(nota_Letras2);
                Prom_Apro_Desapro prom_Apro_Desapro2 = new Prom_Apro_Desapro(print_Legajo2);
                Cuadro_aster cuadro_Aster2 = new Cuadro_aster(prom_Apro_Desapro2);


                AdapterAlumno AAd = new AdapterAlumno(cuadro_Aster1);          //Adaptos los dos tipos de Alumnos a Student
                AdapterAlumno AAdme = new AdapterAlumno(cuadro_Aster2);

                

                teach.goToClass(AAd);
                teach.goToClass(AAdme);
            }
            teach.teachingAClass();
        }

        public static void ejercicio2_practica5()       //ejercicio2_practica5 implementando el patron Proxy
        {
            //Main
            
            GeneradorDeDatosAleatorios g=new GeneradorDeDatosAleatorios();

            Teacher teach = new Teacher();

            for (int i = 0; i < 10; i++)
            {
                IComponenteAlumno A = (IComponenteAlumno)FabricaDeComparables.Crear_comparables(3, 1);  //AlumnoProxy
                IComponenteAlumno AME = (IComponenteAlumno)FabricaDeComparables.Crear_comparables(4, 1); //AlumnoMuyEstudiosoProxy

                //adapto a student los AlumnoProxy

                AdapterAlumno adapterAlumno = new AdapterAlumno(A);
                AdapterAlumno adapterAlumnoME = new AdapterAlumno(AME);

                teach.goToClass(adapterAlumno);
                teach.goToClass(adapterAlumnoME);
            }
            teach.teachingAClass();
        }

        public static void ejercicio10_practica5()      //ejercicio10_practica5 usando el patron Command
        {
            //Main

            Cola col=new Cola();       //invocador
            Aula aula=new Aula();       //receptor

            //seteo las ordenes

            col.setOrdenInicio(new OrdenInicio(aula));
            col.setOrdenLlegaAlumno(new OrdenLlegaAlumno(aula));
            col.setOrdenAulaLlena(new OrdenAulaLlena(aula));

            //lleno el coleccionable con Alumno y AlumnoMuyEstudioso (ambos sin decorador)

            llenar(col, 1);
            llenar(col, 5);

        }

        public static void ejercicio2_practica6()       //ejercicio2_practica6 implementando el patron Composite
        {
            //Main

            GeneradorDeDatosAleatorios g = new GeneradorDeDatosAleatorios();
            IComponenteAlumno alumnoCompuesto = new AlumnoCompuesto();      //Compuesto de alumno
            Teacher teach = new Teacher();

            for (int i = 0; i < 10; i++)
            {
                IComponenteAlumno A = (IComponenteAlumno)FabricaDeComparables.Crear_comparables(3, 1);  //AlumnoProxy
                IComponenteAlumno AME = (IComponenteAlumno)FabricaDeComparables.Crear_comparables(4, 1); //AlumnoMuyEstudiosoProxy

                //adapto a student los AlumnoProxy

                AdapterAlumno adapterAlumno = new AdapterAlumno(A);
                AdapterAlumno adapterAlumnoME = new AdapterAlumno(AME);

                teach.goToClass(adapterAlumno);
                teach.goToClass(adapterAlumnoME);
            }
            for (int i = 0; i < 5; i++)     //Agrego hijos al Compuesto de alumno
            {
                IComponenteAlumno A = (IComponenteAlumno)FabricaDeComparables.Crear_comparables(3, 1);  //AlumnoProxy
                ((AlumnoCompuesto)alumnoCompuesto).agregarHijo(A);                
            }

            AdapterAlumno adapterAlumnoCompuesto = new AdapterAlumno(alumnoCompuesto); //Adapto el compuesto de alumno
            teach.goToClass(adapterAlumnoCompuesto);


            teach.teachingAClass();
        }

        public static void ejercicio6_practica6()       //ejercicio6_practica6 implementando el patron Template Method
        {
            //Main

            int opcion;     //¿A que quiere jugar?

            IComponenteAlumno Alum_A = new Alumno("Alfonso", 43443444, 34544, 9);       //se instancian los alumnos
            IComponenteAlumno Alum_B = new Alumno("Sergio", 34554555, 43545, 8);

            JuegoDeCartas juegoDeCartas1 = new Adivina_La_carta();              //se instancian los dos juegos de cartas
            JuegoDeCartas juegoDeCartas2 = new LaCartaMasGrande();

            Console.WriteLine("¿A que quiere jugar?");                  //¿A que quiere jugar?
            Console.WriteLine("Adivina la carta - Presione 1");     //El ganador es el que primero llega a un puntaje de 2
            Console.WriteLine("La carta más grande - Presione 2");    //El ganador es el que primero llega a un puntaje de 5

            opcion = int.Parse(Console.ReadLine());

            Console.WriteLine("----------------------------------------------------------------");

            if (opcion==1) 
            {
                Console.WriteLine("\n-El ganador es " + ((Alumno)juegoDeCartas1.empezarAJugar(Alum_A, Alum_B)).GetNombre());
            }
            if (opcion==2)
            {
                Console.WriteLine("\n-El ganador es " + ((Alumno)juegoDeCartas2.empezarAJugar(Alum_A, Alum_B)).GetNombre());
            }
        }

    }
}
