using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica6
{
    public class Nombre_aleatorio
    {
        public static string Nombre_azar()      //helper (ayuda) ejercicio12 - Practica1
        {
            Random r = new Random();
            List<string> l = new List<string>();

            l.Add("Ivan");
            l.Add("Ian");
            l.Add("Lucas");
            l.Add("Esteban");
            l.Add("Marcos");
            l.Add("Adrian");
            l.Add("Maria");
            l.Add("Teresa");
            l.Add("Lourdes");
            l.Add("Estefania");
            l.Add("Marcela");
            l.Add("Celia");
            l.Add("Alfonso");
            l.Add("Francisca");
            l.Add("Ivana");
            l.Add("Ana");
            l.Add("Juana");
            l.Add("Agustina");
            l.Add("Macarena");
            l.Add("Patricio");
            l.Add("Leonel");
            l.Add("Brenda");
            l.Add("Brisa");
            l.Add("Belen");
            l.Add("Gustavo");
            l.Add("Rodolfo");
            l.Add("Roberto");
            l.Add("Kevin");
            l.Add("Nelson");
            l.Add("Gaston");

            return l[r.Next(0, 29)];
        }
    }
}
