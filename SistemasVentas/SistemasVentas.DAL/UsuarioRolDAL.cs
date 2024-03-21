using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.Modelos;

namespace SistemasVentas.DAL
{
    public class UsuarioRolDAL
    {
        public DataTable ListarUsuariosRolDAL()
        {
            string consulta = "select * from usuariorol";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }

        public void InsertarUsuarioRolDAL(UsuarioRol usuariorol)
        {
            string consulta = "insert into usuariorol values(" + usuariorol.IdUsuario + " ," +
                                                         "" + usuariorol.IdRol + " ," +
                                                         "'" + usuariorol.FechaAsigna.ToString("yyyy-MM-dd HH:mm:ss") + "' ," +
                                                         "'Activo')";
            conexion.Ejecutar(consulta);
        }

        public UsuarioRol ObtenerUsuarioRolId(int id)
        {
            string consulta = "select * from usuariorol where idusuariorol =" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            UsuarioRol u = new UsuarioRol();
            if (tabla.Rows.Count > 0)
            {
                u.IdUsuarioRol = Convert.ToInt32(tabla.Rows[0]["idusuariorol"]);
                u.IdUsuario = Convert.ToInt32(tabla.Rows[0]["idusuario"]);
                u.IdRol = Convert.ToInt32(tabla.Rows[0]["idrol"]);
                u.FechaAsigna = Convert.ToDateTime(tabla.Rows[0]["fechaasigna"]);
                u.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return u;
        }

        public void EditarUsuarioRolDal(UsuarioRol u)
        {
            string consulta = "update usuariorol set " +
                      "idusuario = " + u.IdUsuario + ", " +
                      "idrol = " + u.IdRol + ", " +
                      "fechaasigna = '" + u.FechaAsigna.ToString("yyyy-MM-dd HH:mm:ss") + "', " +
                      "estado = '" + u.Estado + "' " +
                      "where idusuariorol = " + u.IdUsuarioRol;

            conexion.Ejecutar(consulta);
        }

        public void EliminarUsuarioRolDal(int id)
        {
            string consulta = "delete from usuariorol where idusuariorol =" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
