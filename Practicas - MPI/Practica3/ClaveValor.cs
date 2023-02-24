using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3
{
    public class ClaveValor : Comparable//ejercicio4 - Practica2
    {
        Comparable clave;
        object valor;

        public ClaveValor(Comparable c, object v)
        {
            this.clave = c;
            this.valor = v;
        }
        public Comparable Clave() { return clave; }

        public bool sosIgual(Comparable x)
        {
            if ((((ClaveValor)x).Valor == this.Valor))
            {
                return true;
            }
            return false;
        }

        public bool sosMenor(Comparable x)
        {
            return ((Comparable)(this.Valor)).sosMenor((Comparable)(((ClaveValor)(x)).Valor));
        }

        public bool sosMayor(Comparable x)
        {
            return ((Comparable)(this.Valor)).sosMayor((Comparable)(((ClaveValor)(x)).Valor));
        }

        public void toString()
        {
            Console.WriteLine("Hola");
        }

        public object Valor
        {
            get{ 
                return valor;
            }
            set{ 
                valor=value;
            }
        }



    }
}
