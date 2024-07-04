namespace Mensajes
{
    partial class Form2
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
            this.PERSONAEN = new System.Windows.Forms.TextBox();
            this.CUERPO = new System.Windows.Forms.TextBox();
            this.ACEPTARE = new System.Windows.Forms.Button();
            this.Bienvenida = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CORREOSENVIADOS = new System.Windows.Forms.ListBox();
            this.GUARDAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PERSONAEN
            // 
            this.PERSONAEN.Location = new System.Drawing.Point(12, 114);
            this.PERSONAEN.Name = "PERSONAEN";
            this.PERSONAEN.Size = new System.Drawing.Size(352, 20);
            this.PERSONAEN.TabIndex = 0;
            // 
            // CUERPO
            // 
            this.CUERPO.Location = new System.Drawing.Point(12, 188);
            this.CUERPO.Multiline = true;
            this.CUERPO.Name = "CUERPO";
            this.CUERPO.Size = new System.Drawing.Size(352, 117);
            this.CUERPO.TabIndex = 1;
            // 
            // ACEPTARE
            // 
            this.ACEPTARE.BackColor = System.Drawing.Color.YellowGreen;
            this.ACEPTARE.Location = new System.Drawing.Point(153, 311);
            this.ACEPTARE.Name = "ACEPTARE";
            this.ACEPTARE.Size = new System.Drawing.Size(75, 23);
            this.ACEPTARE.TabIndex = 2;
            this.ACEPTARE.Text = "ACEPTAR";
            this.ACEPTARE.UseVisualStyleBackColor = false;
            this.ACEPTARE.Click += new System.EventHandler(this.ACEPTARE_Click);
            // 
            // Bienvenida
            // 
            this.Bienvenida.AutoSize = true;
            this.Bienvenida.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bienvenida.Location = new System.Drawing.Point(4, 21);
            this.Bienvenida.Name = "Bienvenida";
            this.Bienvenida.Size = new System.Drawing.Size(782, 46);
            this.Bienvenida.TabIndex = 3;
            this.Bienvenida.Text = "BIENVENIDO AL SISTEMA DE CORREO @SC";
            this.Bienvenida.Click += new System.EventHandler(this.Bienvenida_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "ENVIAR A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "CUERPO:";
            // 
            // CORREOSENVIADOS
            // 
            this.CORREOSENVIADOS.FormattingEnabled = true;
            this.CORREOSENVIADOS.Location = new System.Drawing.Point(747, 70);
            this.CORREOSENVIADOS.Name = "CORREOSENVIADOS";
            this.CORREOSENVIADOS.Size = new System.Drawing.Size(222, 277);
            this.CORREOSENVIADOS.TabIndex = 6;
            this.CORREOSENVIADOS.SelectedIndexChanged += new System.EventHandler(this.CORREOSENVIADOS_SelectedIndexChanged);
            // 
            // GUARDAR
            // 
            this.GUARDAR.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GUARDAR.Location = new System.Drawing.Point(747, 353);
            this.GUARDAR.Name = "GUARDAR";
            this.GUARDAR.Size = new System.Drawing.Size(87, 23);
            this.GUARDAR.TabIndex = 7;
            this.GUARDAR.Text = "GUARDAR";
            this.GUARDAR.UseVisualStyleBackColor = false;
            this.GUARDAR.Click += new System.EventHandler(this.GUARDAR_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(981, 383);
            this.Controls.Add(this.GUARDAR);
            this.Controls.Add(this.CORREOSENVIADOS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bienvenida);
            this.Controls.Add(this.ACEPTARE);
            this.Controls.Add(this.CUERPO);
            this.Controls.Add(this.PERSONAEN);
            this.Name = "Form2";
            this.Text = "MENSAJERIA";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PERSONAEN;
        private System.Windows.Forms.TextBox CUERPO;
        private System.Windows.Forms.Button ACEPTARE;
        private System.Windows.Forms.Label Bienvenida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox CORREOSENVIADOS;
        private System.Windows.Forms.Button GUARDAR;
    }
}