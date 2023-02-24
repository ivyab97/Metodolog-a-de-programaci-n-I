using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica5
{
    public class AlumnoProxy : IComponenteAlumno       //ejercicio1_practica5
    {
        Alumno alum;
        string nom;
        int dni;
        int leg;
        int prom;
        int tipo_alum;
        public AlumnoProxy(string n, int d, int l, int p, int t)  //tuve que agregar un parametro mas para saber que tipo de Alumno se quiere crear
        {
            nom = n;
            dni = d;
            leg = l;
            prom = p;
            tipo_alum = t;
        }

        public int ResponderPregunta(int pregunta)
        {
            if (tipo_alum == 1 && alum == null)             //se crea un Alumno "normal"
            {
                alum = new Alumno(nom, dni, leg, prom);
            }

            if (tipo_alum == 2 && alum == null)
            {
                alum = new AlumnoMuyEstudioso(nom, dni, leg, prom); //si no, se crea un AlumnoMuyEstudioso
            }
            return alum.ResponderPregunta(pregunta);
        }


        public int GetCalificacion()
        {
            return alum.GetCalificacion();
        }
        public void SetCalifacion(int valor)
        {
            alum.SetCalifacion(valor);
        }

        public string MostrarCalificacion()
        {
            return alum.MostrarCalificacion();
        }

        public int GetDni()
        {
            return dni;
        }

        public int GetLegajo()
        {
            return leg;
        }

        public string GetNombre()
        {
            return nom;
        }

        public int GetPromedio()
        {
            return prom;
        }

        public void SetEstartegiaDeComparacion(StrategyComparer strategyDeComparacion)
        {
            alum.SetEstartegiaDeComparacion(strategyDeComparacion);
        }

        public bool sosIgual(Comparable o)
        {
            return alum.sosIgual(o);
        }

        public bool sosMayor(Comparable o)
        {
            return alum.sosMayor(o);
        }

        public bool sosMenor(Comparable o)
        {
            return alum.sosMenor(o);
        }

        public string toString()
        {
            return alum.toString();
        }

        void Comparable.toString()
        {
            throw new NotImplementedException();
        }
    }
}
