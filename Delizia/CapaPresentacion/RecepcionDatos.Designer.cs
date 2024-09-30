namespace CapaPresentacion
{
    partial class RecepcionDatos
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
            this.boton_retroceder = new System.Windows.Forms.Button();
            this.boton_avanzar = new System.Windows.Forms.Button();
            this.panel_datos = new System.Windows.Forms.Panel();
            this.label_nombre = new System.Windows.Forms.Label();
            this.label_telefono = new System.Windows.Forms.Label();
            this.label_calle = new System.Windows.Forms.Label();
            this.label_puerta = new System.Windows.Forms.Label();
            this.label_detalle = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_calle = new System.Windows.Forms.TextBox();
            this.txt_puerta = new System.Windows.Forms.TextBox();
            this.txt_detalle = new System.Windows.Forms.TextBox();
            this.panel_datos.SuspendLayout();
            this.SuspendLayout();
            // 
            // boton_retroceder
            // 
            this.boton_retroceder.Location = new System.Drawing.Point(3, 400);
            this.boton_retroceder.Name = "boton_retroceder";
            this.boton_retroceder.Size = new System.Drawing.Size(75, 23);
            this.boton_retroceder.TabIndex = 0;
            this.boton_retroceder.Text = "Atrás";
            this.boton_retroceder.UseVisualStyleBackColor = true;
            this.boton_retroceder.Click += new System.EventHandler(this.boton_retroceder_Click);
            // 
            // boton_avanzar
            // 
            this.boton_avanzar.Location = new System.Drawing.Point(698, 400);
            this.boton_avanzar.Name = "boton_avanzar";
            this.boton_avanzar.Size = new System.Drawing.Size(75, 23);
            this.boton_avanzar.TabIndex = 1;
            this.boton_avanzar.Text = "Siguiente";
            this.boton_avanzar.UseVisualStyleBackColor = true;
            this.boton_avanzar.Click += new System.EventHandler(this.boton_avanzar_Click);
            // 
            // panel_datos
            // 
            this.panel_datos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_datos.Controls.Add(this.txt_detalle);
            this.panel_datos.Controls.Add(this.txt_puerta);
            this.panel_datos.Controls.Add(this.txt_calle);
            this.panel_datos.Controls.Add(this.txt_telefono);
            this.panel_datos.Controls.Add(this.txt_nombre);
            this.panel_datos.Controls.Add(this.label_detalle);
            this.panel_datos.Controls.Add(this.label_puerta);
            this.panel_datos.Controls.Add(this.label_calle);
            this.panel_datos.Controls.Add(this.label_telefono);
            this.panel_datos.Controls.Add(this.label_nombre);
            this.panel_datos.Location = new System.Drawing.Point(108, 40);
            this.panel_datos.Name = "panel_datos";
            this.panel_datos.Size = new System.Drawing.Size(560, 314);
            this.panel_datos.TabIndex = 2;
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.Location = new System.Drawing.Point(112, 57);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(44, 13);
            this.label_nombre.TabIndex = 0;
            this.label_nombre.Text = "Nombre";
            this.label_nombre.Click += new System.EventHandler(this.label_nombre_Click);
            // 
            // label_telefono
            // 
            this.label_telefono.AutoSize = true;
            this.label_telefono.Location = new System.Drawing.Point(112, 96);
            this.label_telefono.Name = "label_telefono";
            this.label_telefono.Size = new System.Drawing.Size(49, 13);
            this.label_telefono.TabIndex = 1;
            this.label_telefono.Text = "Teléfono";
            // 
            // label_calle
            // 
            this.label_calle.AutoSize = true;
            this.label_calle.Location = new System.Drawing.Point(112, 135);
            this.label_calle.Name = "label_calle";
            this.label_calle.Size = new System.Drawing.Size(30, 13);
            this.label_calle.TabIndex = 2;
            this.label_calle.Text = "Calle";
            // 
            // label_puerta
            // 
            this.label_puerta.AutoSize = true;
            this.label_puerta.Location = new System.Drawing.Point(112, 174);
            this.label_puerta.Name = "label_puerta";
            this.label_puerta.Size = new System.Drawing.Size(92, 13);
            this.label_puerta.TabIndex = 3;
            this.label_puerta.Text = "Número de puerta";
            // 
            // label_detalle
            // 
            this.label_detalle.AutoSize = true;
            this.label_detalle.Location = new System.Drawing.Point(112, 213);
            this.label_detalle.Name = "label_detalle";
            this.label_detalle.Size = new System.Drawing.Size(40, 13);
            this.label_detalle.TabIndex = 4;
            this.label_detalle.Text = "Detalle";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(112, 73);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(336, 20);
            this.txt_nombre.TabIndex = 5;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(112, 112);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(336, 20);
            this.txt_telefono.TabIndex = 6;
            // 
            // txt_calle
            // 
            this.txt_calle.Location = new System.Drawing.Point(112, 151);
            this.txt_calle.Name = "txt_calle";
            this.txt_calle.Size = new System.Drawing.Size(336, 20);
            this.txt_calle.TabIndex = 7;
            // 
            // txt_puerta
            // 
            this.txt_puerta.Location = new System.Drawing.Point(112, 190);
            this.txt_puerta.Name = "txt_puerta";
            this.txt_puerta.Size = new System.Drawing.Size(336, 20);
            this.txt_puerta.TabIndex = 8;
            // 
            // txt_detalle
            // 
            this.txt_detalle.Location = new System.Drawing.Point(112, 229);
            this.txt_detalle.Name = "txt_detalle";
            this.txt_detalle.Size = new System.Drawing.Size(336, 20);
            this.txt_detalle.TabIndex = 9;
            // 
            // RecepcionDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_datos);
            this.Controls.Add(this.boton_avanzar);
            this.Controls.Add(this.boton_retroceder);
            this.Name = "RecepcionDatos";
            this.Size = new System.Drawing.Size(776, 426);
            this.panel_datos.ResumeLayout(false);
            this.panel_datos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button boton_retroceder;
        private System.Windows.Forms.Button boton_avanzar;
        private System.Windows.Forms.Panel panel_datos;
        private System.Windows.Forms.TextBox txt_detalle;
        private System.Windows.Forms.TextBox txt_puerta;
        private System.Windows.Forms.TextBox txt_calle;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label_detalle;
        private System.Windows.Forms.Label label_puerta;
        private System.Windows.Forms.Label label_calle;
        private System.Windows.Forms.Label label_telefono;
        private System.Windows.Forms.Label label_nombre;
    }
}
