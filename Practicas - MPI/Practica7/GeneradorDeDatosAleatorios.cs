using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica7
{
    public class GeneradorDeDatosAleatorios : ManejadorObtencionDeDatos     //ejercicio1 - Practica7
    {
        Random R=new Random();
        private static GeneradorDeDatosAleatorios instanciaUnica;		//Patron Singleton  - ejercicio4 - practica7
        private GeneradorDeDatosAleatorios(ManejadorObtencionDeDatos s) : base(s)
        {
        }

        public static GeneradorDeDatosAleatorios Get_instanciaUnica(ManejadorObtencionDeDatos s)     //Metodo estatico - Patron Singleton - ejercicio4 - practica7
        {
            if (instanciaUnica == null)
            {
                instanciaUnica = new GeneradorDeDatosAleatorios(s);
            }
            return instanciaUnica;
        }

        public override int numeroAleatorio(int max)
        {
            return R.Next(1, max);
        }

        public override string stringAleatorio(int n)
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
