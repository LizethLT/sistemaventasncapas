using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.UsuarioVistas;
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
    public partial class RolListarVista : Form
    {
        public RolListarVista()
        {
            InitializeComponent();
        }
        RolBss bss=new RolBss();

        private void RolListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarRolesBss();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioRolVistas.UsuarioRolInsertarVista.IdRolSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            UsuarioRolVistas.UsuarioRolEditarVista.IdRolSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RolInsertarVista fr = new RolInsertarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarRolesBss();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int IdRolSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            RolEditarVista fr = new RolEditarVista(IdRolSeleccionada);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarRolesBss();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int IdRolSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("ESTAS SEGURO DE ELIMINAR ESTA PERSONA", "ELIMINANDO", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarRolBss(IdRolSeleccionado);
                dataGridView1.DataSource = bss.ListarRolesBss();
            }
        }
    }
}
