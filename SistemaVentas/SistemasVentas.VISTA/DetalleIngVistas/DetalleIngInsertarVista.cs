using SistemasVentas.BSS;
using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.DetalleIngVistas
{
    public partial class DetalleIngInsertarVista : Form
    {
        public DetalleIngInsertarVista()
        {
            InitializeComponent();
        }
        DetalleIngBss bss = new DetalleIngBss();
        private void button1_Click(object sender, EventArgs e)
        {
            DetalleIngreso d = new DetalleIngreso();
            d.IdProducto = Convert.ToInt32(textBox1.Text);
            d.IdIngreso = Convert.ToInt32(textBox2.Text);
            d.FechaVencimiento = Convert.ToDateTime(textBox3.Text);
            d.cantidad = Convert.ToInt32(textBox4.Text);
            d.PrecioCosto = Convert.ToDecimal(textBox5.Text);
            d.PrecioVenta = Convert.ToDecimal(textBox6.Text);
            d.Subtotal = Convert.ToDecimal(textBox7.Text);

            bss.InsertarDetalleIngPersonaBss(d);
            MessageBox.Show("Se guardo correctamente el Detalle del ingreso");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
