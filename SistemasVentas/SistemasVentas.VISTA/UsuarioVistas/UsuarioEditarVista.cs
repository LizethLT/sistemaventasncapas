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
using SistemasVentas.VISTA.PersonaVistas;

namespace SistemasVentas.VISTA.UsuarioVistas
{
    public partial class UsuarioEditarVista : Form
    {
        int idx = 0;
        Usuario u = new Usuario();
        UsuarioBss bss = new UsuarioBss();
        public UsuarioEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void UsuarioEditarVista_Load(object sender, EventArgs e)
        {
            u = bss.ObtenerIdBss(idx);
            textBox1.Text = u.IdPersona.ToString();
            textBox2.Text = u.NombreUser;
            textBox3.Text = u.Contraseña;
            textBox4.Text = u.FechaReg.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            u.IdPersona = IdPersonaSeleccionada;
            u.NombreUser = textBox2.Text;
            u.Contraseña = textBox3.Text;
            u.FechaReg = Convert.ToDateTime(textBox4.Text);

            bss.EditarUsuarioBss(u);
            MessageBox.Show("SE GUARDO CORRECTAMENTE");
        }


        public static int IdPersonaSeleccionada = 0;
        PersonaBss bsspersona = new PersonaBss();
        private void button3_Click(object sender, EventArgs e)
        {
            PersonaListarVista fr = new PersonaListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Persona persona = bsspersona.ObtenerIdBss(IdPersonaSeleccionada);
                textBox1.Text = persona.Nombre + " " + persona.Apellido;
            }

        }
    }
}
