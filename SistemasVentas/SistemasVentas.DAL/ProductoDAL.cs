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
        public DataTable ProductoDatosDal()
        {
            string consulta = " SELECT PRODUCTO.IDPRODUCTO, PRODUCTO.NOMBRE, TIPOPROD.NOMBRE AS Expr1, MARCA.NOMBRE AS Expr2, PRODUCTO.ESTADO, PRODUCTO.DESCRIPCION " +
                             "  FROM  PRODUCTO INNER JOIN" +
                              " TIPOPROD ON PRODUCTO.IDTIPOPROD = TIPOPROD.IDTIPOPROD INNER JOIN" +
                              " MARCA ON PRODUCTO.IDMARCA = MARCA.IDMARCA";

            return conexion.EjecutarDataTabla(consulta, "fsdf");
        }
    }
}
