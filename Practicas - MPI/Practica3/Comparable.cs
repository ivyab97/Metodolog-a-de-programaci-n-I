using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3
{
    public interface Comparable
    {
        //Ejercicio1 - Practica1
        bool sosIgual(Comparable x); //Devuelve verdadero si el objeto
                                     //que recibe el mensaje es el mismo que
                                     //el “comparable” recibido por parámetro, 
                                     //devuelve falso en caso contrario

        bool sosMenor(Comparable x); //Devuelve verdadero si el objeto
                                     //que recibe el mensaje es más chico que
                                    //el “comparable” recibido por parámetro, 
                                    //devuelve falso en caso contrario
        
        bool sosMayor(Comparable x); //Devuelve verdadero si el objeto 
                                     //que recibe el mensaje es más grande que
                                     //el “comparable” recibido por parámetro, 
                                     //devuelve falso en caso contrario
        void toString();    //tuve que agregar este metodo para los Comparable, porque sino se me complicaba implementar la funcion imprimirElementos(Coleccionable Cll)
    }
}
