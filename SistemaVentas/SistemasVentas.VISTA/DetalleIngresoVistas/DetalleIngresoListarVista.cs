using SistemasVentas.BSS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.DetalleIngresoVistas
{
    public partial class DetalleIngresoListarVista : Form
    {
        public DetalleIngresoListarVista()
        {
            InitializeComponent();
        }
        DetalleIngresoBss bss = new DetalleIngresoBss();
        private void DetalleIngresoListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarDetalleIngresoBss();
        }
    }
}
