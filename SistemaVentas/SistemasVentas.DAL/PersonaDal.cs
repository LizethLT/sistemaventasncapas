using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class PersonaDal
    {
        public DataTable ListarPerosnasDal() 
        {
            string consulta = "Select * from Persona";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "Tabla");
            return lista;   

        }
    }
}
