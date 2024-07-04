namespace GeneradorTextoLorem2._0
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
            this.listPalaabras = new System.Windows.Forms.ListBox();
            this.textoGenerado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buscar = new System.Windows.Forms.Button();
            this.guardar = new System.Windows.Forms.Button();
            this.palabra = new System.Windows.Forms.RadioButton();
            this.parrafo = new System.Windows.Forms.RadioButton();
            this.lorem = new System.Windows.Forms.CheckBox();
            this.cant = new System.Windows.Forms.TextBox();
            this.generar = new System.Windows.Forms.Button();
            this.informacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listPalaabras
            // 
            this.listPalaabras.FormattingEnabled = true;
            this.listPalaabras.Location = new System.Drawing.Point(27, 37);
            this.listPalaabras.Name = "listPalaabras";
            this.listPalaabras.Size = new System.Drawing.Size(105, 342);
            this.listPalaabras.TabIndex = 0;
            // 
            // textoGenerado
            // 
            this.textoGenerado.Location = new System.Drawing.Point(522, 37);
            this.textoGenerado.Multiline = true;
            this.textoGenerado.Name = "textoGenerado";
            this.textoGenerado.Size = new System.Drawing.Size(266, 331);
            this.textoGenerado.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(579, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "TEXTO GENERADO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lista de palabras";
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(40, 385);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(75, 23);
            this.buscar.TabIndex = 4;
            this.buscar.Text = "BUSCAR";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // guardar
            // 
            this.guardar.Location = new System.Drawing.Point(627, 385);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(75, 23);
            this.guardar.TabIndex = 5;
            this.guardar.Text = "GUARDAR";
            this.guardar.UseVisualStyleBackColor = true;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // palabra
            // 
            this.palabra.AutoSize = true;
            this.palabra.Location = new System.Drawing.Point(272, 113);
            this.palabra.Name = "palabra";
            this.palabra.Size = new System.Drawing.Size(74, 17);
            this.palabra.TabIndex = 6;
            this.palabra.TabStop = true;
            this.palabra.Text = "PALABRA";
            this.palabra.UseVisualStyleBackColor = true;
            // 
            // parrafo
            // 
            this.parrafo.AutoSize = true;
            this.parrafo.Location = new System.Drawing.Point(272, 136);
            this.parrafo.Name = "parrafo";
            this.parrafo.Size = new System.Drawing.Size(76, 17);
            this.parrafo.TabIndex = 7;
            this.parrafo.TabStop = true;
            this.parrafo.Text = "PARRAFO";
            this.parrafo.UseVisualStyleBackColor = true;
            this.parrafo.CheckedChanged += new System.EventHandler(this.parrafo_CheckedChanged);
            // 
            // lorem
            // 
            this.lorem.AutoSize = true;
            this.lorem.Location = new System.Drawing.Point(272, 175);
            this.lorem.Name = "lorem";
            this.lorem.Size = new System.Drawing.Size(120, 17);
            this.lorem.TabIndex = 8;
            this.lorem.Text = "Empezar con Lorem";
            this.lorem.UseVisualStyleBackColor = true;
            // 
            // cant
            // 
            this.cant.Location = new System.Drawing.Point(272, 87);
            this.cant.Name = "cant";
            this.cant.Size = new System.Drawing.Size(48, 20);
            this.cant.TabIndex = 9;
            // 
            // generar
            // 
            this.generar.Location = new System.Drawing.Point(271, 217);
            this.generar.Name = "generar";
            this.generar.Size = new System.Drawing.Size(75, 23);
            this.generar.TabIndex = 10;
            this.generar.Text = "GENERAR";
            this.generar.UseVisualStyleBackColor = true;
            this.generar.Click += new System.EventHandler(this.generar_Click);
            // 
            // informacion
            // 
            this.informacion.Location = new System.Drawing.Point(582, 415);
            this.informacion.Name = "informacion";
            this.informacion.Size = new System.Drawing.Size(159, 23);
            this.informacion.TabIndex = 11;
            this.informacion.Text = "INFORMACION";
            this.informacion.UseVisualStyleBackColor = true;
            this.informacion.Click += new System.EventHandler(this.informacion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.informacion);
            this.Controls.Add(this.generar);
            this.Controls.Add(this.cant);
            this.Controls.Add(this.lorem);
            this.Controls.Add(this.parrafo);
            this.Controls.Add(this.palabra);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textoGenerado);
            this.Controls.Add(this.listPalaabras);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listPalaabras;
        private System.Windows.Forms.TextBox textoGenerado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.RadioButton palabra;
        private System.Windows.Forms.RadioButton parrafo;
        private System.Windows.Forms.CheckBox lorem;
        private System.Windows.Forms.TextBox cant;
        private System.Windows.Forms.Button generar;
        private System.Windows.Forms.Button informacion;
    }
}

