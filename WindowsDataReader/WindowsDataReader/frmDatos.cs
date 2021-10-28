using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Datos.Admin;

namespace WindowsDataReader
{
    public partial class frmDatos : Form
    {
        public frmDatos()
        {
            InitializeComponent();
        }

        private void frmDatos_Load(object sender, EventArgs e)
        {
            mostrarProductos();
            llenarComboCategoria();
        }

        private void llenarComboCategoria()
        {
            DataTable Categoria = AdmCategory.listar();

            cbCategirua.DataSource = Categoria;
            cbCategirua.DisplayMember = Categoria.Columns["CategoryName"].ToString();
            cbCategirua.ValueMember = Categoria.Columns["CategoryID"].ToString();

            // Agregar una fila al DataTable "Categoria" en memoria

            DataRow fila = Categoria.NewRow();
            fila["CategoryID"] = 0;
            fila["CategoryName"] = "[TODAS]";
            Categoria.Rows.Add(fila);
        }

        private void mostrarProductos()
        {
            gridProduct.DataSource = AdmProduct.listar();
        }

        private void btnTraerPorIdCategoria_Click(object sender, EventArgs e)
        {
            int categoriaId = Convert.ToInt32(txtTraerIdCategoria.Text);

            gridProduct.DataSource = AdmProduct.listar(categoriaId);
        }

        private void btnTraerTodos_Click(object sender, EventArgs e)
        {
            mostrarProductos();
        }

        private void cbCategirua_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // El selectedValuecaptura el id de "ValueMember"
            int categoriaID = Convert.ToInt32(cbCategirua.SelectedValue);

            if (categoriaID == 0)
            {
                mostrarProductos();
            }
            else
            {
                gridProduct.DataSource = AdmProduct.listar(categoriaID);
            }
        }
    }
}
