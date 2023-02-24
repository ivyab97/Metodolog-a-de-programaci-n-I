using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3
{
    public class Vendedor : Persona, Observable    //ejercicio8_practica3   //ejercio12_practica3
    {
        List<Observador> ListObs=new List<Observador>();    //esta lista la cree para almacenar al gerente observador
        int sueldoBasico;
        double bonus;

        double monto;   //tuve que crear esta variable auxiliar para almacenar el monto de las ventas actuales
        public Vendedor(string n, int d, int s) : base(n, d)
        {
            Nombre = n;
            Dni= d;
            sueldoBasico= s;
            bonus = 1;
            monto = 0;
        }

        public List<Observador> L()
        {
            return ListObs;
        }
        public void venta(double monto)
        {
            this.monto= monto;
            NotifyObserver();
        }
        public void aumentaBonus()
        {
            bonus= bonus*1.1;
        }

        public int sueldoB()
        {
            return sueldoBasico;
        }
        public double getBonus()
        {
            return bonus;
        }
        public double getMonto()
        {
            return monto;
        }

        public override bool sosIgual(Comparable x)
        {
            return  (((Vendedor)x).getBonus()==this.bonus);
        }
        public override bool sosMayor(Comparable x)
        {
            return ((Vendedor)x).getBonus() < this.bonus;
        }
        public override bool sosMenor(Comparable x)
        {
            return ((Vendedor)x).getBonus() > this.bonus;
        }
        public override void toString()
        {
            Console.WriteLine("Nombre: " + getNombre() + " DNI: " + getDNI() + " Sueldo Basico: " + this.sueldoB() + " Bonus: " + this.getBonus());
        }

        public void AddObserver(Observador o)
        {
            ListObs.Add(o);
        }

        public void RemoveObserver(Observador o)
        {
            ListObs.Remove(o);
        }

        public void NotifyObserver()
        {
            foreach (Observador o in ListObs)
            {
                o.Update(this);
            }
        }
    }
}
