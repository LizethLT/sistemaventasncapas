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

namespace SistemasVentas.VISTA.VentaVistas
{
    public partial class VentaInsertarVista : Form
    {
        public VentaInsertarVista()
        {
            InitializeComponent();
        }

        VentaBss bss = new VentaBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Venta v = new Venta();
            v.IdCliente = Convert.ToInt32(textBox1.Text);
            v.IdVendedor = Convert.ToInt32( textBox2.Text);
            v.Fecha = Convert.ToDateTime(textBox3.Text);
            v.Total = Convert.ToDecimal( textBox4.Text);

            bss.InsertarVentasBss(v);
            MessageBox.Show("Se guardo correctamente la persona");
        }
    }
}
