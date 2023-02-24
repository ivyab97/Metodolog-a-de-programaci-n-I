using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    public class Conjunto:Coleccionable, Iterable //ejercicio3 y ejercicio6 - Practica2

    {
        List<object> list = new List<object>();
        public void agregar(object elemento)   //metodo propio de la clase Conjunto
        {
            if((this.contiene(elemento)==false))
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

        public void Agregar(Comparable x)   //No pude hacer uso de este metodo, ya que esta clase necesita un metodo (Agregar) pero uno que reciba como parametro un objeto
        {
            Console.WriteLine("No no");
        }

        public bool contiene(object elemento)
        {   
            if(elemento is Comparable)
                foreach (Comparable c in list)
                {
                    if (((Comparable)elemento).sosIgual((Comparable)c))
                    {
                        return true;
                    }
                }
            if(elemento is ClaveValor)
                foreach (ClaveValor c in list)
                {
                    if ((((ClaveValor)elemento).Valor==c.Valor))
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

        public bool Contiene(Comparable x)
        {
            Console.WriteLine("Contiene");
            return true;
        }
    }
}
