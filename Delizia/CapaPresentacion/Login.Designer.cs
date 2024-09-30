namespace CapaPresentacion
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.boton_cancelar = new System.Windows.Forms.Button();
            this.boton_ingresar = new System.Windows.Forms.Button();
            this.txt_cedula = new System.Windows.Forms.TextBox();
            this.txt_contrasena = new System.Windows.Forms.TextBox();
            this.label_cedula = new System.Windows.Forms.Label();
            this.label_pass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // boton_cancelar
            // 
            this.boton_cancelar.Location = new System.Drawing.Point(299, 293);
            this.boton_cancelar.Name = "boton_cancelar";
            this.boton_cancelar.Size = new System.Drawing.Size(169, 23);
            this.boton_cancelar.TabIndex = 0;
            this.boton_cancelar.Text = "Cancelar";
            this.boton_cancelar.UseVisualStyleBackColor = true;
            this.boton_cancelar.Click += new System.EventHandler(this.boton_cancelar_Click);
            // 
            // boton_ingresar
            // 
            this.boton_ingresar.Location = new System.Drawing.Point(299, 264);
            this.boton_ingresar.Name = "boton_ingresar";
            this.boton_ingresar.Size = new System.Drawing.Size(169, 23);
            this.boton_ingresar.TabIndex = 1;
            this.boton_ingresar.Text = "Ingresar";
            this.boton_ingresar.UseVisualStyleBackColor = true;
            this.boton_ingresar.Click += new System.EventHandler(this.boton_ingresar_Click);
            // 
            // txt_cedula
            // 
            this.txt_cedula.Location = new System.Drawing.Point(299, 193);
            this.txt_cedula.Name = "txt_cedula";
            this.txt_cedula.Size = new System.Drawing.Size(169, 20);
            this.txt_cedula.TabIndex = 2;
            this.txt_cedula.TextChanged += new System.EventHandler(this.txt_cedula_TextChanged);
            // 
            // txt_contrasena
            // 
            this.txt_contrasena.Location = new System.Drawing.Point(299, 238);
            this.txt_contrasena.Name = "txt_contrasena";
            this.txt_contrasena.Size = new System.Drawing.Size(169, 20);
            this.txt_contrasena.TabIndex = 3;
            // 
            // label_cedula
            // 
            this.label_cedula.AutoSize = true;
            this.label_cedula.Location = new System.Drawing.Point(299, 174);
            this.label_cedula.Name = "label_cedula";
            this.label_cedula.Size = new System.Drawing.Size(62, 13);
            this.label_cedula.TabIndex = 4;
            this.label_cedula.Text = "Documento";
            this.label_cedula.Click += new System.EventHandler(this.label_cedula_Click);
            // 
            // label_pass
            // 
            this.label_pass.AutoSize = true;
            this.label_pass.Location = new System.Drawing.Point(299, 219);
            this.label_pass.Name = "label_pass";
            this.label_pass.Size = new System.Drawing.Size(61, 13);
            this.label_pass.TabIndex = 5;
            this.label_pass.Text = "Contraseña";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_pass);
            this.Controls.Add(this.label_cedula);
            this.Controls.Add(this.txt_contrasena);
            this.Controls.Add(this.txt_cedula);
            this.Controls.Add(this.boton_ingresar);
            this.Controls.Add(this.boton_cancelar);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button boton_cancelar;
        private System.Windows.Forms.Button boton_ingresar;
        private System.Windows.Forms.TextBox txt_cedula;
        private System.Windows.Forms.TextBox txt_contrasena;
        private System.Windows.Forms.Label label_cedula;
        private System.Windows.Forms.Label label_pass;
    }
}