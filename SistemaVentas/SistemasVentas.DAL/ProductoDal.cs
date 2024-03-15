using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class ProductoDal
    {
        public DataTable ListarProductoDal()
        {
            string consulta = "select * from persona";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }

        public void InsertarProductoDal(Producto producto)
        {
            string consulta = "insert into persona values(" + producto.IdTipoProducto+ "," +
                                                      "'" + producto.Nombre + "'," +
                                                      "'" + producto.CodigoBarra + "'," +
                                                      ""  + producto.IdMarca +","+
                                                      ""  + producto.Unidad +","+
                                                      "'" + producto.Descripcion +"',"+
                                                      "'Activo')";
            conexion.Ejecutar(consulta);


        }
    }
}
