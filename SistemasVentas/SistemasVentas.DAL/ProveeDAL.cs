using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.Modelos;

namespace SistemasVentas.DAL
{
    public class ProveeDAL
    {
        public DataTable ListarProveesDAL()
        {
            string consulta = "select * from provee";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }

        public void InsertarProveeDAL(Provee provee)
        {
            string consulta = "insert into provee values(" + provee.IdProducto + " ," +
                                                         "" +provee.IdProveedor + " ," +
                                                         "'" + provee.Fecha.ToString("yyyy-MM-dd HH:mm:ss") + "' ," +
                                                         "" +provee.Precio + " ," +")";
            conexion.Ejecutar(consulta);
        }
    }
}
