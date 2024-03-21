using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.Modelos;

namespace SistemasVentas.DAL
{
    public class VentaDAL
    {
        public DataTable ListarVentasDAL()
        {
            string consulta = "select * from venta";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }

        public void InsertarVentaDAL(Venta venta)
        {
            string consulta = "insert into venta values(" + venta.IdCliente + " ," +
                                                         "" + venta.IdVendedor + " ," +
                                                         "'" + venta.Fecha.ToString("yyyy-MM-dd HH:mm:ss") + "' ," +
                                                         "" + venta.Total + " ,"+
                                                         "'Activo')";
            conexion.Ejecutar(consulta);
        }
    }
}
