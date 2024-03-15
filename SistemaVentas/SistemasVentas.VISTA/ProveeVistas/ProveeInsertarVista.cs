using SistemasVentas.BSS;
using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.ProveeVistas
{
    public partial class ProveeInsertarVista : Form
    {
        public ProveeInsertarVista()
        {
            InitializeComponent();
        }
         ProveeBss bss = new ProveeBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Provee prove = new Provee();
            prove.IdProducto=Convert.ToInt32(textBox1.Text);
            prove.IdProveedor=Convert.ToInt32(textBox2.Text);   
            prove.Fecha=Convert.ToDateTime(textBox3.Text);
            prove.Precio=Convert.ToDecimal(textBox4.Text);

            bss.InsertarProveeBss(prove);
            MessageBox.Show("Se guardo correctamente el provee");
        }
    }
}
