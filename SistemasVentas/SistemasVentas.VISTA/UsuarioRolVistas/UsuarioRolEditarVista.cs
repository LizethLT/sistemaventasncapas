using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.RolVistas;
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

namespace SistemasVentas.VISTA.UsuarioRolVistas
{
    public partial class UsuarioRolEditarVista : Form
    {
        int idx = 0;
        UsuarioRol u = new UsuarioRol();
        UsuarioRolBss bss = new UsuarioRolBss();
        public UsuarioRolEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           // UsuarioRolListarVista fr = new UsuarioRolListarVista();
           // if (fr.ShowDialog() == DialogResult.OK)
            //{
               // UsuarioRol usuariorol = bss.ObtenerIdBss(IdUsuarioSeleccionada);
                //textBox1.Text = usuariorol.IdUsuarioRol.ToString();
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            u.IdUsuario = IdUsuarioSeleccionada;
            u.IdRol = IdRolSeleccionada;
            u.FechaAsigna = Convert.ToDateTime(textBox3.Text);
            bss.EditarUsuarioRolBss(u);
            MessageBox.Show("Datos Actualizados");
        }

        private void UsuarioRolEditarVista_Load(object sender, EventArgs e)
        {
            u = bss.ObtenerIdBss(idx);
            textBox1.Text = u.IdUsuario.ToString();
            textBox2.Text = u.IdRol.ToString();
            textBox3.Text = u.FechaAsigna.ToString();
        }

        public static int IdUsuarioSeleccionada = 0;
        UsuarioBss bssuser = new UsuarioBss();
        private void button3_Click_1(object sender, EventArgs e)
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            u.IdUsuario = IdUsuarioSeleccionada;
            u.IdRol = IdRolSeleccionada;
            u.FechaAsigna = Convert.ToDateTime(textBox3.Text);

            bss.EditarUsuarioRolBss(u);
            MessageBox.Show("Datos Actualizados");
        }
    }
}
