using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3
{
    public interface Observable     //ejercicio12_practica3
    {
        void AddObserver(Observador o);
        void RemoveObserver(Observador o);
        void NotifyObserver();
    }
}
