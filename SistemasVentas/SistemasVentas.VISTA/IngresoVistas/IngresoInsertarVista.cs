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
using SistemasVentas.VISTA.ProveedorVistas;

namespace SistemasVentas.VISTA.IngresoVistas
{
    public partial class IngresoInsertarVista : Form
    {
        public IngresoInsertarVista()
        {
            InitializeComponent();
        }

        public static int IdProveedorSeleccionado = 0;

        IngresoBss bss = new IngresoBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Ingreso i = new Ingreso();
            i.IdProveedor = IdProveedorSeleccionado;
            i.FechaIngreso = Convert.ToDateTime(textBox2.Text);
            i.Total = Convert.ToDecimal(textBox3.Text);

            bss.InsertarIngresosBss(i);
            MessageBox.Show("Se guardo correctamente la persona");
        }

        ProveedorBss bssproveedor = new ProveedorBss();
        private void button3_Click(object sender, EventArgs e)
        {
            ProveedorListarVista fr = new ProveedorListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Proveedor proveedor = bssproveedor.ObtenerIdBss(IdProveedorSeleccionado);
                textBox1.Text = proveedor.Nombre + " " + proveedor.Telefono;
            }
        }
    }
}
