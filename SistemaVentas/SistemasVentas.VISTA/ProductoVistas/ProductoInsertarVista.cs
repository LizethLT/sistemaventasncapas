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

namespace SistemasVentas.VISTA.ProductoVistas
{
    public partial class ProductoInsertarVista : Form
    {
        public ProductoInsertarVista()
        {
            InitializeComponent();
        }
         ProductoBss bss = new ProductoBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Producto prod = new Producto();
            prod.IdProducto= Convert.ToInt32(textBox1.Text);
            prod.Nombre = textBox2.Text;
            prod.CodigoBarra = textBox3.Text;
            prod.IdMarca= Convert.ToInt32(textBox4.Text);
            prod.Unidad = Convert.ToInt32(textBox5.Text);
            prod.Descripcion = textBox6.Text;

            bss.InsertarProductoBss(prod);
            MessageBox.Show("Se guardo correctamente el producto");
        }
    }
}
