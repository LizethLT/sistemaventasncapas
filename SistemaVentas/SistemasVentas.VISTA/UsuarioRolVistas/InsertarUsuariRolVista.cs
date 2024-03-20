using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.PersonaVistas;
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
    public partial class InsertarUsuariRolVista : Form
    {
        public InsertarUsuariRolVista()
        {
            InitializeComponent();
        }
        public static int IdUsuarioSelecionado = 0;
        UsuarioBss bss = new UsuarioBss();
        private void button3_Click(object sender, EventArgs e)
        {
            UsuarioListarVista fr = new UsuarioListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Usuario usuario = bss.ObtenerIdBss(IdUsuarioSelecionado);
                textBox1.Text = usuario.IdPersona + " " + usuario.IdUsuario;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UsuarioListarVista fr = new UsuarioListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Usuario usuario = bss.ObtenerIdBss(IdUsuarioSelecionado);
                textBox1.Text = usuario.IdPersona + " " + usuario.IdUsuario;
            }
        }
        UsuarioRolBss bssuser = new UsuarioRolBss();    
        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioRol usuarioRol = new UsuarioRol();
            usuarioRol.IdUsuario = IdUsuarioSelecionado;
            usuarioRol.IdRol = IdUsuarioSelecionado;
            usuarioRol.FechaAsigna = dateTimePicker1.Value;

            bssuser.InsertarUsuarioRol(usuarioRol);
            MessageBox.Show("usuario rol registrado");
        }
    }
}
