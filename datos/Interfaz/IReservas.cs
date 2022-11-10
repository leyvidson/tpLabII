using PyCINE_01.Entidades;
using System.Data;

namespace PyCINE_01.datos
{
    internal interface IReservas
    {       
        bool EjecutarInsert(Reserva reserva);
        DataTable ConsultarDB(string SP);
        bool EjecutarInsert(Cliente cliente);
        bool EjecutarInsert(Pelicula pelicula);
        DataTable ConsultaDBVista(string vista);


    }
}
