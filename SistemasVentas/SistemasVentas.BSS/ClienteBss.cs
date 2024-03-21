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
    public class ClienteBss
    {
        ClienteDAL dal = new ClienteDAL();
        public DataTable ListarClientesBss()
        {
            return dal.ListarClientesDAL();
        }

        public void InsertarClientesBss(Cliente cliente)
        {
            dal.InsertarClienteDAL(cliente);
        }

        public Cliente ObtenerIdBss(int id)
        {
            return dal.ObtenerClienteId(id);
        }

        public void EditarClienteBss(Cliente c)
        {
            dal.EditarClienteDal(c);
        }

        public void EliminarClienteBss(int id)
        {
            dal.EliminarClienteDal(id);
        }
    }
}
