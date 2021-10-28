using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; // Agregar proveedor de SQL Server

namespace Datos.Servidor
{
    internal static class AdminDB
    {
       /// <summary>
       /// Permite establecer la conexion con la Base Northwind
       /// </summary>
       /// <returns>Retorna un objeto de conexion abierto</returns>
        internal static SqlConnection conectarBase()
        {
            string cadena = Datos.Properties.Settings.Default.KeyDBNorthwind;
            SqlConnection connection = new SqlConnection(cadena);
            connection.Open();

            //ToDo Para que quede mejor habria que implementar patron de singleton (patron de disenio)

            return connection;
        }
    }
}
