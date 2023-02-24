using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    public class ClaveValor //ejercicio4 - Practica2
    {
        Comparable clave;
        object valor;

        public ClaveValor(Comparable c, object v)
        {
            this.clave = c;
            this.valor = v;
        }
        public Comparable Clave() { return clave; }

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
