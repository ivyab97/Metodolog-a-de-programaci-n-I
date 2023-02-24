using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    //ejercicio4 - Practica1
    public class Pila : Coleccionable, Iterable //ejercicio6 - Practica2
    {
        private List<Comparable> _pila = new List<Comparable>();

        public void Agregar(Comparable x)
        {
            _pila.Add(x);
        }

        public bool Contiene(Comparable x)
        {
            foreach (Comparable c in _pila)
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
            return _pila.Count;
        }

        public Comparable Maximo()
        {
            Comparable maximo = _pila[0];
            for (int i = 0; i < _pila.Count; i++)
            {
                if ((maximo.sosMayor(_pila[i])) == false)
                    maximo = _pila[i];

            }
            return maximo;
        }

        public Comparable Minimo()
        {
            Comparable minimo = _pila[0];
            for (int i = 0; i < _pila.Count; i++)
            {
                if ((minimo.sosMenor(_pila[i])) == false)
                    minimo = _pila[i];

            }
            return minimo;
        }
        public Comparable desapilar(int i)
        {
            if (_pila.Count > 0)
            {
                Comparable ultimo = this._pila[i];
                return ultimo;
            }

            return null;
        }

        public Iterador crear_iterador()        //devuelve una instancia Iterador (ejercicio6 - Practica2)
        {
            return new Iterador_Pila(this);
        }
    }
}
