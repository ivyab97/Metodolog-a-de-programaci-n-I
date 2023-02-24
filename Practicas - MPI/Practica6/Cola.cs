using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica6
{
    public class Cola : Coleccionable, Iterable, Ordenable  //ejercicio9_practica5      //Invocador
    {
        OrdenLlegaAlumno alum_llega;
        OrdenInicio aula_inicio;
        OrdenAulaLlena aula_llena;
        
        private List<Comparable> _cola = new List<Comparable>();

        public void Agregar(Comparable x)
        {
            _cola.Add(x);

            if (_cola.Count==1)
            {
                aula_inicio.ejecutar();                
            }
            if (aula_inicio!=null)
            {
                alum_llega.ejecutar(x);
                if (_cola.Count==40)
                {
                    aula_llena.ejecutar();
                }
            }
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

        public void setOrdenInicio(OrdenEnAula1 o)
        {
            aula_inicio = (OrdenInicio)o;
        }

        public void setOrdenLlegaAlumno(OrdenEnAula2 o)
        {
            alum_llega = (OrdenLlegaAlumno)o;
        }

        public void setOrdenAulaLlena(OrdenEnAula1 o)
        {
            aula_llena = (OrdenAulaLlena)o;
        }
    }

}
