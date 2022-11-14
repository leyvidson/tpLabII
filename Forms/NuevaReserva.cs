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
    public partial class NuevaReserva : Form
    {
        private IServicio oServicio;
        private FabricaServicio oFabrica;

        public NuevaReserva()
        {
            InitializeComponent();
            oFabrica = new FabricaServicioImp();        //estas 2 lineas reemplazan a GESTOR
            oServicio = oFabrica.CrearServicio();       //
        }
        private void CargarCombo(ComboBox Combo, string SP)
        {
            DataTable tabla = oServicio.ConsultarDB(SP);
            Combo.DataSource = tabla;
            Combo.ValueMember = tabla.Columns[0].ColumnName;
            Combo.DisplayMember = tabla.Columns[1].ColumnName;
            Combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarNuevaReserva_Click(object sender, EventArgs e)
        {
            if (Validar()) 
            {
                Reserva reserva = new Reserva();
                reserva.cliente = cboCliente.ValueMember;
                reserva.pelicula = cboPelicula.ValueMember;
                reserva.FechaReserva = dtpFecha.Value;
                reserva.Cantidad = Convert.ToInt32(txtCantidad.Text);

                if (oServicio.EjecutarInsert(reserva))
                {
                    MessageBox.Show("Se inserto correctame la Reserva", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo insertar la Reserva", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private bool Validar()
        {
            bool x = true;
            if (cboFuncion.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una Funcion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboFuncion.Focus();
            }
            if (cboCliente.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un Cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboCliente.Focus();
            }

            if (cboPelicula.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una Pelicula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboPelicula.Focus();
            }
            if (dtpFecha.Value == null)
            {
                MessageBox.Show("Debe seleccionar una Fecha", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dtpFecha.Focus();
            }
            if (txtCantidad.Text == String.Empty)
            {
                MessageBox.Show("Debe seleccionar la cantidad de entradas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCantidad.Focus();
            }
            return x;
        }

        private void NuevaReserva_Load(object sender, EventArgs e)
        {
            btnGuardarNuevaReserva.Enabled = true;
            CargarCombo(cboFuncion, "SP_CONSULTAR_FUNCION");
            CargarCombo(cboCliente, "SP_CONSULTAR_CLIENTES");
            CargarCombo(cboPelicula, "SP_CONSULTAR_PELICULA");
        }
    }
}
