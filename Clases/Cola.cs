using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pilas_Y_Colas.Interfaz;

namespace Pilas_Y_Colas.Clases
{
    class Cola : ICollection
    {
        private List<Cola> colaList;
        private int contador;
        public Cola(int cantidad)
        {
            contador = 0;
            colaList=new List<Cola>(cantidad);
        }
        public bool Añadir(object Cola)
        {
            bool añadido = false;
            if (contador < colaList.Count)
            {
                Cola cola = colaList[contador++];
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
            for (int i = 0; i < colaList.Count; i++)
            {
                if (colaList[i]!=null&&!EstaVacia())
                {
                    P= colaList[i];
                    colaList[i]=null;
                    contador--;
                    break;
                }

            }
            return P;
        }

        public object Primero()
        {
           object p=null;
            if (!EstaVacia())
            { 
                p=colaList[0];
            }
            return p;

        }
    }
}
