﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPracticoPAV1_G02.Clases;
using TrabajoPracticoPAV1_G02.Negocio;

namespace TrabajoPracticoPAV1_G02.ABMs.Barrios
{
    public partial class Frm_AltaBarrios : Form
    {
        public Frm_AltaBarrios()
        {
            InitializeComponent();
            
        }

        private void Frm_AltaBarrios_Load(object sender, EventArgs e)
        {
          
            Ne_Barrios barrios = new Ne_Barrios();
            cmb_localidades.Cargar(barrios.DatosCombo());
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            Ne_Barrios barrios = new Ne_Barrios();
            TratamientosEspeciales _TE = new TratamientosEspeciales();
            if (_TE.controlar(this.Controls, "[BD3K6G02_2022].[dbo].[Barrio]"))
            {
                barrios.AltaBarrios(this.Controls); //aca se mandan todos los txtbox cmbbox
            }
            this.Close();
        }

        private void cmb_localidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }
    }
}
