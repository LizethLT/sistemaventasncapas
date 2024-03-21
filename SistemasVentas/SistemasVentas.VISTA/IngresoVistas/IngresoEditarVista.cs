using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.IngresoVistas
{
    public partial class IngresoEditarVista : Form
    {
        int idx = 0;
        Ingreso i = new Ingreso();
        IngresoBss bss = new IngresoBss();
        public IngresoEditarVista(int id)
        {
            InitializeComponent();
        }

        private void IngresoEditarVista_Load(object sender, EventArgs e)
        {
            i = bss.ObtenerIdBss(idx);
            textBox1.Text = i.IdProveedor.ToString();
            textBox2.Text = i.FechaIngreso.ToString();
            textBox3.Text = i.Total.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i.IdProveedor = Convert.ToInt32(textBox1.Text);
            i.FechaIngreso = Convert.ToDateTime(textBox2.Text);
            i.Total = Convert.ToDecimal(textBox3.Text);

            bss.EditarIngresoBss(i);
            MessageBox.Show("SE GUARDO CORRECTAMENTE");
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
