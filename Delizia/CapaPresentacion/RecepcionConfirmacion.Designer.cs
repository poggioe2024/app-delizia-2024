namespace CapaPresentacion
{
    partial class RecepcionConfirmacion
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
            this.boton_confirmar = new System.Windows.Forms.Button();
            this.panel_datos = new System.Windows.Forms.Panel();
            this.txt_detalle = new System.Windows.Forms.TextBox();
            this.txt_puerta = new System.Windows.Forms.TextBox();
            this.txt_calle = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label_detalle = new System.Windows.Forms.Label();
            this.label_puerta = new System.Windows.Forms.Label();
            this.label_calle = new System.Windows.Forms.Label();
            this.label_telefono = new System.Windows.Forms.Label();
            this.label_nombre = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_productos = new System.Windows.Forms.Panel();
            this.panel_datos.SuspendLayout();
            this.panel1.SuspendLayout();
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
            // boton_confirmar
            // 
            this.boton_confirmar.Location = new System.Drawing.Point(698, 400);
            this.boton_confirmar.Name = "boton_confirmar";
            this.boton_confirmar.Size = new System.Drawing.Size(75, 23);
            this.boton_confirmar.TabIndex = 1;
            this.boton_confirmar.Text = "Confirmar";
            this.boton_confirmar.UseVisualStyleBackColor = true;
            this.boton_confirmar.Click += new System.EventHandler(this.boton_confirmar_Click);
            // 
            // panel_datos
            // 
            this.panel_datos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_datos.Controls.Add(this.panel_productos);
            this.panel_datos.Controls.Add(this.panel1);
            this.panel_datos.Location = new System.Drawing.Point(108, 40);
            this.panel_datos.Name = "panel_datos";
            this.panel_datos.Size = new System.Drawing.Size(560, 314);
            this.panel_datos.TabIndex = 3;
            // 
            // txt_detalle
            // 
            this.txt_detalle.Location = new System.Drawing.Point(58, 221);
            this.txt_detalle.Name = "txt_detalle";
            this.txt_detalle.Size = new System.Drawing.Size(134, 20);
            this.txt_detalle.TabIndex = 9;
            // 
            // txt_puerta
            // 
            this.txt_puerta.Location = new System.Drawing.Point(58, 182);
            this.txt_puerta.Name = "txt_puerta";
            this.txt_puerta.Size = new System.Drawing.Size(134, 20);
            this.txt_puerta.TabIndex = 8;
            // 
            // txt_calle
            // 
            this.txt_calle.Location = new System.Drawing.Point(58, 143);
            this.txt_calle.Name = "txt_calle";
            this.txt_calle.Size = new System.Drawing.Size(134, 20);
            this.txt_calle.TabIndex = 7;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(58, 104);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(135, 20);
            this.txt_telefono.TabIndex = 6;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(58, 65);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(134, 20);
            this.txt_nombre.TabIndex = 5;
            // 
            // label_detalle
            // 
            this.label_detalle.AutoSize = true;
            this.label_detalle.Location = new System.Drawing.Point(55, 205);
            this.label_detalle.Name = "label_detalle";
            this.label_detalle.Size = new System.Drawing.Size(40, 13);
            this.label_detalle.TabIndex = 4;
            this.label_detalle.Text = "Detalle";
            // 
            // label_puerta
            // 
            this.label_puerta.AutoSize = true;
            this.label_puerta.Location = new System.Drawing.Point(55, 166);
            this.label_puerta.Name = "label_puerta";
            this.label_puerta.Size = new System.Drawing.Size(92, 13);
            this.label_puerta.TabIndex = 3;
            this.label_puerta.Text = "Número de puerta";
            // 
            // label_calle
            // 
            this.label_calle.AutoSize = true;
            this.label_calle.Location = new System.Drawing.Point(55, 127);
            this.label_calle.Name = "label_calle";
            this.label_calle.Size = new System.Drawing.Size(30, 13);
            this.label_calle.TabIndex = 2;
            this.label_calle.Text = "Calle";
            // 
            // label_telefono
            // 
            this.label_telefono.AutoSize = true;
            this.label_telefono.Location = new System.Drawing.Point(55, 88);
            this.label_telefono.Name = "label_telefono";
            this.label_telefono.Size = new System.Drawing.Size(49, 13);
            this.label_telefono.TabIndex = 1;
            this.label_telefono.Text = "Teléfono";
            this.label_telefono.Click += new System.EventHandler(this.label_telefono_Click);
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.Location = new System.Drawing.Point(55, 49);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(44, 13);
            this.label_nombre.TabIndex = 0;
            this.label_nombre.Text = "Nombre";
            this.label_nombre.Click += new System.EventHandler(this.label_nombre_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label_nombre);
            this.panel1.Controls.Add(this.txt_detalle);
            this.panel1.Controls.Add(this.label_telefono);
            this.panel1.Controls.Add(this.txt_puerta);
            this.panel1.Controls.Add(this.label_calle);
            this.panel1.Controls.Add(this.txt_calle);
            this.panel1.Controls.Add(this.label_puerta);
            this.panel1.Controls.Add(this.txt_telefono);
            this.panel1.Controls.Add(this.label_detalle);
            this.panel1.Controls.Add(this.txt_nombre);
            this.panel1.Location = new System.Drawing.Point(305, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 306);
            this.panel1.TabIndex = 10;
            // 
            // panel_productos
            // 
            this.panel_productos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_productos.Location = new System.Drawing.Point(3, 3);
            this.panel_productos.Name = "panel_productos";
            this.panel_productos.Size = new System.Drawing.Size(250, 306);
            this.panel_productos.TabIndex = 11;
            // 
            // RecepcionConfirmacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_datos);
            this.Controls.Add(this.boton_confirmar);
            this.Controls.Add(this.boton_retroceder);
            this.Name = "RecepcionConfirmacion";
            this.Size = new System.Drawing.Size(776, 426);
            this.panel_datos.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button boton_retroceder;
        private System.Windows.Forms.Button boton_confirmar;
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
        private System.Windows.Forms.Panel panel_productos;
        private System.Windows.Forms.Panel panel1;
    }
}
