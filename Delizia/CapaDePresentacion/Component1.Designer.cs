namespace CapaDePresentacion
{
    partial class Component1
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
            this.producto = new System.Windows.Forms.Panel();
            this.restar = new System.Windows.Forms.Button();
            this.agregar = new System.Windows.Forms.Button();
            this.cantidad_producto = new System.Windows.Forms.Label();
            this.precio_producto = new System.Windows.Forms.Label();
            this.nombre_producto = new System.Windows.Forms.Label();
            this.foto_producto = new System.Windows.Forms.PictureBox();
            this.producto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foto_producto)).BeginInit();
            // 
            // producto
            // 
            this.producto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.producto.Controls.Add(this.restar);
            this.producto.Controls.Add(this.agregar);
            this.producto.Controls.Add(this.cantidad_producto);
            this.producto.Controls.Add(this.precio_producto);
            this.producto.Controls.Add(this.nombre_producto);
            this.producto.Controls.Add(this.foto_producto);
            this.producto.Location = new System.Drawing.Point(3, 3);
            this.producto.Name = "producto";
            this.producto.Size = new System.Drawing.Size(200, 237);
            this.producto.TabIndex = 0;
            // 
            // restar
            // 
            this.restar.Location = new System.Drawing.Point(22, 205);
            this.restar.Name = "restar";
            this.restar.Size = new System.Drawing.Size(37, 23);
            this.restar.TabIndex = 4;
            this.restar.Text = "-";
            this.restar.UseVisualStyleBackColor = true;
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(140, 205);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(37, 23);
            this.agregar.TabIndex = 1;
            this.agregar.Text = "+";
            this.agregar.UseVisualStyleBackColor = true;
            // 
            // cantidad_producto
            // 
            this.cantidad_producto.AutoSize = true;
            this.cantidad_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cantidad_producto.Location = new System.Drawing.Point(73, 208);
            this.cantidad_producto.Name = "cantidad_producto";
            this.cantidad_producto.Size = new System.Drawing.Size(56, 15);
            this.cantidad_producto.TabIndex = 3;
            this.cantidad_producto.Text = "Cantidad";
            // 
            // precio_producto
            // 
            this.precio_producto.AutoSize = true;
            this.precio_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.precio_producto.Location = new System.Drawing.Point(77, 185);
            this.precio_producto.Name = "precio_producto";
            this.precio_producto.Size = new System.Drawing.Size(42, 15);
            this.precio_producto.TabIndex = 2;
            this.precio_producto.Text = "Precio";
            // 
            // nombre_producto
            // 
            this.nombre_producto.AutoSize = true;
            this.nombre_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.nombre_producto.Location = new System.Drawing.Point(73, 161);
            this.nombre_producto.Name = "nombre_producto";
            this.nombre_producto.Size = new System.Drawing.Size(52, 15);
            this.nombre_producto.TabIndex = 1;
            this.nombre_producto.Text = "Nombre";
            // 
            // foto_producto
            // 
            this.foto_producto.Location = new System.Drawing.Point(22, 3);
            this.foto_producto.Name = "foto_producto";
            this.foto_producto.Size = new System.Drawing.Size(155, 155);
            this.foto_producto.TabIndex = 0;
            this.foto_producto.TabStop = false;
            this.producto.ResumeLayout(false);
            this.producto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foto_producto)).EndInit();

        }

        #endregion

        private System.Windows.Forms.Panel producto;
        private System.Windows.Forms.Button restar;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.Label cantidad_producto;
        private System.Windows.Forms.Label precio_producto;
        private System.Windows.Forms.Label nombre_producto;
        private System.Windows.Forms.PictureBox foto_producto;
    }
}
