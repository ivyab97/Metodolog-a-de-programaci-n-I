using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica7
{
    //ejercicio3 - Practica1
    public interface Coleccionable
    {
        int Cuantos(); 
        Comparable Minimo(); 
        Comparable Maximo(); 
        void Agregar(Comparable x); 
        bool Contiene(Comparable x);
        Iterador crear_iterador();  //tuve que agregar este metodo para los coleccionables, porque sino no podia implementar la funcion imprimirElementos(Coleccionable Cll) 

        public virtual void tString()
        {
            //imprimirelementos
        }
    }
}
