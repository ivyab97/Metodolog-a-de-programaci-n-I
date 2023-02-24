using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica6
{
    public abstract class JuegoDeCartas //ejercicio3_practica6
    {
       protected MazoDeCartas Mazo_cartas = new MazoDeCartas();     //Es la clase que contiene las cartas

       protected IComponenteAlumno A_Alum;      //Los dos Alumnos
       protected IComponenteAlumno B_Alum;

       protected GeneradorDeDatosAleatorios G = new GeneradorDeDatosAleatorios();   //Es como un random, para simular el "azar" del juego

       protected List<Cartas> cartas_alumnoA = new List<Cartas>();      //Estas listas se usan para almacenar las cartas que tienen los jugadores
       protected List<Cartas> cartas_alumnoB = new List<Cartas>();

       protected bool GanadorA;     //Para determinar quien es el ganador
       protected bool GanadorB;

       protected int puntajeA;      //Para almacenar el puntaje
       protected int puntajeB;
        public IComponenteAlumno empezarAJugar(IComponenteAlumno A, IComponenteAlumno B)    //Esqueleto del algoritmo
        {
            A_Alum = A;         //Se instancian los alumnos
            B_Alum = B;

            puntajeA = 0;       //Los puntajes de los jugadores en un principio
            puntajeB = 0;
                
            GanadorA = false;   //Todavia nadie es ganador
            GanadorB = false;

            do          //Comienza el bucle hasta que alguien llegue al puntaje requerido en cualquier juego de cartas (ganador)
            {
                mesclarMazo();
                repartirCartasIniciales();
                jugarCartas();

            } while (!chequearSiExiteGanador());

            Console.WriteLine("\n----------------------------------------------------------------");
            Console.WriteLine("-El puntaje final es: ");
            Console.WriteLine(A_Alum.GetNombre() + " " + puntajeA);
            Console.WriteLine(B_Alum.GetNombre() + " " + puntajeB+ "\n");

                if (GanadorA==true)             //Se retorna al alumno ganador
            {
                return A_Alum;
            }
            else
            {
                return B_Alum;
            }
            
        }
        protected abstract void mesclarMazo();          //Metodos "pasos"
        protected abstract void repartirCartasIniciales();
        protected abstract void jugarCartas();
        protected abstract bool chequearSiExiteGanador();
    }
}
