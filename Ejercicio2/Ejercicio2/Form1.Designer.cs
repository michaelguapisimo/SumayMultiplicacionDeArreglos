namespace Ejercicio2
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
            this.btnAsignarAsiento = new System.Windows.Forms.Button();
            this.rbFumar = new System.Windows.Forms.RadioButton();
            this.rbNoFumar = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnAsignarAsiento
            // 
            this.btnAsignarAsiento.Location = new System.Drawing.Point(174, 144);
            this.btnAsignarAsiento.Name = "btnAsignarAsiento";
            this.btnAsignarAsiento.Size = new System.Drawing.Size(75, 23);
            this.btnAsignarAsiento.TabIndex = 0;
            this.btnAsignarAsiento.Text = "Asignar";
            this.btnAsignarAsiento.UseVisualStyleBackColor = true;
            this.btnAsignarAsiento.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbFumar
            // 
            this.rbFumar.AutoSize = true;
            this.rbFumar.Location = new System.Drawing.Point(358, 92);
            this.rbFumar.Name = "rbFumar";
            this.rbFumar.Size = new System.Drawing.Size(54, 17);
            this.rbFumar.TabIndex = 1;
            this.rbFumar.TabStop = true;
            this.rbFumar.Text = "Fumar";
            this.rbFumar.UseVisualStyleBackColor = true;
            // 
            // rbNoFumar
            // 
            this.rbNoFumar.AutoSize = true;
            this.rbNoFumar.Location = new System.Drawing.Point(358, 217);
            this.rbNoFumar.Name = "rbNoFumar";
            this.rbNoFumar.Size = new System.Drawing.Size(71, 17);
            this.rbNoFumar.TabIndex = 2;
            this.rbNoFumar.TabStop = true;
            this.rbNoFumar.Text = "No Fumar";
            this.rbNoFumar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbNoFumar);
            this.Controls.Add(this.rbFumar);
            this.Controls.Add(this.btnAsignarAsiento);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAsignarAsiento;
        private System.Windows.Forms.RadioButton rbFumar;
        private System.Windows.Forms.RadioButton rbNoFumar;
    }
}

