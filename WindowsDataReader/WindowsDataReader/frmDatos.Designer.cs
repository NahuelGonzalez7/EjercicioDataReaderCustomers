
namespace WindowsDataReader
{
    partial class frmDatos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridProduct = new System.Windows.Forms.DataGridView();
            this.btnTraerPorIdCategoria = new System.Windows.Forms.Button();
            this.btnTraerTodos = new System.Windows.Forms.Button();
            this.lblIdCategoria = new System.Windows.Forms.Label();
            this.txtTraerIdCategoria = new System.Windows.Forms.TextBox();
            this.cbCategirua = new System.Windows.Forms.ComboBox();
            this.lblFiltrarPorCategoria = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // gridProduct
            // 
            this.gridProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProduct.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridProduct.Location = new System.Drawing.Point(0, 145);
            this.gridProduct.Name = "gridProduct";
            this.gridProduct.Size = new System.Drawing.Size(800, 305);
            this.gridProduct.TabIndex = 0;
            // 
            // btnTraerPorIdCategoria
            // 
            this.btnTraerPorIdCategoria.Location = new System.Drawing.Point(272, 96);
            this.btnTraerPorIdCategoria.Name = "btnTraerPorIdCategoria";
            this.btnTraerPorIdCategoria.Size = new System.Drawing.Size(85, 23);
            this.btnTraerPorIdCategoria.TabIndex = 1;
            this.btnTraerPorIdCategoria.Text = "Buscar";
            this.btnTraerPorIdCategoria.UseVisualStyleBackColor = true;
            this.btnTraerPorIdCategoria.Click += new System.EventHandler(this.btnTraerPorIdCategoria_Click);
            // 
            // btnTraerTodos
            // 
            this.btnTraerTodos.Location = new System.Drawing.Point(650, 96);
            this.btnTraerTodos.Name = "btnTraerTodos";
            this.btnTraerTodos.Size = new System.Drawing.Size(138, 23);
            this.btnTraerTodos.TabIndex = 2;
            this.btnTraerTodos.Text = "Traer Todos";
            this.btnTraerTodos.UseVisualStyleBackColor = true;
            this.btnTraerTodos.Click += new System.EventHandler(this.btnTraerTodos_Click);
            // 
            // lblIdCategoria
            // 
            this.lblIdCategoria.AutoSize = true;
            this.lblIdCategoria.Location = new System.Drawing.Point(26, 103);
            this.lblIdCategoria.Name = "lblIdCategoria";
            this.lblIdCategoria.Size = new System.Drawing.Size(110, 13);
            this.lblIdCategoria.TabIndex = 3;
            this.lblIdCategoria.Text = "Traer por Id Categoria";
            // 
            // txtTraerIdCategoria
            // 
            this.txtTraerIdCategoria.Location = new System.Drawing.Point(157, 96);
            this.txtTraerIdCategoria.Name = "txtTraerIdCategoria";
            this.txtTraerIdCategoria.Size = new System.Drawing.Size(100, 20);
            this.txtTraerIdCategoria.TabIndex = 4;
            // 
            // cbCategirua
            // 
            this.cbCategirua.FormattingEnabled = true;
            this.cbCategirua.Location = new System.Drawing.Point(491, 98);
            this.cbCategirua.Name = "cbCategirua";
            this.cbCategirua.Size = new System.Drawing.Size(121, 21);
            this.cbCategirua.TabIndex = 5;
            this.cbCategirua.SelectionChangeCommitted += new System.EventHandler(this.cbCategirua_SelectionChangeCommitted);
            // 
            // lblFiltrarPorCategoria
            // 
            this.lblFiltrarPorCategoria.AutoSize = true;
            this.lblFiltrarPorCategoria.Location = new System.Drawing.Point(386, 101);
            this.lblFiltrarPorCategoria.Name = "lblFiltrarPorCategoria";
            this.lblFiltrarPorCategoria.Size = new System.Drawing.Size(99, 13);
            this.lblFiltrarPorCategoria.TabIndex = 6;
            this.lblFiltrarPorCategoria.Text = "Filtrar Por Categoria";
            // 
            // frmDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFiltrarPorCategoria);
            this.Controls.Add(this.cbCategirua);
            this.Controls.Add(this.txtTraerIdCategoria);
            this.Controls.Add(this.lblIdCategoria);
            this.Controls.Add(this.btnTraerTodos);
            this.Controls.Add(this.btnTraerPorIdCategoria);
            this.Controls.Add(this.gridProduct);
            this.Name = "frmDatos";
            this.Text = "frmDatos";
            this.Load += new System.EventHandler(this.frmDatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridProduct;
        private System.Windows.Forms.Button btnTraerPorIdCategoria;
        private System.Windows.Forms.Button btnTraerTodos;
        private System.Windows.Forms.Label lblIdCategoria;
        private System.Windows.Forms.TextBox txtTraerIdCategoria;
        private System.Windows.Forms.ComboBox cbCategirua;
        private System.Windows.Forms.Label lblFiltrarPorCategoria;
    }
}