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
    public class UsuarioRolBss
    {
        UsuarioRolDAL dal = new UsuarioRolDAL();
        public DataTable ListarUsuariosRolBss()
        {
            return dal.ListarUsuariosRolDAL();
        }

        public void InsertarUsuariosRolBss(UsuarioRol usuariorol)
        {
            dal.InsertarUsuarioRolDAL(usuariorol);
        }

        public UsuarioRol ObtenerIdBss(int id)
        {
            return dal.ObtenerUsuarioRolId(id);
        }

        public void EditarUsuarioRolBss(UsuarioRol u)
        {
            dal.EditarUsuarioRolDal(u);
        }

        public void EliminarUsuarioRolBss(int id)
        {
            dal.EliminarUsuarioRolDal(id);
        }
    }
}
