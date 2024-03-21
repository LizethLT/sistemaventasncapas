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
    public class DetalleIngBss
    {
        DetalleIngDAL dal = new DetalleIngDAL();
        public DataTable ListarDetallesIngBss()
        {
            return dal.ListarDetallesIngDAL();
        }

        public void InsertarDetallesIngBss(DetalleIng detalleing)
        {
            dal.InsertarDetalleIngDAL(detalleing);
        }
    }
}
