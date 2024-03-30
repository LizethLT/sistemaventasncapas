using SistemasVentas.BSS;
using SistemasVentas.VISTA.UsuarioRolVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.UsuarioVistas
{
    public partial class UsuarioListarVista : Form
    {
        public UsuarioListarVista()
        {
            InitializeComponent();
        }
        UsuarioBss bss = new UsuarioBss();

        private void UsuarioListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarUsuariosBss();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioRolInsertarVista.IdUsuarioSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            //VentaVistas.VentaInsertarVista.IdVendedorSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            UsuarioRolEditarVista.IdUsuarioSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            //VentaVistas.VentaEditarVista.IdVendedorSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UsuarioInsertarVista fr = new UsuarioInsertarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarUsuariosBss();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int IdUsuarioSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            UsuarioEditarVista fr = new UsuarioEditarVista(IdUsuarioSeleccionado);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarUsuariosBss();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int IdUsuarioSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("ESTAS SEGURO DE ELIMINAR ESTA PERSONA", "ELIMINANDO", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarUsuarioBss(IdUsuarioSeleccionado);
                dataGridView1.DataSource = bss.ListarUsuariosBss();
            }
        }
    }
}
