using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica5
{
    //Componente interface
    public interface IComponenteAlumno:Comparable       //ejercicio6_practica4
    {
        public void SetEstartegiaDeComparacion(StrategyComparer strategyDeComparacion);
        public string GetNombre();
        public int GetDni();
        public string MostrarCalificacion();
        public void SetCalifacion(int valor);
        public int GetCalificacion();
        public int ResponderPregunta(int pregunta);

        public bool sosIgual(Comparable o);

        public bool sosMenor(Comparable o);

        public bool sosMayor(Comparable o);

        public int GetLegajo();

        public int GetPromedio();

        public string toString();
    }

    //Decorador
    public abstract class Decorador : IComponenteAlumno
    {
        private IComponenteAlumno alumnoComponent;
        public Decorador(IComponenteAlumno AC)
        {
            alumnoComponent = AC;
        }

        public IComponenteAlumno ComponenteAlumno
        {
            get { return alumnoComponent; }
        } 
        public int GetCalificacion()
        {
            return alumnoComponent.GetCalificacion();
        }

        public int GetDni()
        {
            return alumnoComponent.GetDni();
        }

        public int GetLegajo()
        {
            return alumnoComponent.GetLegajo();
        }

        public string GetNombre()
        {
            return alumnoComponent.GetNombre();
        }

        public int GetPromedio()
        {
            return alumnoComponent.GetPromedio();
        }

        public abstract string MostrarCalificacion();

        public int ResponderPregunta(int pregunta)
        {
            return alumnoComponent.ResponderPregunta(pregunta);
        }

        public void SetCalifacion(int valor)
        {
            alumnoComponent.SetCalifacion(valor);
        }

        public void SetEstartegiaDeComparacion(StrategyComparer strategyDeComparacion)
        {
            alumnoComponent.SetEstartegiaDeComparacion(strategyDeComparacion);
        }

        public bool sosIgual(Comparable o)
        {
            return alumnoComponent.sosIgual(o);
        }

        public bool sosMayor(Comparable o)
        {
            return alumnoComponent.sosMayor(o);
        }

        public bool sosMenor(Comparable o)
        {
            return alumnoComponent.sosMenor(o);
        }

        public string toString()
        {
            throw new NotImplementedException();
        }

        void Comparable.toString()
        {
            throw new NotImplementedException();
        }
    }

    //Decorador concreto 1; Imprime el legajo
    public class Print_Legajo : Decorador
    {
        public Print_Legajo(IComponenteAlumno Alumno_a_decorar) : base(Alumno_a_decorar)
        {
        }
        public override string MostrarCalificacion()
        {
            return ComponenteAlumno.MostrarCalificacion()+ "("+Convert.ToString(GetLegajo())+")";
        }

    }

    //Decorador concreto 2; Imprime el nombre del numero asociado a la calificacion
    public class Nota_letras : Decorador
    {
        public Nota_letras(IComponenteAlumno Alumno_a_decorar) : base(Alumno_a_decorar)
        {
        }

        
        public override string MostrarCalificacion()
        {
            return ComponenteAlumno.MostrarCalificacion()+ numero_letra(GetCalificacion());
        }

        private static string numero_letra(int numero)  //convierte la calificacion del alumno en letras
        {

            List<string> list = new List<string>() { " (CERO) ", " (UNO) ", " (DOS) ", " (TRES) ", " (CUATRO) ", " (CINCO) ", " (SEIS) ", " (SIETE) ", " (OCHO) ", " (NUEVE) ", " (DIEZ) " };

            return list[numero];
        }

    }

    //Decorador concreto 3; Imprime informacion que refleja si el estudiante promociono, aprobo o desaprobo 
    public class Prom_Apro_Desapro : Decorador
    {
        public Prom_Apro_Desapro(IComponenteAlumno Alumno_a_decorar) : base(Alumno_a_decorar)
        {
        }

        public override string MostrarCalificacion()
        {
            string estado = "";
            if (GetCalificacion() >= 7)
                estado = " (PROMOCIONADO) ";
            if (GetCalificacion() <= 7)
                estado = " (APROBADO) ";
            if (GetCalificacion() < 4)
                estado = " (DESAPROBADO) ";

            return ComponenteAlumno.MostrarCalificacion() + estado;
        }
    }

    //Decorador concreot 4; Encuadra la informacion imprimida en astericos
    public class Cuadro_aster : Decorador
    {
        public Cuadro_aster(IComponenteAlumno Alumno_a_decorar) : base(Alumno_a_decorar)
        {
        }

        public override string MostrarCalificacion()
        {
            return "***********************************************"+"\n* "+ComponenteAlumno.MostrarCalificacion()+"*"+ "\n***********************************************";
        }
    }
}
