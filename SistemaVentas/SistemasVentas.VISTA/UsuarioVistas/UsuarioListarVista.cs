using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemasVentas.BSS;
using SistemasVentas.VISTA.UsuarioRolVistas;

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
            dataGridView1.DataSource = bss.ListarUsuarioBss();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertarUsuariRolVista.IdUsuarioSelecionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value); 
        }
    }
}
