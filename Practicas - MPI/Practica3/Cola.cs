using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3
{
    //ejercicio4 - Practica1
    public class Cola : Coleccionable, Iterable
    {
        private List<Comparable> _cola = new List<Comparable>();

        public void Agregar(Comparable x)
        {
            _cola.Add(x);
        }

        public bool Contiene(Comparable x)
        {
            foreach (Comparable c in _cola)
            {
                if (x.sosIgual(c))
                {
                    return true;
                }
            }
            
            return false;
        }

        public int Cuantos()
        {
            return _cola.Count;
        }

        public Comparable Maximo()
        {
            Comparable maximo = _cola[0];
            for (int i = 0; i < _cola.Count; i++)
            {
                if ((maximo.sosMayor(_cola[i])) == false)
                    maximo = _cola[i];

            }
            return maximo;
        }

        public Comparable Minimo()
        {
            Comparable minimo = _cola[0];
            for (int i = 0; i < _cola.Count; i++)
            {
                if ((minimo.sosMenor(_cola[i])) == false)
                    minimo = _cola[i];

            }
            return minimo;
        }

        public Comparable desencolar(int i)
        {
            Comparable primero = this._cola[i];
            return primero;
        }

        public Iterador crear_iterador()    //ejercicio6 - Practica2
        {
            return new Iterador_Cola(this);
        }
    }

}
