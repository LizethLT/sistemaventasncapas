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

namespace SistemasVentas.VISTA.UsuarioVistas
{
    public partial class UsuarioDatosVista : Form
    {
        public UsuarioDatosVista()
        {
            InitializeComponent();
        }
        UsuarioBss bss = new UsuarioBss();  
        private void UsuarioDatosVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.UsarioDatosBss();
        }
    }
}
