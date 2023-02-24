using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3
{
    public class Conjunto:Coleccionable, Iterable //ejercicio3 y ejercicio6 - Practica2

    {
        List<object> list = new List<object>();
        public void Agregar(Comparable elemento) 
        {
            if((this.Contiene(elemento)==false))
                list.Add(elemento);
        }
        
        public List<object> contenido() //Me resulta util para poder acceder a la lista que tengo en private
        {
            return list;
        }

        public int Cuantos()
        {
            return list.Count;
        }

        public Comparable Minimo()
        {
            object minimo = list[0];
            for (int i = 0; i <this.Cuantos(); i++)
            {
                if ((((Comparable)minimo).sosMenor((Comparable)list[i])) == false)
                    minimo = list[i];

            }
            return (Comparable)minimo;
        }

        public Comparable Maximo()
        {
            object maximo = list[0];
            for (int i = 0; i < this.Cuantos(); i++)
            {
                if ((((Comparable)maximo).sosMayor((Comparable)list[i])) == false)
                    maximo = list[i];

            }
            return (Comparable)maximo;
        }


        public bool Contiene(Comparable elemento)
        {
            if (elemento is Comparable)
                foreach (Comparable c in list)
                {
                    if (((Comparable)elemento).sosIgual((Comparable)c))
                    {
                        return true;
                    }
                }
            return false;
        }

        public Iterador crear_iterador()    //ejercicio6 - Practica2
        {
            return new Iterador_Conjunto(this);
        }
    }
}
