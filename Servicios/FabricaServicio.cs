using PyCINE_01.servicios.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyCINE_01.servicios
{
    abstract class FabricaServicio
    {
        public abstract IServicio CrearServicio();
    }
}
