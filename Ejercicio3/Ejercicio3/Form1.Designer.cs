namespace Ejercicio3
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
            this.btnAgregarEntrega = new System.Windows.Forms.Button();
            this.btnMostrarResumen = new System.Windows.Forms.Button();
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxResumen = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAgregarEntrega
            // 
            this.btnAgregarEntrega.Location = new System.Drawing.Point(30, 77);
            this.btnAgregarEntrega.Name = "btnAgregarEntrega";
            this.btnAgregarEntrega.Size = new System.Drawing.Size(239, 23);
            this.btnAgregarEntrega.TabIndex = 0;
            this.btnAgregarEntrega.Text = "Agregar Entrega";
            this.btnAgregarEntrega.UseVisualStyleBackColor = true;
            this.btnAgregarEntrega.Click += new System.EventHandler(this.btnAgregarEntrega_Click);
            // 
            // btnMostrarResumen
            // 
            this.btnMostrarResumen.Location = new System.Drawing.Point(30, 148);
            this.btnMostrarResumen.Name = "btnMostrarResumen";
            this.btnMostrarResumen.Size = new System.Drawing.Size(239, 23);
            this.btnMostrarResumen.TabIndex = 1;
            this.btnMostrarResumen.Text = "Mostrar Resumen";
            this.btnMostrarResumen.UseVisualStyleBackColor = true;
            // 
            // txtVendedor
            // 
            this.txtVendedor.Location = new System.Drawing.Point(455, 80);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.Size = new System.Drawing.Size(100, 20);
            this.txtVendedor.TabIndex = 2;
            this.txtVendedor.TextChanged += new System.EventHandler(this.txtVendedor_TextChanged);
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(455, 151);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(100, 20);
            this.txtMonto.TabIndex = 3;
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(455, 116);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(100, 20);
            this.txtProducto.TabIndex = 4;
            this.txtProducto.TextChanged += new System.EventHandler(this.txtProducto_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(384, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Vendedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Monto";
            // 
            // listBoxResumen
            // 
            this.listBoxResumen.FormattingEnabled = true;
            this.listBoxResumen.Location = new System.Drawing.Point(56, 207);
            this.listBoxResumen.Name = "listBoxResumen";
            this.listBoxResumen.Size = new System.Drawing.Size(603, 95);
            this.listBoxResumen.TabIndex = 8;
            this.listBoxResumen.SelectedIndexChanged += new System.EventHandler(this.listBoxResumen_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxResumen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.txtVendedor);
            this.Controls.Add(this.btnMostrarResumen);
            this.Controls.Add(this.btnAgregarEntrega);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarEntrega;
        private System.Windows.Forms.Button btnMostrarResumen;
        private System.Windows.Forms.TextBox txtVendedor;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxResumen;
    }
}

