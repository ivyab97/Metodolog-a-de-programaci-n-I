using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    public class AlumnoMuyEstudioso : Alumno    //ejercicio2_practica4
    {
        public AlumnoMuyEstudioso(string n, int d, int l, int p) : base(n, d, l, p)
        {  }
        public override int ResponderPregunta(int pregunta)
        {
            return pregunta % 3;
        }
    }
}
