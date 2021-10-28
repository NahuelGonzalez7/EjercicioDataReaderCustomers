using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Servidor;

namespace Datos.Admin
{
    public static class AdmCategory
    {
        public static DataTable listar()
        {
            //Query

            string consultaSQL = " select CategoryID,CategoryName from dbo.Categories";

            // Declarar y crear un SQLDataAdapter

            SqlDataAdapter adapter = new SqlDataAdapter(consultaSQL, AdminDB.conectarBase());

            // Declarar y crear un DataSet

            DataSet ds = new DataSet();

            // Invocar al fill --> conecta a la BD, Ejecuta el Select, Crear DataTable y se desconecta

            adapter.Fill(ds, "Category");

            return ds.Tables["Category"];
        }


        public static DataTable TraerUna(int id)
        {
            //Query

            string consultaSQL = " select CategoryID,CategoryName from dbo.Categories WHERE CategoryID=@CategoryID";

            // Declarar y crear un SQLDataAdapter

            SqlDataAdapter adapter = new SqlDataAdapter(consultaSQL, AdminDB.conectarBase());

            // Declarar los parametros 

            adapter.SelectCommand.Parameters.Add("@CategoryID", SqlDbType.Int).Value = id;

            // Declarar y crear un DataSet

            DataSet ds = new DataSet();

            // Invocar al fill --> conecta a la BD, Ejecuta el Select, Crear DataTable y se desconecta

            adapter.Fill(ds, "Categoria");

            return ds.Tables["Categoria"];
        }
    }
}
