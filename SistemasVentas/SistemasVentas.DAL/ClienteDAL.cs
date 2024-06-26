﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.Modelos;

namespace SistemasVentas.DAL
{
    public class ClienteDAL
    {
        public DataTable ListarClientesDAL()
        {
            string consulta = "select * from cliente";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }

        public void InsertarClienteDAL(Cliente cliente)
        {
            string consulta = "insert into cliente values(" + cliente.IdPersona + " ," +
                                                         "'" + cliente.TipoCliente + "' ," +
                                                         "'" + cliente.CodigoCliente + "' ," +
                                                         "'Activo')";
            conexion.Ejecutar(consulta);
        }

        public Cliente ObtenerClienteId(int id)
        {
            string consulta = "select * from cliente where idpersona =" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            Cliente c = new Cliente();
            if (tabla.Rows.Count > 0)
            {
                c.IdCliente = Convert.ToInt32(tabla.Rows[0]["idcliente"]);
                c.IdPersona = Convert.ToInt32(tabla.Rows[0]["idpersona"]);
                c.TipoCliente = tabla.Rows[0]["tipocliente"].ToString();
                c.CodigoCliente = tabla.Rows[0]["codigocliente"].ToString();
                c.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return c;
        }

        public void EditarClienteDal(Cliente c)
        {
            string consulta = "update cliente set " +
                        "idpersona = " + c.IdPersona + ", " +
                        "tipocliente = '" + c.TipoCliente + "', " +
                        "codigocliente = '" + c.CodigoCliente + "', " +
                        "where idcliente = " + c.IdCliente;

            conexion.Ejecutar(consulta);
        }

        public void EliminarClienteDal(int id)
        {
            string consulta = "delete from cliente where idcliente =" + id;
            conexion.Ejecutar(consulta);
        }

        public DataTable ClienteDatosDal()
        {
            string consulta = " SELECT CLIENTE.IDCLIENTE, CLIENTE.TIPOCLIENTE, (PERSONA.NOMBRE+''+ PERSONA.APELLIDO)NOMBRECOMPLETO, VENTA.FECHA " +
                            " FROM CLIENTE INNER JOIN " +
                         " PERSONA ON CLIENTE.IDPERSONA = PERSONA.IDPERSONA INNER JOIN " +
                          " VENTA ON CLIENTE.IDCLIENTE = VENTA.IDCLIENTE";

            return conexion.EjecutarDataTabla(consulta, "fsdf");
        }
    }
}
