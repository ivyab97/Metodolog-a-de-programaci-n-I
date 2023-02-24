using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3
{
    public class Persona : Comparable      //ejercicio11 - Practica1
    {
        string nombre;
        int dni;

        public Persona(string n, int d)
        {
            nombre = n;
            dni = d;
        }
        public string getNombre()
            { return nombre; }
        public int getDNI()
            { return dni; }

        public virtual bool sosIgual(Comparable x)
        {
            if ((((Persona)x).getDNI())==(this.getDNI()))
            {
                return true;
            }
            return false; 
        }

        public virtual bool sosMenor(Comparable x)
        {
            if ((((Persona)x).getDNI()) > (this.getDNI()))
            {
                return true;
            }
            return false;
        }

        public virtual bool sosMayor(Comparable x)
        {
            if ((((Persona)x).getDNI()) < (this.getDNI()))
            {
                return true;
            }
            return false;
        }

        public virtual void toString()
        {
            Console.WriteLine("Nombre: "+nombre+" DNI "+dni);
        }
        
        public string Nombre            //setters
            { set { nombre=value; } }
        public int Dni 
        { set { dni = value; } }

    }
}
