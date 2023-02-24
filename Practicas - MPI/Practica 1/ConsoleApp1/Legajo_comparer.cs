using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    public class Legajo_comparer:StrategyComparer   //ejercicio1 - Practica2
    {
        public bool sosIgual(Comparable y, Comparable x)
        {
            if ((((Alumno)x).getLegajo()) == (((Alumno)y).getLegajo()))
            {
                return true;
            }
            return false;

        }
        public bool sosMenor(Comparable y, Comparable x)
        {
            if ((((Alumno)x).getLegajo()) > (((Alumno)y).getLegajo()))
            {
                return true;
            }
            return false;
        }

        public bool sosMayor(Comparable y, Comparable x)
        {
            if ((((Alumno)x).getLegajo()) < (((Alumno)y).getLegajo()))
            {
                return true;
            }
            return false;
        }
    }
}
