using SistemasVentas.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.Modelos;

namespace SistemasVentas.BSS
{
    public class DetalleVentaBss
    {
        DetalleVentaDAL dal = new DetalleVentaDAL();
        public DataTable ListarDetallesVentaBss()
        {
            return dal.ListarDetallesVentaDAL();
        }

        public void InsertarDetallesVentaBss(DetalleVenta detalleventa)
        {
            dal.InsertarDetalleVentaDAL(detalleventa);
        }
    }
}
