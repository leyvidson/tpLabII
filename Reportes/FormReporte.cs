﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PyCINE_01.Reportes
{
    public partial class FormReporte : Form
    {
        public FormReporte()
        {
            InitializeComponent();
        }

        private void FormReporte_Load(object sender, EventArgs e)
        {
            
            this.reportViewer1.RefreshReport();
        }
    }
}
