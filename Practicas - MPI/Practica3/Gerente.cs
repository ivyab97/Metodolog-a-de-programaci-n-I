using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3
{
    public class Gerente:Observador //ejercicio11 y 12_practica3
    {
        List<Vendedor> mejores;

        public Gerente()
        {
            mejores = new List<Vendedor>();
        }
        public void cerrar()
        {
            Console.WriteLine("Los mejores vendedores son: ");
            foreach(Vendedor v in mejores)
            {
                v.toString();
            }
        }

        
        public void venta(double monto, Vendedor vendedor)
        {
            if (monto > 5000)
            {
                bool agregar = true;

                foreach(Vendedor v in mejores)
                {
                    if (v.getDNI()==vendedor.getDNI())
                    {
                        vendedor.aumentaBonus();
                        agregar = false;
                    }
                }
                if (agregar==true)
                {
                    vendedor.aumentaBonus();
                    mejores.Add(vendedor);
                }
            }
        }
        public void Update(object vendedor)
        {
            this.venta((((Vendedor)vendedor).getMonto()), (Vendedor)vendedor);
        }


    }
}
