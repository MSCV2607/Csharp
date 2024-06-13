namespace Escribir_y_leer
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
            this.Escribir = new System.Windows.Forms.Button();
            this.Leer = new System.Windows.Forms.Button();
            this.LISTA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Escribir
            // 
            this.Escribir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Escribir.Location = new System.Drawing.Point(112, 77);
            this.Escribir.Name = "Escribir";
            this.Escribir.Size = new System.Drawing.Size(130, 79);
            this.Escribir.TabIndex = 0;
            this.Escribir.Text = "Escribir";
            this.Escribir.UseVisualStyleBackColor = true;
            this.Escribir.Click += new System.EventHandler(this.Escribir_Click);
            // 
            // Leer
            // 
            this.Leer.Location = new System.Drawing.Point(112, 162);
            this.Leer.Name = "Leer";
            this.Leer.Size = new System.Drawing.Size(130, 73);
            this.Leer.TabIndex = 1;
            this.Leer.Text = "Leer";
            this.Leer.UseVisualStyleBackColor = true;
            this.Leer.Click += new System.EventHandler(this.Leer_Click);
            // 
            // LISTA
            // 
            this.LISTA.Location = new System.Drawing.Point(112, 241);
            this.LISTA.Name = "LISTA";
            this.LISTA.Size = new System.Drawing.Size(130, 73);
            this.LISTA.TabIndex = 2;
            this.LISTA.Text = "LISTA";
            this.LISTA.UseVisualStyleBackColor = true;
            this.LISTA.Click += new System.EventHandler(this.LISTA_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 399);
            this.Controls.Add(this.LISTA);
            this.Controls.Add(this.Leer);
            this.Controls.Add(this.Escribir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Escribir;
        private System.Windows.Forms.Button Leer;
        private System.Windows.Forms.Button LISTA;
    }
}

