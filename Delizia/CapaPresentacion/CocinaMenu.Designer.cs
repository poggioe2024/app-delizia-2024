namespace CapaPresentacion
{
    partial class CocinaMenu
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.boton_pedidos = new System.Windows.Forms.Button();
            this.boton_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // boton_pedidos
            // 
            this.boton_pedidos.Location = new System.Drawing.Point(3, 3);
            this.boton_pedidos.Name = "boton_pedidos";
            this.boton_pedidos.Size = new System.Drawing.Size(75, 23);
            this.boton_pedidos.TabIndex = 0;
            this.boton_pedidos.Text = "Ver pedidos";
            this.boton_pedidos.UseVisualStyleBackColor = true;
            this.boton_pedidos.Click += new System.EventHandler(this.boton_pedidos_Click);
            // 
            // boton_salir
            // 
            this.boton_salir.Location = new System.Drawing.Point(3, 32);
            this.boton_salir.Name = "boton_salir";
            this.boton_salir.Size = new System.Drawing.Size(75, 23);
            this.boton_salir.TabIndex = 1;
            this.boton_salir.Text = "Salir";
            this.boton_salir.UseVisualStyleBackColor = true;
            this.boton_salir.Click += new System.EventHandler(this.boton_salir_Click);
            // 
            // CocinaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.boton_salir);
            this.Controls.Add(this.boton_pedidos);
            this.Name = "CocinaMenu";
            this.Size = new System.Drawing.Size(776, 426);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button boton_pedidos;
        private System.Windows.Forms.Button boton_salir;
    }
}
