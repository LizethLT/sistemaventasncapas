using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class IngresoDal
    {
        public DataTable ListarIngresoDal()
        {
            string consulta = "select * from persona";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarIngresoDal(Ingreso ingreso)
        {
            string consulta = "insert into persona values(" + ingreso.IdProveedor + "," +
                                                      "'" + ingreso.FechaIngreso + "'," +
                                                      "" + ingreso.Total + "," +
                                                      "'Activo')";
            conexion.Ejecutar(consulta);


        }
    }
}
