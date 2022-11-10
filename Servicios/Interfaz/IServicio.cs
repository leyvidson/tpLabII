using PyCINE_01.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyCINE_01.servicios.Interfaz
{
    interface IServicio
    {        
        DataTable ConsultarDB(string SP);
        bool EjecutarInsert(Pelicula pelicula);
        bool EjecutarInsert(Cliente cliente);
        bool EjecutarInsert(Reserva reserva);
        bool EjecutarInsert(object objeto); //Intentando refactorizar (PRUEBA)
        
    }
}
