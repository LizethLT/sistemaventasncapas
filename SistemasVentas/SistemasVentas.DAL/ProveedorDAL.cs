using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.Modelos;

namespace SistemasVentas.DAL
{
    public class ProveedorDAL
    {
        public DataTable ListarProveedoresDAL()
        {
            string consulta = "select * from proveedor";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }

        public void InsertarProveedorDAL(Proveedor proveedor)
        {
            string consulta = "insert into proveedor values('" + proveedor.Nombre + "' ," +
                                                         "'" + proveedor.Telefono + "' ," +
                                                         "'" + proveedor.Direccion + "' ," +
                                                         "'Activo')";
            conexion.Ejecutar(consulta);
        }

        public Proveedor ObtenerProveedorId(int id)
        {
            string consulta = "select * from proveedor where idproveedor =" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            Proveedor p = new Proveedor();
            if (tabla.Rows.Count > 0)
            {
                p.IdProveedor = Convert.ToInt32(tabla.Rows[0]["idproveedor"]);
                p.Nombre = tabla.Rows[0]["nombre"].ToString();
                p.Telefono = tabla.Rows[0]["telefono"].ToString();
                p.Direccion = tabla.Rows[0]["direccion"].ToString();
                p.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return p;

        }

        public void EditarProveedorDal(Proveedor p)
        {
            string consulta = "update proveedor set nombre='" + p.Nombre + "'," +
                                                 "telefono='" + p.Telefono + "'," +
                                                 "direccion='" + p.Direccion + "' " +
                                           "where idproveedor=" + p.IdProveedor;

            conexion.Ejecutar(consulta);
        }

        public void EliminarProveedorDal(int id)
        {
            string consulta = "delete from proveedor where idproveedor =" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
