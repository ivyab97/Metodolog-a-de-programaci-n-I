using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    public class Diccionario:Coleccionable, Iterable //ejercicio4 y ejercicio6 - Practica2
    {
        Random r=new Random();
        Conjunto Conj=new Conjunto();

        public void Agregar(Comparable clave, Comparable valor) //metodo propio de la clase Diccionario
        {
            ClaveValor elemento = new ClaveValor(clave, valor);
            if (this.valorDe(clave) == null)
                Conj.Agregar(elemento);
            else
                foreach (ClaveValor item in Conj.contenido())
                {
                    if (item.Clave() == clave)
                        item.Valor = valor;
                }
        }

        public object valorDe(Comparable clave)
        {
            foreach (ClaveValor elemento in Conj.contenido())
            {
                if (elemento.Clave() == clave)
                    return elemento.Valor;


            }
            return null;
        }

        public void Agregar(Comparable x) //de la interface Coleccionable
        {
            Comparable N = new Numero(r.Next(1, 10000));
            Agregar(N, x); //metodo propio de la clase Diccionario
            
        }

        public bool Contiene(Comparable x)
        {
            
            foreach (ClaveValor c in Conj.contenido())
            {
                if (x.sosIgual((Comparable)(c.Valor)))
                {
                    return true;
                }
            }
            return false;
        }

        public int Cuantos()
        {
            return Conj.Cuantos();
        }

        public Comparable Maximo()
        {
            return (Comparable)(((ClaveValor)(Conj.Maximo())).Valor);
        }

        public Comparable Minimo()
        {
            return (Comparable)(((ClaveValor)(Conj.Minimo())).Valor);
        }

        public Iterador crear_iterador()
        {
            return new Iterador_Diccionario(this, Conj);
        }
    }
}
