using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    public class Alumno : Persona //ejercicio15 //ejercicio18 - Practica1 - vamos a comparar por legajo
    {
        StrategyComparer estrategia;
        int legajo;
        int promedio;


        public Alumno(string n, int d, int l, int p) : base (n, d)
        {
            estrategia = new Legajo_comparer(); //por defecto, tiene seteada una estrategia de comparacion por legajo
            this.Nombre = n;
            this.Dni = d;
            legajo = l;
            promedio = p;
        }

        public int getLegajo() { return legajo; }
        public int getPromedio() { return promedio; }

        public override bool sosIgual(Comparable x)
        {
            return estrategia.sosIgual(this, x);
        }
        public override bool sosMayor(Comparable x)
        {
            return estrategia.sosMayor(this, x);
        }
        public override bool sosMenor(Comparable x)
        {
            return estrategia.sosMenor(this, x);
        }

        public void ChangeStrategy(StrategyComparer nueva_estrategia)   //ejercicio1 - Practica2
        {
            estrategia = nueva_estrategia;
        }
        public override void toString()
        {
            Console.WriteLine("Nombre: " + this.getNombre() + " DNI " + this.getDNI() + " Legajo "+this.getLegajo()+" Promedio "+this.getPromedio());
        }
    }

}
