using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
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

    public class Iterador_Pila : Iterador
    {
        private Pila pila;
        private int cant_elementos;
        private int indice;
        public Iterador_Pila(Pila p)
        {
            pila = p;
            cant_elementos = p.Cuantos();
            indice = p.Cuantos()-1; //lo seteo, una pila empieza por el ultimo elemento ingresado
        }
        public object Actual()
        {
            return pila.desapilar(indice);
        }

        public bool Fin()
        {
            return indice<=-1; 
        }

        public void Primero()  //reset
        {
            indice=(cant_elementos-1);
        }

        public void Siguiente()
        {
            indice--;
        }
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

    public class Iterador_Conjunto : Iterador
    {   
        private Conjunto conj;
        private int cant_elementos;
        private int indice;

        public Iterador_Conjunto(Conjunto co)
        {
            conj = co;
            cant_elementos = co.contenido().Count();
            indice=0;
        }
        public object Actual()
        {
            return (conj.contenido())[indice];
        }

        public bool Fin()
        {
            return indice >= (cant_elementos);
        }

        public void Primero()
        {
            indice=0;
        }

        public void Siguiente()
        {
            indice++;
        }
    }

    public class Iterador_Diccionario : Iterador
    {
        private Diccionario diccionario;
        private Conjunto C;
        private int cant_elementos;
        private int indice;

        public Iterador_Diccionario(Diccionario d, Conjunto cj)
        {
            this.diccionario = d;
            C = cj;
            cant_elementos = d.Cuantos();
            indice = 0;
        }
        public object Actual()
        {
            return ((ClaveValor)((C.contenido())[indice])).Valor; //en este caso, se retornara el objeto que se encuentre en la variable (Valor) del objeto (ClaveValor)
        }

        public bool Fin()
        {
            return indice >= (cant_elementos);
        }

        public void Primero()
        {
            indice=0;
        }

        public void Siguiente()
        {
            indice++;
        }
    }
}
