using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica6
{
    public class Legajo_comparer:StrategyComparer   //ejercicio1 - Practica2
    {
        public bool sosIgual(IComponenteAlumno y, IComponenteAlumno x)
        {
            if (x.GetLegajo() == y.GetLegajo())
            {
                return true;
            }
            return false;

        }
        public bool sosMenor(IComponenteAlumno y, IComponenteAlumno x)
        {
            if (x.GetLegajo() > y.GetLegajo())
            {
                return true;
            }
            return false;
        }

        public bool sosMayor(IComponenteAlumno y, IComponenteAlumno x)
        {
            if (x.GetLegajo() < y.GetLegajo())
            {
                return true;
            }
            return false;
        }
    }
}
