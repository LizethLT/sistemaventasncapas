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
    public class ProveedorBss
    {
        ProveedorDAL dal = new ProveedorDAL();
        public DataTable ListarProveedoresBss()
        {
            return dal.ListarProveedoresDAL();
        }

        public void InsertarProveedoresBss(Proveedor proveedor)
        {
            dal.InsertarProveedorDAL(proveedor);
        }

        public Proveedor ObtenerIdBss(int id)
        {
            return dal.ObtenerProveedorId(id);
        }

        public void EditarProveedorBss(Proveedor p)
        {
            dal.EditarProveedorDal(p);
        }

        public void EliminarProveedorBss(int id)
        {
            dal.EliminarProveedorDal(id);
        }
    }
}
