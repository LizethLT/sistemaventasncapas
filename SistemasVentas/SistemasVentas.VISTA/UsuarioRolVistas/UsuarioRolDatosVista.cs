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

namespace SistemasVentas.VISTA.UsuarioRolVistas
{
    public partial class UsuarioRolDatosVista : Form
    {
        public UsuarioRolDatosVista()
        {
            InitializeComponent();
        }
        UsuarioRolBss bss = new UsuarioRolBss();    
        private void UsuarioRolDatosVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.UsuarioRolDatosBss();
        }
    }
}
