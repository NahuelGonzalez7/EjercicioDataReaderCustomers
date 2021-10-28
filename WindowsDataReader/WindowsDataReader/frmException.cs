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

namespace WindowsDataReader
{
    public partial class frmException : Form
    {
        public frmException()
        {
            InitializeComponent();
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            int valor = 0;
            int valor2 = 10;

            try //Aqui va el codigo ejecutable
            {
                int resultado = valor2 / valor;

            }
            catch (DivideByZeroException exception) //El tratamiento de la exception personalizada
            {
                MessageBox.Show(exception.Message);
            }    
            catch(Exception ex) // El tratamiento de la exception es generica. LAS EXCEPCIONES GENERALES SIEMPRE VAN AL FINAL, ES EL ULTIMO.
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDemoExceptionSQL_Click(object sender, EventArgs e)
        {
            // Una variable para leer la cadena de conexion en el App.config
            string cadena = WindowsDataReader.Properties.Settings.Default.KeyNorthwind;

            // Crear un objeto de conexion, usamos la clase SqlConnection
            SqlConnection conexion = new SqlConnection(cadena);

            try
            {

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
            }
            catch  (SqlException exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally //Se usa para el control de recursos, abrir un archivo, abrir un servicio, abrir y cerrar la conexion de la DB
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            try 
            {
                /* Codigo Ejecutable */
            }
            catch (Exception)
            {

                /* Si el codigo ejecutable da una exception pasa por el catch */
            }
            finally
            {
                /* OCURRE SEIMRPE -> Paso por try o por catch */
            }
        }

        private void btnThrow_Click(object sender, EventArgs e)
        {
            try
            {
                throw new Exception("Ocurrio un error");
            }
            catch (Exception)
            {

                MessageBox.Show("Ejemplo de Throw");
            }
            
        }
    }
}
