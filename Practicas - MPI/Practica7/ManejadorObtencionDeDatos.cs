using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica7
{
    public abstract class ManejadorObtencionDeDatos     //ejercicio1 - practica7
    {
        protected ManejadorObtencionDeDatos sucesor=null;
        public ManejadorObtencionDeDatos(ManejadorObtencionDeDatos s)
        {
            sucesor = s;
        }

        public virtual int numeroAleatorio(int max)
        {
            if (sucesor != null)
            {
                return sucesor.numeroAleatorio(max);
            }
            return 0;
        }

        public virtual string stringAleatorio(int n)
        {
            if (sucesor != null)
            {
                return sucesor.stringAleatorio(n);
            }
            return "error";
        }
        
        public virtual int numeroPorTeclado()
        {
            if (sucesor != null)
            {
                return sucesor.numeroPorTeclado();
            }
            return 0;
        }
        public virtual string stringPorTeclado()
        {
            if (sucesor!=null)
            {
                return sucesor.stringPorTeclado();
            }
            return "error";
        }

        public virtual double numeroDesdeArchivo(double max)    //ejercicio3 - practica7
        {
            if (sucesor!=null)
            {
                return sucesor.numeroDesdeArchivo(max);
            }
            return 0;
        }

        public virtual string stringDesdeArchivo(int cant)      //ejercicio3 - practica7
        {
            if (sucesor!=null)
            {
                return sucesor.stringDesdeArchivo(cant);
            }
            return "error";
        }
    }
}
