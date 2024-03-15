using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class ProveedorDal
    {
        public DataTable ListarProveedorDal()
        {
            string consulta = "select * from persona";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }

        public void InsertarProveedorDal(Proveedor proveedor)
        {
            string consulta = "insert into persona values('" + proveedor.Nombre + "'," +
                                                      "'" + proveedor.Telefono + "'," +
                                                      "'" + proveedor.Direccion + "'," +
                                                      "'Activo')";
            conexion.Ejecutar(consulta);


        }
    }
}
