using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica6
{
    public class Aula   //ejercicio3_practica5      //Receptor
    {
        Teacher teacher;

        public void comenzar()
        {
            Console.WriteLine("El teacher ya llegó");
            teacher = new Teacher();
        }
        public void nuevoAlumno(Alumno alum)
        {
            if (teacher != null)
            {
                Student est = new AdapterAlumno(alum);
                teacher.goToClass(est);
            }
            else
                Console.WriteLine("La clase no ha comenzado");
        }

        public void claseLista()
        {
            if (teacher != null)
            {
                Console.WriteLine("Clase Llena. Hora de empezar...");
                teacher.teachingAClass();
            }
            else
                Console.WriteLine("La clase no ha comenzado");
        }
    }
}
