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
    public partial class UsuarioInsertarVista : Form
    {
        public UsuarioInsertarVista()
        {
            InitializeComponent();
        }

        public static int IdPersonaSeleccionada=0;

        UsuarioBss bss = new UsuarioBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario();
            u.IdPersona = IdPersonaSeleccionada;
            u.NombreUser = textBox2.Text;
            u.Contraseña = textBox3.Text;
            u.FechaReg = Convert.ToDateTime(textBox4.Text);

            bss.InsertarUsuariosBss(u);
            MessageBox.Show("Se guardo correctamente la persona");
        }
        PersonaBss bssuser = new PersonaBss();
        private void button3_Click(object sender, EventArgs e)
        {
            PersonaListarVista fr = new PersonaListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Persona persona = bssuser.ObtenerIdBss(IdPersonaSeleccionada);
                textBox1.Text = persona.Nombre + " " + persona.Apellido;
            }
        }
    }

}
