﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.Modelos;

namespace SistemasVentas.DAL
{
    public class DetalleVentaDAL
    {
        public DataTable ListarDetallesVentaDAL()
        {
            string consulta = "select * from detalleventa";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }

        public void InsertarDetalleVentaDAL(DetalleVenta detalleventa)
        {
            string consulta = "insert into detalleventa values(" + detalleventa.IdVenta + " ," +
                                                         "" + detalleventa.IdProducto + " ," +
                                                         "" + detalleventa.Cantidad + " ," +
                                                         "" + detalleventa.PrecioVenta + " ," +
                                                         "" + detalleventa.Subtotal + " ," +
                                                         "'Activo')";
            conexion.Ejecutar(consulta);
        }

        public DataTable DetalleVentaDatosDal()
        {
            string consulta = " SELECT DETALLEVENTA.IDDETALLEVENTA, DETALLEVENTA.CANTIDAD, VENTA.FECHA, PRODUCTO.NOMBRE " +
                             "FROM DETALLEVENTA INNER JOIN " +
                             "VENTA ON DETALLEVENTA.IDVENTA = VENTA.IDVENTA INNER JOIN " +
                             "PRODUCTO ON DETALLEVENTA.IDPRODUCTO = PRODUCTO.IDPRODUCTO";

            return conexion.EjecutarDataTabla(consulta, "fsdf");
        }
    }
}
