using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica5
{
    public interface Iterador   //ejercicio6 - Practica2
    {
        void Primero();
        void Siguiente();
        object Actual();
        bool Fin();

    }
    public interface Iterable
    {
        Iterador crear_iterador();
    }

    

    public class Iterador_Cola : Iterador
    {
        private Cola cola;
        private int cant_elementos;
        private int indice;
        public Iterador_Cola(Cola c)
        {
            cola = c;
            cant_elementos = c.Cuantos();
            indice = 0; //lo seteo, una cola empieza por el primer elemento ingresado
        }
        public object Actual()
        {
            return cola.desencolar(indice);
        }

        public bool Fin()
        {
            return indice >= (cant_elementos);
        }

        public void Primero()  //reset
        {
            indice = 0;
        }

        public void Siguiente()
        {
            indice++;
        }
    }

}
