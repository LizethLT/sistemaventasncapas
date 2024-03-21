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
    public class ProveeBss
    {
        ProveeDAL dal = new ProveeDAL();
        public DataTable ListarProveesBss()
        {
            return dal.ListarProveesDAL();
        }
        public void InsertarProveesBss(Provee provee)
        {
            dal.InsertarProveeDAL(provee);
        }
    }
}
