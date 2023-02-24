using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica6
{
    public class Cartas     
    {
        int numero;
        string palo;

        public Cartas(int n, string c)
        {
            numero = n;
            palo = c;
        }

        public int numero_carta()
        {
            return numero;
        }
        public string palo_carta()
        {
            return palo;
        }
    }

    public class MazoDeCartas
    {
        protected List<Cartas> cartas = new List<Cartas>();
        public MazoDeCartas()
        {
            for (int i = 1; i <= 12; i++)
            {
                Cartas c_oro = new Cartas(i, "oro");
                Cartas c_basto = new Cartas(i, "basto");
                Cartas c_copa = new Cartas(i, "copa");
                Cartas c_espada = new Cartas(i, "espada");

                cartas.Add(c_oro);
                cartas.Add(c_basto);
                cartas.Add(c_copa);
                cartas.Add(c_espada);
            }
        }
        
        public List<Cartas> cartasEnMazo()
        {
            return cartas;
        }

    }
}
