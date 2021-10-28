
namespace WindowsDataReader
{
    partial class frmCustomers
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
            this.btnTraerCustomers = new System.Windows.Forms.Button();
            this.gridCustomers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTraerCustomers
            // 
            this.btnTraerCustomers.Location = new System.Drawing.Point(222, 5);
            this.btnTraerCustomers.Name = "btnTraerCustomers";
            this.btnTraerCustomers.Size = new System.Drawing.Size(334, 73);
            this.btnTraerCustomers.TabIndex = 0;
            this.btnTraerCustomers.Text = "Traer Customers";
            this.btnTraerCustomers.UseVisualStyleBackColor = true;
            this.btnTraerCustomers.Click += new System.EventHandler(this.btnTraerCustomers_Click);
            // 
            // gridCustomers
            // 
            this.gridCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCustomers.Location = new System.Drawing.Point(12, 84);
            this.gridCustomers.Name = "gridCustomers";
            this.gridCustomers.Size = new System.Drawing.Size(776, 264);
            this.gridCustomers.TabIndex = 1;
            // 
            // frmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 360);
            this.Controls.Add(this.gridCustomers);
            this.Controls.Add(this.btnTraerCustomers);
            this.Name = "frmCustomers";
            this.Text = "frmCustomers";
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTraerCustomers;
        private System.Windows.Forms.DataGridView gridCustomers;
    }
}