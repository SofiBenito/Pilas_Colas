using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pilas_Y_Colas.Interfaz;

namespace Pilas_Y_Colas.Clases
{
    class Pila : ICollection
    {
       private object[] array;
       private int contador;
        public Pila(int cantidad)
        {
            contador= -1;
            array= new object[cantidad];
        }
        public bool Añadir(object Pila)
        {
           bool añadido = false;
           if(contador<array.Length)
           {
                array[++contador]=Pila;
                añadido = true;
           }
            return añadido;
        }

        public bool EstaVacia()
        {
            return contador == -1;
         
        }

        public object Extraer()
        {
            object P = null;

            if (!EstaVacia())
            {
                P = array[contador];
                array[contador] = null;
                contador--;
            }
            return P;
        }

        public object Primero()
        {
            object p= null;
            if (!EstaVacia())
            {
                p = array[0];
            }
            return p;
        }
    }
}
