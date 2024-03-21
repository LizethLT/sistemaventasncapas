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
    public class IngresoBss
    {
        IngresoDAL dal = new IngresoDAL();
        public DataTable ListarIngresosBss()
        {
            return dal.ListarIngresosDAL();
        }

        public void InsertarIngresosBss(Ingreso ingreso)
        {
            dal.InsertarIngresoDAL(ingreso);
        }

        public Ingreso ObtenerIdBss(int id)
        {
            return dal.ObtenerIngresoId(id);
        }

        public void EditarIngresoBss(Ingreso i)
        {
            dal.EditarIngresoDal(i);
        }

        public void EliminarIngresoBss(int id)
        {
            dal.EliminarIngresoDal(id);
        }
    }
}
