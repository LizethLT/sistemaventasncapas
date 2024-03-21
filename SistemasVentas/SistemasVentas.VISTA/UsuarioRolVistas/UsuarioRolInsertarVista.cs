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
using SistemasVentas.VISTA.UsuarioVistas;
using SistemasVentas.VISTA.RolVistas;

namespace SistemasVentas.VISTA.UsuarioRolVistas
{
    public partial class UsuarioRolInsertarVista : Form
    {
        public UsuarioRolInsertarVista()
        {
            InitializeComponent();
        }
        public static int IdPersonaSeleccionada = 0;

        UsuarioRolBss bss = new UsuarioRolBss();
        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioRol u = new UsuarioRol();
            u.IdUsuario = IdUsuarioSeleccionada;
            u.IdRol = IdRolSeleccionada;
            u.FechaAsigna = Convert.ToDateTime(textBox3.Text);

            bss.InsertarUsuariosRolBss(u);
            MessageBox.Show("Se guardó correctamente");
        }

        public static int IdUsuarioSeleccionada = 0;
        UsuarioBss bssuser = new UsuarioBss();
        private void button3_Click(object sender, EventArgs e)
        {
            UsuarioListarVista fr = new UsuarioListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Usuario usuario = bssuser.ObtenerIdBss(IdUsuarioSeleccionada);
                textBox1.Text = usuario.NombreUser;
            }
        }

        public static int IdRolSeleccionada = 0;
        RolBss bssrol = new RolBss();
        private void button4_Click(object sender, EventArgs e)
        {
            RolListarVista fr = new RolListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Rol rol = bssrol.ObtenerIdBss(IdRolSeleccionada);
                textBox2.Text = rol.Nombre;
            }
        }
    }
}
