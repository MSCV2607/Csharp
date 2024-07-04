namespace RPARCIAL
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
            this.Buscar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Palabras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaracteresSE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaracteresCE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INFO = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(192, 203);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(153, 53);
            this.Buscar.TabIndex = 0;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1083, 185);
            this.textBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Palabras,
            this.CaracteresSE,
            this.CaracteresCE});
            this.dataGridView1.Location = new System.Drawing.Point(472, 280);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(623, 207);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Palabras
            // 
            this.Palabras.HeaderText = "Palabras";
            this.Palabras.MinimumWidth = 6;
            this.Palabras.Name = "Palabras";
            this.Palabras.ReadOnly = true;
            this.Palabras.Width = 125;
            // 
            // CaracteresSE
            // 
            this.CaracteresSE.HeaderText = "Caracteres Sin Espacio";
            this.CaracteresSE.MinimumWidth = 6;
            this.CaracteresSE.Name = "CaracteresSE";
            this.CaracteresSE.ReadOnly = true;
            this.CaracteresSE.Width = 125;
            // 
            // CaracteresCE
            // 
            this.CaracteresCE.HeaderText = "Caracteres Con Espacio";
            this.CaracteresCE.MinimumWidth = 6;
            this.CaracteresCE.Name = "CaracteresCE";
            this.CaracteresCE.ReadOnly = true;
            this.CaracteresCE.Width = 125;
            // 
            // INFO
            // 
            this.INFO.Location = new System.Drawing.Point(683, 203);
            this.INFO.Name = "INFO";
            this.INFO.Size = new System.Drawing.Size(153, 53);
            this.INFO.TabIndex = 3;
            this.INFO.Text = "INFORMACION";
            this.INFO.UseVisualStyleBackColor = true;
            this.INFO.Click += new System.EventHandler(this.INFO_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 271);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(382, 212);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 499);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.INFO);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Buscar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Palabras;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaracteresSE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaracteresCE;
        private System.Windows.Forms.Button INFO;
        private System.Windows.Forms.ListBox listBox1;
    }
}

