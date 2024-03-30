using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.Modelos;

namespace SistemasVentas.DAL
{
    public class ProveeDAL
    {
        public DataTable ListarProveesDAL()
        {
            string consulta = "select * from provee";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }

        public void InsertarProveeDAL(Provee provee)
        {
            string consulta = "insert into provee values(" + provee.IdProducto + " ," +
                                                         "" +provee.IdProveedor + " ," +
                                                         "'" + provee.Fecha.ToString("yyyy-MM-dd HH:mm:ss") + "' ," +
                                                         "" +provee.Precio + " ," +")";
            conexion.Ejecutar(consulta);
        }
        public DataTable ProveeDatosDal()
        {
            string consulta = "SELECT  PROVEE.IDPROVEE, PROVEE.FECHA, PROVEE.PRECIO, PRODUCTO.NOMBRE, PRODUCTO.DESCRIPCION, PROVEEDOR.NOMBRE AS Expr1, PROVEEDOR.DIRECCION " +
                             " FROM            PROVEE INNER JOIN " +
                             " PRODUCTO ON PROVEE.IDPRODUCTO = PRODUCTO.IDPRODUCTO INNER JOIN" +
                             " PROVEEDOR ON PROVEE.IDPROVEEDOR = PROVEEDOR.IDPROVEEDOR ";

            return conexion.EjecutarDataTabla(consulta, "fsdf");
        }

    }
}
