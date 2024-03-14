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

namespace SistemasVentas.VISTA.TipoProductoVistas
{
    public partial class TipoProductoListarVista : Form
    {
        public TipoProductoListarVista()
        {
            InitializeComponent();
        }
        TipoProductoBss bss = new TipoProductoBss();
        private void TipoProductoListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarTipoProductoBss();
        }
    }
}
