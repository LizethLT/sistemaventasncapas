﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemasVentas.BSS;

namespace SistemasVentas.VISTA.DetalleVentaVistas
{
    public partial class DetalleVentaDatosVista : Form
    {
        public DetalleVentaDatosVista()
        {
            InitializeComponent();
        }
        DetalleVentaBss bss = new DetalleVentaBss();
        private void DetalleVentaDatosVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.DetalleVentaDatosBss();
        }
    }
}
