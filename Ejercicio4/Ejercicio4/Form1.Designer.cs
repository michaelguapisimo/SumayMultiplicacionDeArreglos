namespace Ejercicio4
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
            this.btnAgregarVenta = new System.Windows.Forms.Button();
            this.btnMostrarResumen = new System.Windows.Forms.Button();
            this.txtVentasBrutas = new System.Windows.Forms.TextBox();
            this.listBoxResumen = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAgregarVenta
            // 
            this.btnAgregarVenta.Location = new System.Drawing.Point(89, 59);
            this.btnAgregarVenta.Name = "btnAgregarVenta";
            this.btnAgregarVenta.Size = new System.Drawing.Size(157, 23);
            this.btnAgregarVenta.TabIndex = 0;
            this.btnAgregarVenta.Text = "Agregar Venta";
            this.btnAgregarVenta.UseVisualStyleBackColor = true;
            this.btnAgregarVenta.Click += new System.EventHandler(this.btnAgregarVenta_Click);
            // 
            // btnMostrarResumen
            // 
            this.btnMostrarResumen.Location = new System.Drawing.Point(89, 123);
            this.btnMostrarResumen.Name = "btnMostrarResumen";
            this.btnMostrarResumen.Size = new System.Drawing.Size(157, 23);
            this.btnMostrarResumen.TabIndex = 1;
            this.btnMostrarResumen.Text = "Mostrar Resumen";
            this.btnMostrarResumen.UseVisualStyleBackColor = true;
            // 
            // txtVentasBrutas
            // 
            this.txtVentasBrutas.Location = new System.Drawing.Point(408, 82);
            this.txtVentasBrutas.Name = "txtVentasBrutas";
            this.txtVentasBrutas.Size = new System.Drawing.Size(100, 20);
            this.txtVentasBrutas.TabIndex = 2;
            // 
            // listBoxResumen
            // 
            this.listBoxResumen.FormattingEnabled = true;
            this.listBoxResumen.Location = new System.Drawing.Point(300, 147);
            this.listBoxResumen.Name = "listBoxResumen";
            this.listBoxResumen.Size = new System.Drawing.Size(325, 173);
            this.listBoxResumen.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingresar venta bruta";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxResumen);
            this.Controls.Add(this.txtVentasBrutas);
            this.Controls.Add(this.btnMostrarResumen);
            this.Controls.Add(this.btnAgregarVenta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarVenta;
        private System.Windows.Forms.Button btnMostrarResumen;
        private System.Windows.Forms.TextBox txtVentasBrutas;
        private System.Windows.Forms.ListBox listBoxResumen;
        private System.Windows.Forms.Label label1;
    }
}

