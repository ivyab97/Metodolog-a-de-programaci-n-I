using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    public class ColeccionMultiple : Coleccionable      //ejercicio8 - Practica1
    {
        object pila;
        object cola;

        public ColeccionMultiple(Pila p, Cola c)
        {
            pila = p;
            cola = c;
        }

        public void Agregar(Comparable x)
        {
            //no hace nada
        }

        public bool Contiene(Comparable x)
        {
            if(((Cola)(this.cola)).Contiene(x))
                return true;
            if (((Pila)(this.pila)).Contiene(x))
                return true;
            else
                return false;
        }

        public Iterador crear_iterador()    //Hasta ahora (en Practica2) no es necesario
        {
            throw new NotImplementedException();
        }

        public int Cuantos()
        {
            int cont = ((Cola)(this.cola)).Cuantos() +
            ((Pila)(this.pila)).Cuantos();

            return cont;
        
        }

        public Comparable Maximo()
        {
            Comparable mc=((Cola)(this.cola)).Maximo();
            Comparable mp=((Pila)(this.pila)).Maximo();

            if (mc.sosMayor(mp))
                return mc;
            if (mc.sosMenor(mp))
                return mp;
            else
                return mc;
        }

        public Comparable Minimo()
        {
            Comparable mc = ((Cola)(this.cola)).Minimo();
            Comparable mp = ((Pila)(this.pila)).Minimo();

            if (mc.sosMayor(mp))
                return mp;
            if (mc.sosMenor(mp))
                return mc;
            else
                return mc;
        }

    }
}
