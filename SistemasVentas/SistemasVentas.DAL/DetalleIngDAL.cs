using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.Modelos;

namespace SistemasVentas.DAL
{
    public class DetalleIngDAL
    {
        public DataTable ListarDetallesIngDAL()
        {
            string consulta = "select * from detalleing";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }

        public void InsertarDetalleIngDAL(DetalleIng detalleing)
        {
            string consulta = "insert into detalleing values(" + detalleing.IdIngreso + " ," +
                                                         "" + detalleing.IdProducto + " ," +
                                                         "'" + detalleing.FechaVenc.ToString("yyyy-MM-dd HH:mm:ss") + "' ," +
                                                         "" + detalleing.Cantidad + " ," +
                                                         "" + detalleing.PrecioCosto + " ," +
                                                         "" + detalleing.PrecioVenta + " ," +
                                                         "" + detalleing.Subtotal + " ," +
                                                         "'Activo')";
            conexion.Ejecutar(consulta);
        }
    }
}
