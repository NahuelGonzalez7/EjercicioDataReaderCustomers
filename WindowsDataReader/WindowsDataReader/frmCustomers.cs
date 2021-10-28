using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsDataReader.models;

namespace WindowsDataReader
{
    public partial class frmCustomers : Form
    {
        public frmCustomers()
        {
            InitializeComponent();
        }

        private void btnTraerCustomers_Click(object sender, EventArgs e)
        {
            // Variable que lee la cadena de conexion en App.config

            string cadena = WindowsDataReader.Properties.Settings.Default.KeyNorthwind;

            // Creamos un objeto conexion, usando la clase SqlConnection

            SqlConnection connection = new SqlConnection(cadena);

            // Consulta al SQL

            string consultaSQL = "SELECT CustomerID ,CompanyName,ContactName ,ContactTitle,Address ,City ,Region ,PostalCode ,Country ,Phone,Fax FROM dbo.Customers";

            // Crear un objeto SqlCommand

            SqlCommand comando = new SqlCommand(consultaSQL, connection);

            // Declarar un objeto SqlDataReader
            SqlDataReader reader;

            // Abrir conexion 

            connection.Open();

            // Crear el reader

            reader = comando.ExecuteReader();

            // Declarar la lista y leer los datos

            List<Customer> lista = new List<Customer>();

            while (reader.Read())
            {
                lista.Add(

                    new Customer()
                    {
                        CustomerID = reader["CustomerID"].ToString(),
                        CompanyName = (string)reader["CompanyName"],
                        ContactName = (string)reader["ContactName"],
                        ContactTitle = (string)reader["ContactTitle"],
                        Address = (string)reader["Address"],
                        City = (string)reader["City"],
                        Region = ((reader["Region"] == DBNull.Value) ? string.Empty : (reader["Region"].ToString())),
                        PostalCode = ((reader["PostalCode"] == DBNull.Value) ? string.Empty : (reader["PostalCode"].ToString())),
                        Country = (string)reader["Country"],
                        Phone = (string)reader["Phone"],
                        Fax = ((reader["Fax"] == DBNull.Value) ? string.Empty : (reader["Fax"].ToString()))
                    }
                    );
            }

            // Cerrar conexion a la Base de Datos y cerrar Reader

            connection.Close();
            reader.Close();

            gridCustomers.DataSource = lista;

        }
    }
}
