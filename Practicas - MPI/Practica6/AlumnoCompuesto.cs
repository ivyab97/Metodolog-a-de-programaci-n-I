using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica6
{
    public class AlumnoCompuesto : IComponenteAlumno    //ejercicio1_practica6 (Compuesto)
    {
        List<IComponenteAlumno> hijos=new List<IComponenteAlumno>();

        public string GetNombre()       //Retorno la cadena con los nombres de los hijos
        {
            string nombres = "";

            foreach (IComponenteAlumno item in hijos)
            {
                nombres = nombres + "-" + item.GetNombre();
            }
            return nombres;
        }

        public int ResponderPregunta(int pregunta)      //Retorno la pregunta mas "votada" por los hijos
        {
            int cero=0, uno=0, dos=0, tres=0;
            List<int> lista=new List<int>() {cero, uno, dos, tres};


            foreach (IComponenteAlumno item in hijos)
            {
                int preg = item.ResponderPregunta(pregunta);
                if (preg == 1)
                    lista[1]++;
                if (preg == 2)
                    lista[2]++;
                if (preg == 3)
                    lista[3]++;
            }

            return lista.IndexOf(lista.Max());
            
        }

        public void SetCalifacion(int valor)        //Seteo una calidicacion común para los hijos
        {
            foreach (IComponenteAlumno item in hijos)
            {
                item.SetCalifacion(valor);
            }
        }

        public string MostrarCalificacion()     //Muestro una cadena con las calificaciones de todos los hijos
        {
            string calificaciones = "";

            foreach (IComponenteAlumno item in hijos)
            {
                calificaciones = calificaciones+"-"+ item.MostrarCalificacion() + "\n" + "\n";
            }
            return calificaciones;
        }


        public bool sosIgual(Comparable o)  //Si exite un hijo que es igual comparable recibido, se devuelve True
        {
            bool sosIgual = false;

            foreach (IComponenteAlumno item in hijos)
            {
                if (item.sosIgual(o))
                {
                    sosIgual = true;
                }
            }
            return sosIgual;
        }

        public bool sosMenor(Comparable o)      //Si todos los hijos son mas chicos que el comparable, se devuelve True
        {
            bool sosMenor = true;

            foreach (IComponenteAlumno item in hijos)
            {
                if (item.sosMayor(o))
                {
                    sosMenor = false;
                }
            }
            return sosMenor;
        }

        public bool sosMayor(Comparable o)      //Si todos los hijos son mas grandes que el comparable, se devuelve True
        {
            bool sosMayor = true;

            foreach (IComponenteAlumno item in hijos)
            {
                if (item.sosMenor(o))
                {
                    sosMayor = false;
                }
            }
            return sosMayor;
        }

        public void agregarHijo(IComponenteAlumno A)
        {
            hijos.Add(A);
        }

        public int GetCalificacion()
        {
            throw new NotImplementedException();    //sin implementar
        }

        public int GetDni()
        {
            return 1;   //sin implementar
        }

        public int GetLegajo()
        {
            return 1;   //sin implementar
        }

       
        public int GetPromedio()
        {
            return 1;   //sin implementar
        }


        public void SetEstartegiaDeComparacion(StrategyComparer strategyDeComparacion)
        {
            //sin implementar
        }



        public string toString()
        {
            throw new NotImplementedException();    //sin implementar
        }

        void Comparable.toString()
        {
            throw new NotImplementedException();    //sin implementar
        }
    }
}
