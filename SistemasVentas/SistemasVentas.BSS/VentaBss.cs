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
    public class VentaBss
    {
        VentaDAL dal = new VentaDAL();
        public DataTable ListarVentasBss()
        {
            return dal.ListarVentasDAL();
        }

        public void InsertarVentasBss(Venta venta)
        {
            dal.InsertarVentaDAL(venta);
        }
    }
}
