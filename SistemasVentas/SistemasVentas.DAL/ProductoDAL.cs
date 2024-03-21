using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.Modelos;

namespace SistemasVentas.DAL
{
    public class ProductoDAL
    {
        public DataTable ListarProductosDAL()
        {
            string consulta = "select * from producto";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }

        public void InsertarProductoDAL(Producto producto)
        {
            string consulta = "insert into producto values(" + producto.IdTipoProd + " ," +
                                                         "" + producto.IdMarca + " ," +
                                                         "'" + producto.Nombre + "' ," +
                                                         "'" + producto.CodigoBarra + "' ," +
                                                         "" + producto.Unidad + " ," +
                                                         "'" + producto.Descripcion + "' ," +
                                                         "'Activo')";
            conexion.Ejecutar(consulta);
        }
    }
}
