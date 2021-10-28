
namespace WindowsDataReader
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTraerProductos = new System.Windows.Forms.Button();
            this.gridProductos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTraerProductos
            // 
            this.btnTraerProductos.Location = new System.Drawing.Point(335, 12);
            this.btnTraerProductos.Name = "btnTraerProductos";
            this.btnTraerProductos.Size = new System.Drawing.Size(389, 68);
            this.btnTraerProductos.TabIndex = 0;
            this.btnTraerProductos.Text = "Traer Productos";
            this.btnTraerProductos.UseVisualStyleBackColor = true;
            this.btnTraerProductos.Click += new System.EventHandler(this.btnTraerProductos_Click);
            // 
            // gridProductos
            // 
            this.gridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProductos.Location = new System.Drawing.Point(12, 86);
            this.gridProductos.Name = "gridProductos";
            this.gridProductos.Size = new System.Drawing.Size(1061, 332);
            this.gridProductos.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 450);
            this.Controls.Add(this.gridProductos);
            this.Controls.Add(this.btnTraerProductos);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTraerProductos;
        private System.Windows.Forms.DataGridView gridProductos;
    }
}

