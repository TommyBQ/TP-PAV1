﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuLuzReportes.Reportes.CotizacionesXEmpleado
{
    public partial class Frm_CotizacionesXEmpleado : Form
    {
        public Frm_CotizacionesXEmpleado()
        {
            InitializeComponent();
        }

        private void Frm_CotizacionesXEmpleado_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
