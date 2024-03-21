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

namespace SistemasVentas.VISTA.DetalleVentaVistas
{
    public partial class DetalleVentaInsertarVista : Form
    {
        public DetalleVentaInsertarVista()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        DetalleVentaBss bss = new DetalleVentaBss();
        private void button1_Click(object sender, EventArgs e)
        {
            DetalleVenta d = new DetalleVenta();
            d.IdVenta = Convert.ToInt32(textBox1.Text);
            d.IdProducto = Convert.ToInt32(textBox2.Text);
            d.Cantidad = Convert.ToInt32(textBox3.Text);
            d.PrecioVenta = Convert.ToDecimal(textBox4.Text);
            d.Subtotal = Convert.ToDecimal(textBox4.Text);

            bss.InsertarDetallesVentaBss(d);
            MessageBox.Show("Se guardo correctamente la persona");
        }
    }
}
