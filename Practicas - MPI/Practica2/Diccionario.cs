using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    public class Diccionario:Coleccionable, Iterable //ejercicio4 y ejercicio6 - Practica2
    {
        Conjunto Conj=new Conjunto();

        public void Agregar(Comparable clave, object valor) //metodo propio de la clase Diccionario
        {
            ClaveValor elemento = new ClaveValor(clave, valor);
            if (this.valorDe(clave) == null)
                Conj.agregar(elemento);
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
            //no lo puede implementar, andate a la concha de tu madre
        }

        public bool Contiene(Comparable x)
        {
            return Conj.contiene(x);
        }

        public int Cuantos()
        {
            return Conj.Cuantos();
        }

        public Comparable Maximo()
        {
            return Conj.Maximo();
        }

        public Comparable Minimo()
        {
            return Conj.Minimo();
        }

        public Iterador crear_iterador()
        {
            return new Iterador_Diccionario(this, Conj);
        }
    }
}
