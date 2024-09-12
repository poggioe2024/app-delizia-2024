namespace CapaDePresentacion
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
            this.txt_contrasena = new System.Windows.Forms.TextBox();
            this.txt_documento = new System.Windows.Forms.TextBox();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.lbl_contrasena = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.lbl_documento = new System.Windows.Forms.Label();
            this.pan_input = new System.Windows.Forms.Panel();
            this.pan_input.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_contrasena
            // 
            this.txt_contrasena.Location = new System.Drawing.Point(28, 66);
            this.txt_contrasena.Name = "txt_contrasena";
            this.txt_contrasena.Size = new System.Drawing.Size(100, 20);
            this.txt_contrasena.TabIndex = 3;
            // 
            // txt_documento
            // 
            this.txt_documento.Location = new System.Drawing.Point(28, 16);
            this.txt_documento.Name = "txt_documento";
            this.txt_documento.Size = new System.Drawing.Size(100, 20);
            this.txt_documento.TabIndex = 2;
            // 
            // btn_enviar
            // 
            this.btn_enviar.Location = new System.Drawing.Point(79, 92);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(75, 23);
            this.btn_enviar.TabIndex = 4;
            this.btn_enviar.Text = "Enviar";
            this.btn_enviar.UseVisualStyleBackColor = true;
            this.btn_enviar.Click += new System.EventHandler(this.btn_enviar_Click);
            // 
            // lbl_contrasena
            // 
            this.lbl_contrasena.AutoSize = true;
            this.lbl_contrasena.Location = new System.Drawing.Point(25, 50);
            this.lbl_contrasena.Name = "lbl_contrasena";
            this.lbl_contrasena.Size = new System.Drawing.Size(61, 13);
            this.lbl_contrasena.TabIndex = 1;
            this.lbl_contrasena.Text = "Contraseña";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(0, 92);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 5;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // lbl_documento
            // 
            this.lbl_documento.AutoSize = true;
            this.lbl_documento.Location = new System.Drawing.Point(25, 0);
            this.lbl_documento.Name = "lbl_documento";
            this.lbl_documento.Size = new System.Drawing.Size(65, 13);
            this.lbl_documento.TabIndex = 0;
            this.lbl_documento.Text = "Documento:";
            // 
            // pan_input
            // 
            this.pan_input.Controls.Add(this.lbl_documento);
            this.pan_input.Controls.Add(this.btn_cancelar);
            this.pan_input.Controls.Add(this.lbl_contrasena);
            this.pan_input.Controls.Add(this.btn_enviar);
            this.pan_input.Controls.Add(this.txt_documento);
            this.pan_input.Controls.Add(this.txt_contrasena);
            this.pan_input.Location = new System.Drawing.Point(325, 150);
            this.pan_input.Name = "pan_input";
            this.pan_input.Size = new System.Drawing.Size(155, 119);
            this.pan_input.TabIndex = 6;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pan_input);
            this.Name = "Login";
            this.Text = "Login Delizia";
            this.Load += new System.EventHandler(this.Login_Load);
            this.pan_input.ResumeLayout(false);
            this.pan_input.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_contrasena;
        private System.Windows.Forms.TextBox txt_documento;
        private System.Windows.Forms.Button btn_enviar;
        private System.Windows.Forms.Label lbl_contrasena;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label lbl_documento;
        private System.Windows.Forms.Panel pan_input;
    }
}