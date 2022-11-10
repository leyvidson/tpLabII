using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyCINE_01.Entidades
{
    internal class Sala
    {
        public int Id_sala { get; set; }
        public string Tipo_sala { get; set; }
        
        public Sala(int id_sala, string tipo_sala)
        {
            Id_sala = id_sala;
            Tipo_sala = tipo_sala;  
        }
    }
}
