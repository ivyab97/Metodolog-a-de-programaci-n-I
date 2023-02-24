using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica6
{
    public class DNIcomparer:StrategyComparer //ejercicio1 - Practica2
    {
        public bool sosIgual(IComponenteAlumno y, IComponenteAlumno x)
        {
            if (x.GetDni() == y.GetDni())
            {
                return true;
            }
            return false;

        }
        public bool sosMenor(IComponenteAlumno y, IComponenteAlumno x)
        {
            if (x.GetDni() > y.GetDni())
            {
                return true;
            }
            return false;
        }

        public bool sosMayor(IComponenteAlumno y, IComponenteAlumno x)
        {
            if (x.GetDni() < y.GetDni())
            {
                return true;
            }
            return false;
        }
    }
}
