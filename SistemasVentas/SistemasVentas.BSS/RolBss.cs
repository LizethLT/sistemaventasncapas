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
    public class RolBss
    {
        RolDAL dal = new RolDAL();
        public DataTable ListarRolesBss()
        {
            return dal.ListarRolesDAL();
        }

        public void InsertarRolesBss(Rol rol)
        {
            dal.InsertarRolDAL(rol);
        }

        public Rol ObtenerIdBss(int id)
        {
            return dal.ObtenerRolId(id);
        }

        public void EditarRolBss(Rol r)
        {
            dal.EditarRolDal(r);
        }

        public void EliminarRolBss(int id)
        {
            dal.EliminarRolDal(id);
        }
    }
}
