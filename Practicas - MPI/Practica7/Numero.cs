using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica7 
{
    //Ejercicio2 - Practica1
    internal class Numero : Comparable
    {
        public double valor;
        public Numero(double v)
        {
            valor = v;
        }
        public double getValor() { return valor; }

        public bool sosIgual(Comparable x)
        {
            if (this.getValor() == ((Numero)x).getValor())
            {
                return true;
            }
            return false;
        }
        public bool sosMenor(Comparable x)
        {
            if (this.getValor() < ((Numero)x).getValor())
            {
                return true;
            }
            return false;
        }
        public bool sosMayor(Comparable x)
        {
            if (this.getValor()>((Numero)x).getValor())
            {
                return true;
            }
            return false;
        }

        public void toString()
        {
            Console.WriteLine("Numero: " + this.getValor());
        }
    }
}
