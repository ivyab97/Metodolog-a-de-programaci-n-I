using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3
{
    public class GeneradorDeDatosAleatorios     //ejercicio2 - Practica3
    {
        Random R=new Random();

        public int numeroAleatorio(int max)
        {
            return R.Next(0, max);
        }

        public string stringAleatorio(int n)
        {
            var caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var aleatorio = new char[n];
            
            for (int i = 0; i < n; i++)
            {
                aleatorio[i] = caracteres[R.Next(caracteres.Length)];
            }
            string A = new string(aleatorio);

            return A;
        }
    }
}
