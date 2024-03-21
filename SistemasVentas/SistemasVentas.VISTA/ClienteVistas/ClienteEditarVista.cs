using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.PersonaVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.ClienteVistas
{
    public partial class ClienteEditarVista : Form
    {
        int idx = 0;
        Cliente c = new Cliente();
        ClienteBss bss = new ClienteBss();
        public ClienteEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void ClienteEditarVista_Load(object sender, EventArgs e)
        {
            c = bss.ObtenerIdBss(idx);
            textBox1.Text = c.IdPersona.ToString();
            textBox2.Text = c.TipoCliente;
            textBox3.Text = c.CodigoCliente;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c.IdPersona = IdPersonaSeleccionada;
            c.TipoCliente = textBox2.Text;
            c.CodigoCliente = textBox3.Text;

            bss.EditarClienteBss(c);
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
