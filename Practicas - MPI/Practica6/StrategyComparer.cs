using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica6
{
    public interface StrategyComparer   //ejercicio1 - Practica2
    {
        bool sosIgual(IComponenteAlumno y, IComponenteAlumno x);
        bool sosMenor(IComponenteAlumno y, IComponenteAlumno x);
        bool sosMayor(IComponenteAlumno y, IComponenteAlumno x);
    }
}
