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
    public partial class FormConsultas : Form
    {
        public FormConsultas()
        {
            InitializeComponent();
        }

        private void lblCerrarConsultas_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
