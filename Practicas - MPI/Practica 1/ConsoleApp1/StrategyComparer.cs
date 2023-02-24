using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    public interface StrategyComparer   //ejercicio1 - Practica2
    {
        bool sosIgual(Comparable y, Comparable x);
        bool sosMenor(Comparable y, Comparable x);
        bool sosMayor(Comparable y, Comparable x);
    }
}
