using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // Agregar el proveedor "SQL Server"
using WindowsDataReader.models;

namespace WindowsDataReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTraerProductos_Click(object sender, EventArgs e)
        {
            // Una variable para leer la cadena de conexion en el App.config
            string cadena = WindowsDataReader.Properties.Settings.Default.KeyNorthwind;

            // Crear un objeto de conexion, usamos la clase SqlConnection
            SqlConnection conexion = new SqlConnection(cadena);

            // Una variable con la consulta de SQL
            string consultaSQL = "SELECT ProductID,ProductName,SupplierID,CategoryID,QuantityPerUnit,UnitPrice,UnitsInStock,UnitsOnOrder,ReorderLevel,Discontinued FROM dbo.Products";

            // Crear un objeto SqlCommand
            SqlCommand comando = new SqlCommand(consultaSQL, conexion);

            // Declarar un objeto SqlDataReader
            SqlDataReader reader;

            // La conexion siempre la abrimos y la cerramos nosotros, antes de ejecutar, hay que abrir
            // Abrir conexion
            conexion.Open();

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

            // Cerrar la conexion a la base de datos y cerrar Reader
            conexion.Close();
            reader.Close();

            // Mostrar productos 
            gridProductos.DataSource = lista;

        }
    }
}
