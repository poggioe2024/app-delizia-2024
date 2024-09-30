namespace CapaPresentacion
{
    partial class RecepcionMenu
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
            this.boton_salir = new System.Windows.Forms.Button();
            this.boton_pedido = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // boton_salir
            // 
            this.boton_salir.Location = new System.Drawing.Point(3, 33);
            this.boton_salir.Name = "boton_salir";
            this.boton_salir.Size = new System.Drawing.Size(142, 23);
            this.boton_salir.TabIndex = 3;
            this.boton_salir.Text = "Salir";
            this.boton_salir.UseVisualStyleBackColor = true;
            this.boton_salir.Click += new System.EventHandler(this.boton_salir_Click);
            // 
            // boton_pedido
            // 
            this.boton_pedido.Location = new System.Drawing.Point(3, 3);
            this.boton_pedido.Name = "boton_pedido";
            this.boton_pedido.Size = new System.Drawing.Size(142, 23);
            this.boton_pedido.TabIndex = 2;
            this.boton_pedido.Text = "Nuevo Pedido";
            this.boton_pedido.UseVisualStyleBackColor = true;
            this.boton_pedido.Click += new System.EventHandler(this.boton_pedido_Click);
            // 
            // RecepcionMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.Controls.Add(this.boton_salir);
            this.Controls.Add(this.boton_pedido);
            this.Name = "RecepcionMenu";
            this.Size = new System.Drawing.Size(776, 426);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button boton_salir;
        private System.Windows.Forms.Button boton_pedido;
    }
}
