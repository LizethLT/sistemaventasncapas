using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.Modelos;

namespace SistemasVentas.DAL
{
    public class UsuarioDAL
    {
        public DataTable ListarUsuarioDal()
        {
            string consulta = "SELECT * FROM USUARIO";
            DataTable lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarUsuarioDal(Usuario usuario)
        {
            string consulta = "INSERT INTO USUARIO VALUES (" + usuario.IdPersona + " , " +
                                                            " '" + usuario.NombreUser + "' , " +
                                                            " '" + usuario.Contraseña + "' , " +
                                                            " '" + usuario.FechaReg + "')";
            Conexion.Ejecutar(consulta);
        }

        public Usuario ObtenerUsuarioId(int id) 
        {
            string consulta = "select * from usuario where idusuario=" + id;
            DataTable tabla = Conexion.EjecutarDataTabla(consulta, "asdas");
            Usuario u = new Usuario();
            if (tabla.Rows.Count > 0)
            {
                u.IdUsuario = Convert.ToInt32(tabla.Rows[0]["idusuario"]);
                u.IdPersona = Convert.ToInt32(tabla.Rows[0]["idpersona"]);
                u.NombreUser = tabla.Rows[0]["nombreuser"].ToString();
                u.Contraseña = tabla.Rows[0]["nombreuser"].ToString();
                u.Contraseña = tabla.Rows[0]["nombreuser"].ToString();
                u.FechaReg = Convert.ToDateTime(tabla.Rows[0]["fechareg"]);

            }

            return u;
        }

    }
}
