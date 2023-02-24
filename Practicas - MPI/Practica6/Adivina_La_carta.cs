using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica6
{
    public class Adivina_La_carta : JuegoDeCartas   //ejercicio4_practica6
    {       
        protected override void mesclarMazo()       //Se simula mesclar el mazo
        {
            Console.WriteLine("-Mesclando mazo \n");
        }
        protected override void repartirCartasIniciales()   //Se reparte una carta a cada jugador. A la vez, se descartan dos cartas del mazo
        {
            Console.WriteLine("-Repartiendo cartas \n");
            cartas_alumnoA.Add(Mazo_cartas.cartasEnMazo()[G.numeroAleatorio((Mazo_cartas.cartasEnMazo().Count-1))]);
            Mazo_cartas.cartasEnMazo().Remove(cartas_alumnoA[0]);

            cartas_alumnoB.Add(Mazo_cartas.cartasEnMazo()[G.numeroAleatorio((Mazo_cartas.cartasEnMazo().Count-1))]);
            Mazo_cartas.cartasEnMazo().Remove(cartas_alumnoB[0]);

        }
        protected override void jugarCartas()   //Los jugadores tratan de adivinar el numero de la carta de su oponente
        {
            Console.WriteLine(A_Alum.GetNombre()+", trata de adivinar el número de la carta de "+B_Alum.GetNombre());
            int numeroA = G.numeroAleatorio(12);
            if (numeroA == cartas_alumnoB[0].numero_carta())
            {
                Console.WriteLine("Acertó");
                GanadorA = true;
            }
                
            if (!(numeroA == cartas_alumnoB[0].numero_carta()))
            {
                Console.WriteLine("No acertó");
                GanadorA = false;
            }

            Console.WriteLine(B_Alum.GetNombre()+", trata de adivinar el número de la carta de "+A_Alum.GetNombre());
            int numeroB = G.numeroAleatorio(12);
            if (numeroB == cartas_alumnoA[0].numero_carta())
            {
                Console.WriteLine("Acertó");
                GanadorB = true;
            }
                
            if (!(numeroB == cartas_alumnoA[0].numero_carta()))
            {
                Console.WriteLine("No acertó");
                GanadorB = false;
            }

            Mazo_cartas.cartasEnMazo().Add(cartas_alumnoA[0]);      //Los alumnos devuelven las cartas al mazo
            Mazo_cartas.cartasEnMazo().Add(cartas_alumnoB[0]);
            cartas_alumnoA.Clear();     
            cartas_alumnoB.Clear();

        }

        protected override bool chequearSiExiteGanador()    //Se comprueba si hay ganador
        {
            if (GanadorA==GanadorB)     //Si ambos adivinaron, o si no. Empataron
            {
                Console.WriteLine("\n-Empate!");
            }

            if (GanadorA==true)     //Si el alumno A gano la ronda, se le suma puntaje
            {
                puntajeA++;
            }
            if (GanadorB == true)     //Si el alumno B gano la ronda, se le suma puntaje
            {
                puntajeB++;
            }

            if(puntajeA==2)     //Si uno de los alumnos llega al puntaje de 2, gana la partida
            {
                return true;
            }
            if (puntajeB == 2)
            {
                return true;
            }

            //Si nadie llega al puntaje de dos, se comienza otra partida

            Console.WriteLine("\n----------------------------------------------------------------");
            Console.WriteLine("Nueva Ronda");
            Console.WriteLine("----------------------------------------------------------------");

            return false;   //Si no hay ganador
        }
    }
}
