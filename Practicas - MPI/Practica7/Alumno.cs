using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica7
{
    public class Alumno : IComponenteAlumno
    {
        public StrategyComparer strategyDeComparacion;
        public void SetEstartegiaDeComparacion(StrategyComparer strategyDeComparacion)
        {
            this.strategyDeComparacion = strategyDeComparacion;
        }
        public Alumno(string nombre, int dni, int legajo, int promedio)
        {
            this._dni = dni;
            this._nombre = nombre;
            this._promedio = promedio;
            this._legajo = legajo;
            this.strategyDeComparacion = new Legajo_comparer();
        }

        private int _calificacion;
        private int _legajo;
        private int _promedio;
        private string _nombre;
        private int _dni;

        public void SetCalifacion(int valor)
        {
            this._calificacion = valor;
        }
        public int GetCalificacion()
        {
            return this._calificacion;
        }
        public virtual int ResponderPregunta(int pregunta)
        {
            return new Random().Next(1, 3);
        }

        public string MostrarCalificacion()
        {
            return this.GetNombre() + " " + this.GetCalificacion();
        }


        public bool sosIgual(Comparable o)
        {
            return strategyDeComparacion.sosIgual(this, (IComponenteAlumno)o);
        }

        public bool sosMenor(Comparable o)
        {
            return strategyDeComparacion.sosMenor(this, (IComponenteAlumno)o);
        }

        public bool sosMayor(Comparable o)
        {
            return strategyDeComparacion.sosMayor(this, (IComponenteAlumno)o);
        }

        public int GetLegajo()
        {
            return _legajo;
        }

        public int GetPromedio()
        {
            return this._promedio;
        }

        public string toString()
        {
            return "nombre: " + _nombre + ", dni: " + _dni + ", legajo: " + _legajo + ", promedio: " + _promedio;
        }

        public string GetNombre()
        {
            return _nombre;
        }

        public int GetDni()
        {
            return _dni;
        }

        void Comparable.toString()
        {
            throw new NotImplementedException();
        }
    }

}
