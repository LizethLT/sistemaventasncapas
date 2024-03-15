using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class DetalleVentDal
    {
        public DataTable ListarDetalleVentDal()
        {
            string consulta = "select * from persona";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }

        public void InsertarDetalleVentDal (DetalleVenta detalleventa)
        {
            string consulta = "insert into persona values(" + detalleventa.IdVenta + "," +
                                                      "" + detalleventa.IdProducto + "," +
                                                      "" + detalleventa.Cantidad+ "," +
                                                      "'" + detalleventa.PrecioVenta + "'," +
                                                      "'" + detalleventa.Subtotal+ "'," +
                                                      "'Activo')";
            conexion.Ejecutar(consulta);


        }
    }
}
