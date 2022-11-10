using PyCINE_01.Entidades;
using PyCINE_01.servicios.Interfaz;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PyCINE_01.datos;

namespace PyCINE_01.servicios.Implementaciones
{
    class Servicio : IServicio
    {
        private IReservas oDao;
        
        public Servicio()
        {
            oDao = new ReservasDAO();
        }

        public DataTable ConsultarDB(string SP)
        {
            return oDao.ConsultarDB(SP);
        }

        public bool EjecutarInsert(Reserva Reserva)
        {
            return oDao.EjecutarInsert(Reserva);
        } 
        
        public bool EjecutarInsert(Cliente cliente)
        {
            return oDao.EjecutarInsert(cliente);
        }

        public bool EjecutarInsert(Pelicula Pelicula)
        {
            return oDao.EjecutarInsert(Pelicula);
        }

        public bool EjecutarInsert(object obj)
        {
            return (obj.Equals(obj)); // el equals esta para que no de error nomas . ES UNA PRUEBA DE REFACTORIZACION
        }
    }
}
