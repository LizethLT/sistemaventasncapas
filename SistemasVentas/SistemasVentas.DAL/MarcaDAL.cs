using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.Modelos;

namespace SistemasVentas.DAL
{
    public class MarcaDAL
    {
        public DataTable ListarMarcasDAL()
        {
            string consulta = "select * from marca";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }

        public void InsertarMarcaDAL(Marca marca)
        {
            string consulta = "insert into marca values('" + marca.Nombre + "' ," +
                                                         "'Activo')";
            conexion.Ejecutar(consulta);
        }


        public Marca ObtenerMarcaId(int id)
        {
            string consulta = "select * from marca where idmarca =" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            Marca m = new Marca();
            if (tabla.Rows.Count > 0)
            {
                m.IdMarca = Convert.ToInt32(tabla.Rows[0]["idmarca"]);
                m.Nombre = tabla.Rows[0]["nombre"].ToString();
                m.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return m;
        }

        public void EditarMarcaDal(Marca m)
        {
            string consulta = "update marca set " +
                      "nombre = '" + m.Nombre + "', " +
                      "estado = '" + m.Estado + "' " +
                      "where idmarca = " + m.IdMarca;

            conexion.Ejecutar(consulta);
        }

        public void EliminarMarcaDal(int id)
        {
            string consulta = "delete from marca where idmarca =" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
