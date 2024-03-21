using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemasVentas.Modelos;
using SistemasVentas.BSS;

namespace SistemasVentas.VISTA.TipoProductoVistas
{
    public partial class TipoProdInsertarVista : Form
    {
        public TipoProdInsertarVista()
        {
            InitializeComponent();
        }

        TipoProdBss bss = new TipoProdBss();
        private void button1_Click(object sender, EventArgs e)
        {
            TipoProd t = new TipoProd();
            t.Nombre = textBox1.Text;

            bss.InsertarTiposProdBss(t);
            MessageBox.Show("Se guardo correctamente el nombre");
        }

        private void TipoProdInsertarVista_Load(object sender, EventArgs e)
        {
           
        }
    }
}
