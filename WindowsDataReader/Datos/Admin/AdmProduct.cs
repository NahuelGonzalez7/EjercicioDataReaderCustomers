using Datos.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Datos.Servidor;

namespace Datos.Admin
{
    public static class AdmProduct
    {
        /// <summary>
        /// Trae todos los productos de la base Northwind
        /// </summary>
        /// <returns></returns>
        public static List<Product> listar()
        {
            string consultaSQL = "SELECT ProductID,ProductName,SupplierID,CategoryID,QuantityPerUnit,UnitPrice,UnitsInStock,UnitsOnOrder,ReorderLevel,Discontinued FROM dbo.Products";

            // Crear un objeto SqlCommand
            SqlCommand comando = new SqlCommand(consultaSQL, AdminDB.conectarBase());

            // Declarar un objeto SqlDataReader
            SqlDataReader reader;

            // Crear el reader
            reader = comando.ExecuteReader();

            // Recorrer leer los datos hacia adelante, recorre en forma secuencial los datos
            List<Product> lista = new List<Product>();

            // A medida que se recorre la BDD, se guarda en la lista
            //ToDO investigar Reader
            while (reader.Read())
            {
                lista.Add(
                    new Product()
                    {
                        ProductID = Convert.ToInt32(reader["ProductID"]),
                        ProductName = Convert.ToString(reader[1]),
                        SupplierID = Convert.ToInt32(reader["SupplierID"]),
                        CategoryID = Convert.ToInt32(reader["CategoryID"]),
                        QuantityPerUnit = Convert.ToString(reader["QuantityPerUnit"]),
                        UnitPrice = Convert.ToDecimal(reader["UnitPrice"]),
                        UnitsInStock = Convert.ToUInt16(reader["UnitsInStock"]),
                        UnitsOnOrder = Convert.ToUInt16(reader["UnitsOnOrder"]),
                        ReorderLevel = Convert.ToUInt16(reader["ReorderLevel"]),
                        Discontinued = Convert.ToBoolean(reader["Discontinued"])
                    }
                    );
            }

            AdminDB.conectarBase().Close(); //Cerramos la conexion a la base de datos
            reader.Close();

            return lista;
        }

        public static List<Product> listar(int CategoriaId)
        {
            string consultaSQL = "SELECT ProductID,ProductName,SupplierID,CategoryID,QuantityPerUnit,UnitPrice,UnitsInStock,UnitsOnOrder,ReorderLevel,Discontinued FROM dbo.Products WHERE CategoryID = @CategoryID";

            // Crear un objeto SqlCommand
            SqlCommand comando = new SqlCommand(consultaSQL, AdminDB.conectarBase());

            //Declarar el parametro de SQL Server

            comando.Parameters.Add("@CategoryID", System.Data.SqlDbType.Int).Value = CategoriaId;

            // Declarar un objeto SqlDataReader
            SqlDataReader reader;

            // Crear el reader
            reader = comando.ExecuteReader();

            // Recorrer leer los datos hacia adelante, recorre en forma secuencial los datos
            List<Product> lista = new List<Product>();

            // A medida que se recorre la BDD, se guarda en la lista
            //ToDO investigar Reader
            while (reader.Read())
            {
                lista.Add(
                    new Product()
                    {
                        ProductID = Convert.ToInt32(reader["ProductID"]),
                        ProductName = Convert.ToString(reader[1]),
                        SupplierID = Convert.ToInt32(reader["SupplierID"]),
                        CategoryID = Convert.ToInt32(reader["CategoryID"]),
                        QuantityPerUnit = Convert.ToString(reader["QuantityPerUnit"]),
                        UnitPrice = Convert.ToDecimal(reader["UnitPrice"]),
                        UnitsInStock = Convert.ToUInt16(reader["UnitsInStock"]),
                        UnitsOnOrder = Convert.ToUInt16(reader["UnitsOnOrder"]),
                        ReorderLevel = Convert.ToUInt16(reader["ReorderLevel"]),
                        Discontinued = Convert.ToBoolean(reader["Discontinued"])
                    }
                    );
            }

            AdminDB.conectarBase().Close(); //Cerramos la conexion a la base de datos
            reader.Close();

            return lista;
        }

        public static int Insertar(Product producto)
        {
            return 0;
        }

        public static int Modificar(Product producto)
        {
            return 0;
        }

        public static int Eliminar(Product producto)
        {
            return 0;
        }
    }
}
