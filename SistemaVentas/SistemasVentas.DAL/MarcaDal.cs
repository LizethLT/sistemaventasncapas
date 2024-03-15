using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public  class MarcaDal
    {
        public DataTable ListarMarcaDal()
        {
            string consulta = "select * from persona";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }

        public void InsertarMarcaDal(Marca marca)
        {
            string consulta = "insert into persona values('" + marca.Nombre + "'," +
                                                      "'Activo')";
            conexion.Ejecutar(consulta);


        }
    }
}
