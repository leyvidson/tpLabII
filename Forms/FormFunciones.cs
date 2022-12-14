using PyCINE_01.datos;
using PyCINE_01.Entidades;
using PyCINE_01.servicios;
using PyCINE_01.servicios.Interfaz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PyCINE_01.Forms
{
    public partial class FormFunciones : Form
    {
        private IServicio oServicio;
        private FabricaServicio oFabrica;

        List<Funcion> lFunciones;
        public FormFunciones()
        {
            InitializeComponent();

            oFabrica = new FabricaServicioImp();    //Agregado nuevo
            oServicio = oFabrica.CrearServicio();   //estas 2 lineas reemplazan a GESTOR

            lFunciones = new List<Funcion>();
            cargarDGV();
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cargarDGV()
        {
            DataTable tabla = oServicio.ConsultarDB("SP_CONSULTAR_FUNCION");
            foreach (DataRow fila in tabla.Rows)
            {
                Funcion Func = new Funcion();

                Func.Id_funcion = (int)(fila["id_funcion"]);
                
                Func.Pelicula = fila["Titulo"].ToString();          //<<<<<<<<< ahora Pelicula es STRING
                //Func.pelicula.titulo = fila["Titulo"].ToString();  <<<<<<<<<<< antes habia relacion de agregacion
                
                Func.Horario = (DateTime)fila["horario"];
                Func.Precio = (decimal)fila["precio"];
                
                Func.Lenguaje = fila["lenguaje"].ToString();                 // idem
                //Func.Lenguaje.Descripcion = fila["lenguaje"].ToString();   idem
                
                Func.Id_sala = (int)fila["id_sala"];
                

                lFunciones.Add(Func);
            }
            dgvFunciones.Rows.Clear();
            foreach (Funcion Func in lFunciones)
            {
                dgvFunciones.Rows.Add(new object[] { Func.Id_funcion,Func.Pelicula, Func.Horario,
                                                Func.Precio, Func.Lenguaje, Func.Id_sala});
            }
        }
    }
}
