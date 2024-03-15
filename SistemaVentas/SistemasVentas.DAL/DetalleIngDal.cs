using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class DetalleIngDal
    {
        
            public DataTable ListarDetalleIngDal()
            {
                string consulta = "select * from persona";
                DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
                return lista;
            }

            public void InsertarDetalleIngDal(DetalleIngreso detalleIngreso)
            {
               string consulta = "insert into persona values(" + detalleIngreso.IdProducto + "," +
                                                         "" + detalleIngreso.IdIngreso + "," +
                                                         "'" + detalleIngreso.FechaVencimiento + "'," +
                                                         "" + detalleIngreso.cantidad +"," +
                                                         "" + detalleIngreso.PrecioCosto + "," +
                                                         "" + detalleIngreso.PrecioVenta + "," +
                                                         "" + detalleIngreso.Subtotal + "," +
                                                         "'Activo')";
              conexion.Ejecutar(consulta);


            }



    }
}
