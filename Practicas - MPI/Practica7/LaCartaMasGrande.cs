using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica7
{
    public class LaCartaMasGrande : JuegoDeCartas   //ejercicio4_practica6
    {
         
        protected override void mesclarMazo()       //Se simula mesclar la carta
        {
            Console.WriteLine("-Mesclando mazo \n");
        }
        protected override void repartirCartasIniciales()   //Se reparte una carta a cada jugador. A la vez, se descartan dos cartas del mazo
        {
            Console.WriteLine("-Repartiendo cartas \n");
            cartas_alumnoA.Add(Mazo_cartas.cartasEnMazo()[G.numeroAleatorio((Mazo_cartas.cartasEnMazo().Count - 1))]);
            Mazo_cartas.cartasEnMazo().Remove(cartas_alumnoA[0]);

            cartas_alumnoB.Add(Mazo_cartas.cartasEnMazo()[G.numeroAleatorio((Mazo_cartas.cartasEnMazo().Count - 1))]);
            Mazo_cartas.cartasEnMazo().Remove(cartas_alumnoB[0]);
        }
        protected override void jugarCartas()   //Los jugadores muestran la carta que tienen
        {
            Console.WriteLine("-Los jugadores muestran sus cartas:\n");
            Console.WriteLine(A_Alum.GetNombre() + " tiene la carta " + cartas_alumnoA[0].numero_carta() + " de " + cartas_alumnoA[0].palo_carta());
            Console.WriteLine(B_Alum.GetNombre() + " tiene la carta " + cartas_alumnoB[0].numero_carta() + " de " + cartas_alumnoB[0].palo_carta());
        }
        protected override bool chequearSiExiteGanador()    //Se comprueba si alguien ganó la ronda, mediante el número de la carta
        {
            if (cartas_alumnoA[0].numero_carta()== cartas_alumnoB[0].numero_carta())    //si el número de ambas cartas es igual; empate 
            {
                Console.WriteLine("\n-Empate!");
            }
            if (cartas_alumnoA[0].numero_carta() > cartas_alumnoB[0].numero_carta())    //si el número de la carta del alumno A es mayor; gana la ronda
            {
                puntajeA++;     //Se le suma puntaje
                Console.WriteLine("\n-Ronda ganada por " + A_Alum.GetNombre());
            }

            if(cartas_alumnoA[0].numero_carta() < cartas_alumnoB[0].numero_carta())
            {
                puntajeB++;     //Se le suma puntaje
                Console.WriteLine("\n-Ronda ganada por " + B_Alum.GetNombre());
            }

            if (puntajeA == 5)           //Si se llegó al puntaje de 5, se declara un ganador
            {
                GanadorA = true;
                return true;
            }
            if (puntajeB == 5)
            {
                GanadorB = true;
                return true;
            }

            Console.WriteLine("\n----------------------------------------------------------------");
            Console.WriteLine("Nueva Ronda");
            Console.WriteLine("----------------------------------------------------------------");

            Mazo_cartas.cartasEnMazo().Add(cartas_alumnoA[0]);      //Los alumnos devuelven las cartas al mazo
            Mazo_cartas.cartasEnMazo().Add(cartas_alumnoB[0]);
            cartas_alumnoA.Clear();
            cartas_alumnoB.Clear();

            return false;           //Si no hay ganador
        }
        
    }
}
