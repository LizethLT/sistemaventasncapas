using SistemasVentas.DAL;
using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.BSS
{
    public class DetalleVentBss
    {
        DetalleVentDal dal = new DetalleVentDal();
        public DataTable ListarPDetalleVentBss()
        {
            return dal.ListarDetalleVentDal();
        }
        public void InsertarDetalleVentBss(DetalleVenta detallevent)
        {
            dal.InsertarDetalleVentDal(detallevent);
        }
    }
}
