using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyCINE_01.Entidades
{
    internal class Promocion
    {
        public int Id_promocion { get; set; }
        public float Descuento { get; set; }
        public string Descripcion { get; set; }
        
        public Promocion(int id_promocion, float descuento, string descripcion)
        {
            Id_promocion = id_promocion;
            Descuento = descuento;
            Descripcion = descripcion;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
