﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilas_Y_Colas.Interfaz
{
     interface ICollection
     {
        bool EstaVacia();
        object Extraer();
        object Primero();
        bool Añadir(object Pila);
     }
}
