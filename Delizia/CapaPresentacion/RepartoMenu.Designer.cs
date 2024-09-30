namespace CapaPresentacion
{
    partial class RepartoMenu
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
            this.boton_ver = new System.Windows.Forms.Button();
            this.boton_seleccion = new System.Windows.Forms.Button();
            this.boton_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // boton_ver
            // 
            this.boton_ver.Location = new System.Drawing.Point(3, 3);
            this.boton_ver.Name = "boton_ver";
            this.boton_ver.Size = new System.Drawing.Size(117, 23);
            this.boton_ver.TabIndex = 0;
            this.boton_ver.Text = "Mis pedidos";
            this.boton_ver.UseVisualStyleBackColor = true;
            this.boton_ver.Click += new System.EventHandler(this.boton_ver_Click);
            // 
            // boton_seleccion
            // 
            this.boton_seleccion.Location = new System.Drawing.Point(3, 32);
            this.boton_seleccion.Name = "boton_seleccion";
            this.boton_seleccion.Size = new System.Drawing.Size(117, 23);
            this.boton_seleccion.TabIndex = 1;
            this.boton_seleccion.Text = "Elegir pedidos";
            this.boton_seleccion.UseVisualStyleBackColor = true;
            this.boton_seleccion.Click += new System.EventHandler(this.boton_seleccion_Click);
            // 
            // boton_salir
            // 
            this.boton_salir.Location = new System.Drawing.Point(4, 62);
            this.boton_salir.Name = "boton_salir";
            this.boton_salir.Size = new System.Drawing.Size(116, 23);
            this.boton_salir.TabIndex = 2;
            this.boton_salir.Text = "Salir";
            this.boton_salir.UseVisualStyleBackColor = true;
            this.boton_salir.Click += new System.EventHandler(this.boton_salir_Click);
            // 
            // RepartoMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.boton_salir);
            this.Controls.Add(this.boton_seleccion);
            this.Controls.Add(this.boton_ver);
            this.Name = "RepartoMenu";
            this.Size = new System.Drawing.Size(776, 426);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button boton_ver;
        private System.Windows.Forms.Button boton_seleccion;
        private System.Windows.Forms.Button boton_salir;
    }
}
