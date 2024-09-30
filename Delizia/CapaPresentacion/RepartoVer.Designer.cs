namespace CapaPresentacion
{
    partial class RepartoVer
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
            this.repartoPedido1 = new CapaPresentacion.RepartoPedido();
            this.repartoPedido2 = new CapaPresentacion.RepartoPedido();
            this.repartoPedido3 = new CapaPresentacion.RepartoPedido();
            this.panel_pedidos = new System.Windows.Forms.Panel();
            this.boton_retroceder = new System.Windows.Forms.Button();
            this.panel_pedidos.SuspendLayout();
            this.SuspendLayout();
            // 
            // repartoPedido1
            // 
            this.repartoPedido1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.repartoPedido1.Location = new System.Drawing.Point(32, 67);
            this.repartoPedido1.Name = "repartoPedido1";
            this.repartoPedido1.Size = new System.Drawing.Size(180, 153);
            this.repartoPedido1.TabIndex = 0;
            // 
            // repartoPedido2
            // 
            this.repartoPedido2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.repartoPedido2.Location = new System.Drawing.Point(239, 67);
            this.repartoPedido2.Name = "repartoPedido2";
            this.repartoPedido2.Size = new System.Drawing.Size(180, 153);
            this.repartoPedido2.TabIndex = 1;
            // 
            // repartoPedido3
            // 
            this.repartoPedido3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.repartoPedido3.Location = new System.Drawing.Point(441, 67);
            this.repartoPedido3.Name = "repartoPedido3";
            this.repartoPedido3.Size = new System.Drawing.Size(180, 153);
            this.repartoPedido3.TabIndex = 2;
            // 
            // panel_pedidos
            // 
            this.panel_pedidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_pedidos.Controls.Add(this.repartoPedido2);
            this.panel_pedidos.Controls.Add(this.repartoPedido3);
            this.panel_pedidos.Controls.Add(this.repartoPedido1);
            this.panel_pedidos.Location = new System.Drawing.Point(61, 67);
            this.panel_pedidos.Name = "panel_pedidos";
            this.panel_pedidos.Size = new System.Drawing.Size(663, 288);
            this.panel_pedidos.TabIndex = 3;
            // 
            // boton_retroceder
            // 
            this.boton_retroceder.Location = new System.Drawing.Point(3, 3);
            this.boton_retroceder.Name = "boton_retroceder";
            this.boton_retroceder.Size = new System.Drawing.Size(25, 25);
            this.boton_retroceder.TabIndex = 4;
            this.boton_retroceder.Text = "⬅";
            this.boton_retroceder.UseVisualStyleBackColor = true;
            this.boton_retroceder.Click += new System.EventHandler(this.boton_retroceder_Click);
            // 
            // RepartoVer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.boton_retroceder);
            this.Controls.Add(this.panel_pedidos);
            this.Name = "RepartoVer";
            this.Size = new System.Drawing.Size(776, 426);
            this.panel_pedidos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RepartoPedido repartoPedido1;
        private RepartoPedido repartoPedido2;
        private RepartoPedido repartoPedido3;
        private System.Windows.Forms.Panel panel_pedidos;
        private System.Windows.Forms.Button boton_retroceder;
    }
}
