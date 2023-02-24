using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica5
{
    public class AdapterAlumno : Student    //ejercicio3_practica4
    {
        IComponenteAlumno Ad;       
        public AdapterAlumno(IComponenteAlumno A)
        {
            Ad = A;
        }

        public bool equals(Student student)
        {
            return Ad.sosIgual(((AdapterAlumno)student).Ad);
        }

        public string getName()
        {
            return Ad.GetNombre();
        }

        public bool greaterThan(Student student)    
        {
            return Ad.sosMayor(((AdapterAlumno)student).Ad);
        }

        public bool lessThan(Student student)
        {
            return Ad.sosMenor(((AdapterAlumno)student).Ad);
        }

        public void setScore(int score)
        {
            Ad.SetCalifacion(score);
        }      
       
        public string showResult()
        {
            return Ad.MostrarCalificacion(); 
        }

        public int yourAnswerIs(int question)
        {
           return Ad.ResponderPregunta(question);
        }
    }
}
