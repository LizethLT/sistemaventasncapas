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

namespace SistemasVentas.VISTA.RolVistas
{
    public partial class RolEditarVista : Form
    {
        int idx = 0;
        Rol r = new Rol();
        RolBss bss = new RolBss();
        public RolEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            r.Nombre = textBox1.Text;

            bss.EditarRolBss(r);
            MessageBox.Show("SE GUARDO CORRECTAMENTE");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RolEditarVista_Load(object sender, EventArgs e)
        {
            r = bss.ObtenerIdBss(idx);
            textBox1.Text = r.Nombre;
        }
    }
}
