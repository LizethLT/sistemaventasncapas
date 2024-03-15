using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class TipoProdDal
    {
        public DataTable ListarTipoProdDal()
        {
            string consulta = "select * from persona";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }

        public void InsertarTipoProdDal(TipoProd tipoProd)
        {
            string consulta = "insert into persona values('" + tipoProd.Nombre + "'," +
                                                      "'Activo')";
            conexion.Ejecutar(consulta);


        }
    }
}
