namespace CapaPresentacion
{
    partial class RepartoPedido
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
            this.label_codigo = new System.Windows.Forms.Label();
            this.label_cliente = new System.Windows.Forms.Label();
            this.label_direccion = new System.Windows.Forms.Label();
            this.boton_elegir = new System.Windows.Forms.Button();
            this.panel_1 = new System.Windows.Forms.Panel();
            this.panel_1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_codigo
            // 
            this.label_codigo.AutoSize = true;
            this.label_codigo.Location = new System.Drawing.Point(66, 14);
            this.label_codigo.Name = "label_codigo";
            this.label_codigo.Size = new System.Drawing.Size(38, 13);
            this.label_codigo.TabIndex = 0;
            this.label_codigo.Text = "#0000";
            // 
            // label_cliente
            // 
            this.label_cliente.AutoSize = true;
            this.label_cliente.Location = new System.Drawing.Point(12, 10);
            this.label_cliente.Name = "label_cliente";
            this.label_cliente.Size = new System.Drawing.Size(84, 13);
            this.label_cliente.TabIndex = 1;
            this.label_cliente.Text = "Nombre Apellido";
            // 
            // label_direccion
            // 
            this.label_direccion.AutoSize = true;
            this.label_direccion.Location = new System.Drawing.Point(12, 37);
            this.label_direccion.Name = "label_direccion";
            this.label_direccion.Size = new System.Drawing.Size(83, 13);
            this.label_direccion.TabIndex = 2;
            this.label_direccion.Text = "Calle Calle 1234";
            // 
            // boton_elegir
            // 
            this.boton_elegir.Location = new System.Drawing.Point(51, 110);
            this.boton_elegir.Name = "boton_elegir";
            this.boton_elegir.Size = new System.Drawing.Size(75, 23);
            this.boton_elegir.TabIndex = 3;
            this.boton_elegir.Text = "Acciones";
            this.boton_elegir.UseVisualStyleBackColor = true;
            // 
            // panel_1
            // 
            this.panel_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_1.Controls.Add(this.label_cliente);
            this.panel_1.Controls.Add(this.label_direccion);
            this.panel_1.Location = new System.Drawing.Point(21, 30);
            this.panel_1.Name = "panel_1";
            this.panel_1.Size = new System.Drawing.Size(138, 74);
            this.panel_1.TabIndex = 4;
            // 
            // RepartoPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel_1);
            this.Controls.Add(this.boton_elegir);
            this.Controls.Add(this.label_codigo);
            this.Name = "RepartoPedido";
            this.Size = new System.Drawing.Size(180, 153);
            this.panel_1.ResumeLayout(false);
            this.panel_1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_codigo;
        private System.Windows.Forms.Label label_cliente;
        private System.Windows.Forms.Label label_direccion;
        private System.Windows.Forms.Button boton_elegir;
        private System.Windows.Forms.Panel panel_1;
    }
}
