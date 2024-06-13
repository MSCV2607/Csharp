namespace Mensajes
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.InicioSesion = new System.Windows.Forms.Button();
            this.Registrarse = new System.Windows.Forms.Button();
            this.USUARIOX = new System.Windows.Forms.TextBox();
            this.CONTRASENA = new System.Windows.Forms.TextBox();
            this.CIERRA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InicioSesion
            // 
            this.InicioSesion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InicioSesion.BackColor = System.Drawing.Color.LightGreen;
            this.InicioSesion.Location = new System.Drawing.Point(38, 83);
            this.InicioSesion.Name = "InicioSesion";
            this.InicioSesion.Size = new System.Drawing.Size(143, 31);
            this.InicioSesion.TabIndex = 0;
            this.InicioSesion.Text = "Iniciar";
            this.InicioSesion.UseVisualStyleBackColor = false;
            this.InicioSesion.Click += new System.EventHandler(this.InicioSesion_Click);
            // 
            // Registrarse
            // 
            this.Registrarse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Registrarse.BackColor = System.Drawing.Color.Cyan;
            this.Registrarse.Location = new System.Drawing.Point(38, 120);
            this.Registrarse.Name = "Registrarse";
            this.Registrarse.Size = new System.Drawing.Size(143, 31);
            this.Registrarse.TabIndex = 1;
            this.Registrarse.Text = "Registrarse";
            this.Registrarse.UseVisualStyleBackColor = false;
            this.Registrarse.Click += new System.EventHandler(this.Registrarse_Click);
            // 
            // USUARIOX
            // 
            this.USUARIOX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.USUARIOX.Location = new System.Drawing.Point(38, 31);
            this.USUARIOX.Name = "USUARIOX";
            this.USUARIOX.Size = new System.Drawing.Size(143, 20);
            this.USUARIOX.TabIndex = 2;
            this.USUARIOX.Text = "USUARIO";
            this.USUARIOX.TextChanged += new System.EventHandler(this.USUARIO_TextChanged);
            // 
            // CONTRASENA
            // 
            this.CONTRASENA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CONTRASENA.Location = new System.Drawing.Point(38, 57);
            this.CONTRASENA.Name = "CONTRASENA";
            this.CONTRASENA.Size = new System.Drawing.Size(143, 20);
            this.CONTRASENA.TabIndex = 3;
            this.CONTRASENA.Text = "CONTRASEÑA";
            this.CONTRASENA.TextChanged += new System.EventHandler(this.CONTRASENA_TextChanged);
            // 
            // CIERRA
            // 
            this.CIERRA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CIERRA.BackColor = System.Drawing.Color.IndianRed;
            this.CIERRA.Location = new System.Drawing.Point(91, 157);
            this.CIERRA.Name = "CIERRA";
            this.CIERRA.Size = new System.Drawing.Size(37, 32);
            this.CIERRA.TabIndex = 4;
            this.CIERRA.Text = "X";
            this.CIERRA.UseVisualStyleBackColor = false;
            this.CIERRA.Click += new System.EventHandler(this.CIERRA_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(225, 206);
            this.Controls.Add(this.CIERRA);
            this.Controls.Add(this.CONTRASENA);
            this.Controls.Add(this.USUARIOX);
            this.Controls.Add(this.Registrarse);
            this.Controls.Add(this.InicioSesion);
            this.Name = "Form1";
            this.Text = "INICIO DE SESION";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button InicioSesion;
        private System.Windows.Forms.Button Registrarse;
        private System.Windows.Forms.TextBox USUARIOX;
        private System.Windows.Forms.TextBox CONTRASENA;
        private System.Windows.Forms.Button CIERRA;
    }
}

