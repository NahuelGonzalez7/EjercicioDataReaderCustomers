
namespace WindowsDataReader
{
    partial class frmException
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
            this.btnPrueba = new System.Windows.Forms.Button();
            this.btnDemoExceptionSQL = new System.Windows.Forms.Button();
            this.btnThrow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPrueba
            // 
            this.btnPrueba.Location = new System.Drawing.Point(145, 77);
            this.btnPrueba.Name = "btnPrueba";
            this.btnPrueba.Size = new System.Drawing.Size(161, 23);
            this.btnPrueba.TabIndex = 0;
            this.btnPrueba.Text = "Prueba de Exception";
            this.btnPrueba.UseVisualStyleBackColor = true;
            this.btnPrueba.Click += new System.EventHandler(this.btnPrueba_Click);
            // 
            // btnDemoExceptionSQL
            // 
            this.btnDemoExceptionSQL.Location = new System.Drawing.Point(145, 122);
            this.btnDemoExceptionSQL.Name = "btnDemoExceptionSQL";
            this.btnDemoExceptionSQL.Size = new System.Drawing.Size(161, 23);
            this.btnDemoExceptionSQL.TabIndex = 1;
            this.btnDemoExceptionSQL.Text = "Conectar a SQL";
            this.btnDemoExceptionSQL.UseVisualStyleBackColor = true;
            this.btnDemoExceptionSQL.Click += new System.EventHandler(this.btnDemoExceptionSQL_Click);
            // 
            // btnThrow
            // 
            this.btnThrow.Location = new System.Drawing.Point(145, 170);
            this.btnThrow.Name = "btnThrow";
            this.btnThrow.Size = new System.Drawing.Size(161, 23);
            this.btnThrow.TabIndex = 2;
            this.btnThrow.Text = "Demo Throw";
            this.btnThrow.UseVisualStyleBackColor = true;
            this.btnThrow.Click += new System.EventHandler(this.btnThrow_Click);
            // 
            // frmException
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThrow);
            this.Controls.Add(this.btnDemoExceptionSQL);
            this.Controls.Add(this.btnPrueba);
            this.Name = "frmException";
            this.Text = "frmException";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrueba;
        private System.Windows.Forms.Button btnDemoExceptionSQL;
        private System.Windows.Forms.Button btnThrow;
    }
}