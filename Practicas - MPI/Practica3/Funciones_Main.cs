using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3
{
    public class Funciones_Main
    {



        public static void llenaNumeros(Coleccionable o)	//ejercicio5 - Practica1
        {
            Random al_azar = new Random();
            int cont = 20;
            while (cont > 0)
            {
                Numero n = new Numero(al_azar.Next(20));
                o.Agregar(n);
                cont--;
            }
        }


        public static void informarNumero(Coleccionable o)  //ejercicio6 - Practica1
        {
            Console.WriteLine("Ingrese un numero: ");
            int val = int.Parse(Console.ReadLine());

            Numero n = new Numero(val);
            if (o.Contiene(n))
                Console.WriteLine("El elemento leido esta en la coleccion");
            else
                Console.WriteLine("El elemento leido no esta en la coleccion");


            Console.WriteLine("El coleccionable tiene " + o.Cuantos() + " elementos");
            Console.WriteLine("El valor maximo es " + (((Numero)(o.Maximo())).getValor()));
            Console.WriteLine("El valor minimo es " + (((Numero)(o.Minimo())).getValor()));
        }


        public static void ejercicio7() //ejercicio7 - Practica1 - en main
        {
            Cola c = new Cola();
            Pila p = new Pila();

            llenaNumeros(c);
            llenaNumeros(p);

            informarNumero(c);
            informarNumero(p);
        }

        public static void ejercicio9() //ejercicio9 - Practica1 - en main
        {
            Cola c = new Cola();
            Pila p = new Pila();

            llenaNumeros(c);
            llenaNumeros(p);

            ColeccionMultiple multiple = new ColeccionMultiple(p, c);

            informarNumero(c);
            informarNumero(p);
            informarNumero(multiple);
        }

        //ejercicio10 ???

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

        public static void llenaPersonas(Coleccionable o)	//ejercicio12 - Practica1
        {
            Random R = new Random();
            int cont = 20;
            while (cont > 0)
            {
                Persona Per = new Persona(Nombre_azar(), R.Next(0,48000000));
                o.Agregar(Per);
                cont--;
            }
        }

        public static void informarPersonas(Coleccionable o)  //ejercicio13 - Practica1
        {
            Console.WriteLine("Ingrese el numero de DNI de la persona: ");
            int val = int.Parse(Console.ReadLine());
            Persona human = new Persona("Human", val);

            if (o.Contiene(human))
                Console.WriteLine("La persona esta en la coleccion");
            else
                Console.WriteLine("La persona no esta en la coleccion");


            Console.WriteLine("El coleccionable tiene " + o.Cuantos() + " Personas");
            Console.WriteLine("El DNI maximo es " + (((Persona)(o.Maximo())).getDNI()));
            Console.WriteLine("El DNI minimo es " + (((Persona)(o.Minimo())).getDNI()));
        }

        public static void ejercicio13() //ejercicio13 - Practica1 - en main
        {
            Pila p = new Pila();
            Cola c = new Cola();

            llenaPersonas(p);
            llenaPersonas(c);

            ColeccionMultiple multiple = new ColeccionMultiple(p, c);

            informarPersonas(multiple);
        }

        public static void llenaAlumnos(Coleccionable o)      //Practica_2 - ejercicio_2 (Practica_1 - ejercicio16 con modificacion)
        {
            Random R = new Random();
            StrategyComparer estrategia = new DNIcomparer();    //al aplicar esta estrategia y gracias al if que agregamos, se podra agregar un Alumno siempre que                                                    este no se repita (teniendo en cuenta el dni)
            int cont =5 ;
                while (cont > 0)
                {
                    Alumno Alum = new Alumno(Nombre_azar(), R.Next(0, 48000000), R.Next(0, 50000), R.Next(0, 10));
                    if(o is Diccionario)
                    {   
                        o.Agregar(Alum);
                        cont--;
                    }
                        
                    if(!(o is Diccionario))
                        if ((o.Contiene(Alum))==false)
                            { 
                                o.Agregar(Alum);
                                cont--;
                            }
                }
        }

        public static void ejercicio17() //ejercicio17 - Practica1 - en main
        {
            Pila p = new Pila();
            Cola c = new Cola();

            llenaAlumnos(p);
            llenaAlumnos(c);

            ColeccionMultiple multiple = new ColeccionMultiple(p, c);

            informarPersonas(multiple);
        }


        public static void informarAlumnos(Coleccionable o)  //Modificado para adaptarlo al ejercicio10 - Practica2 
        {
            Console.WriteLine("Los alumnos Maximo y minimo son:");
           ((Alumno)(o.Maximo())).toString();
           ((Alumno)(o.Minimo())).toString();
        }


        public static void ejercicio18() //ejercicio18 - Practica1 - en main
        {
            Pila p = new Pila();
            Cola c = new Cola();

            llenaAlumnos(p);
            llenaAlumnos(c);

            ColeccionMultiple multiple = new ColeccionMultiple(p, c);

            informarAlumnos(multiple);
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

        public static void ejercicio8_Practica2()   //ejercicio8 - Practica2 - en Main
        {
            //Main
            Pila p = new Pila();
            Cola c = new Cola();
            Conjunto C_ = new Conjunto();
            Diccionario Dic = new Diccionario();

            llenaAlumnos(p);
            llenaAlumnos(c);
            llenaAlumnos(C_);
            llenaAlumnos(Dic);

            imprimirElementos(p);
            imprimirElementos(c);
            imprimirElementos(C_);
            imprimirElementos(Dic);
            Console.WriteLine("----------------------");
        }

        public static void cambiarEstrategia(Coleccionable CL, StrategyComparer estrategia)  //Ejercicio 9 - Practica 2
        {
            Iterador It = CL.crear_iterador();

            while (!It.Fin())
            {
                ((Alumno)(It.Actual())).ChangeStrategy(estrategia);
                It.Siguiente();
            }
        }

        public static void ejercicio10_Practica2()  //ejercicio10 - Practica2 - en Main
        {
            Pila p = new Pila();

            DNIcomparer DNI_estrategia=new DNIcomparer();
            Legajo_comparer Legajo_estrategia=new Legajo_comparer();
            Promedio_comparer Promedio_estrategia=new Promedio_comparer();

            //No implemente la estrategia de comparacion por NOMBRE porque veia poca practicidad en esta, 
            //debido a que estamos hablando de minimo y maximo, es mas practico aplicarlo a esas variables numericas

            llenaAlumnos(p);

            cambiarEstrategia(p, DNI_estrategia);
            Console.WriteLine("Comparacion por DNI");
            informarAlumnos(p);

            Console.WriteLine("----------------------------------------------");

            cambiarEstrategia(p, Legajo_estrategia);
            Console.WriteLine("Comparacion por Legajo");
            informarAlumnos(p);

            Console.WriteLine("----------------------------------------------");

            cambiarEstrategia(p, Promedio_estrategia);
            Console.WriteLine("Comparacion por Promedio");
            informarAlumnos(p);
            
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

        public static void ejercicios9_17_practica1_unificados()  //ejercicio6_practica3    //ejercicio9_practica3
        {
            Cola c = new Cola();
            Pila p = new Pila();
            ColeccionMultiple multiple = new ColeccionMultiple(p, c);

            Console.WriteLine("Si desea llenar con Alumnos teclee (1), si desea con Numeros teclee (2), si desea con Vendedor teclee (3)");
            int opcion = int.Parse(Console.ReadLine());
            Console.WriteLine("Llenar_Cola--------------------------------");
            llenar(c, opcion);
            Console.WriteLine("Llenar_Pila--------------------------------");
            llenar(p, opcion);
            Console.WriteLine("Llenar_Multiple--------------------------------");
            llenar(multiple, opcion);
            Console.WriteLine("Informar_cola--------------------------------");
            informar(c, opcion);
            Console.WriteLine("Informar_pila--------------------------------");
            informar(p, opcion);
            Console.WriteLine("Informar_multiple--------------------------------");
            informar(multiple, opcion);
        }

        public static void jornadaDeVentas(Coleccionable vendedores)    //ejercicio13_practica3
        {
            GeneradorDeDatosAleatorios G=new GeneradorDeDatosAleatorios();
            Iterador it = vendedores.crear_iterador();

            while (!it.Fin())
            {
                for (int i = 0; i < 20; i++)
                {
                    double monto = G.numeroAleatorio(7000);
                    ((Vendedor)it.Actual()).venta(monto);
                }
                it.Siguiente();
            }
        }

        public static void ejercicio14_practica3()
        {
            Coleccionable p = new Pila();
            llenar(p, 3);
            Iterador Iter = p.crear_iterador();
            Gerente gerente = new Gerente();

            while (!Iter.Fin())
            {
                ((Vendedor)(Iter.Actual())).AddObserver(gerente);   //hago que gerente sea observador de todos los vendedores
                Iter.Siguiente();
            }
            jornadaDeVentas(p);
            Console.WriteLine("-----------------------------");
            Console.WriteLine("-----------------------------");
            gerente.cerrar();
        }
    
    }
}
