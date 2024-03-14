using SistemasVentas.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.BSS
{
    public class TipoProductoBss
    {
        TipoProductoDal dal = new TipoProductoDal();
        public DataTable ListarTipoProductoBss()
        {
            return dal.ListarTipoProductosDal();
        }
    }
}
