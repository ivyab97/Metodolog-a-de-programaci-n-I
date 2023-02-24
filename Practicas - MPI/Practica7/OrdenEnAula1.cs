using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica7
{
    public interface OrdenEnAula1   //ejercicio4_practica5
    {
        public void ejecutar();
    }

    public interface OrdenEnAula2   //ejercicio6_practica5
    {
        public void ejecutar(Comparable c);
    }

    public class OrdenInicio : OrdenEnAula1 //ejercicio5_practica5
    {
        Aula aula;
        public OrdenInicio(Aula a)
        {
            aula = a;
        }
        public void ejecutar()
        {
            aula.comenzar();
        }
    }
    public class OrdenAulaLlena : OrdenEnAula1  //ejercicio5_practica5
    {
        Aula aula;
        public OrdenAulaLlena(Aula a)
        {
            aula=a;
        }

        public void ejecutar()
        {
            aula.claseLista();
        }
    }
    public class OrdenLlegaAlumno : OrdenEnAula2   //ejercicio7_practica5
    {
        Aula aula;
        public OrdenLlegaAlumno(Aula a)
        {
            aula = a;
        }

        public void ejecutar(Comparable c)
        {
            aula.nuevoAlumno((Alumno)c);
        }
    }
}
