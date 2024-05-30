namespace SIMON
{
    partial class SIMON
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SIMON));
            this.B0 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Star = new System.Windows.Forms.Button();
            this.lbl_puntos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // B0
            // 
            this.B0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.B0.BackColor = System.Drawing.Color.Red;
            this.B0.Location = new System.Drawing.Point(298, 21);
            this.B0.Name = "B0";
            this.B0.Size = new System.Drawing.Size(156, 71);
            this.B0.TabIndex = 0;
            this.B0.UseVisualStyleBackColor = false;
            this.B0.Click += new System.EventHandler(this.B0_Click);
            this.B0.MouseDown += new System.Windows.Forms.MouseEventHandler(this.B0_MouseDown);
            this.B0.MouseHover += new System.EventHandler(this.B0_MouseHover);
            this.B0.MouseUp += new System.Windows.Forms.MouseEventHandler(this.B0_MouseUp);
            // 
            // B3
            // 
            this.B3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.B3.BackColor = System.Drawing.Color.ForestGreen;
            this.B3.Location = new System.Drawing.Point(143, 98);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(156, 71);
            this.B3.TabIndex = 1;
            this.B3.UseVisualStyleBackColor = false;
            this.B3.Click += new System.EventHandler(this.B3_Click);
            // 
            // B1
            // 
            this.B1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.B1.BackColor = System.Drawing.Color.Navy;
            this.B1.Location = new System.Drawing.Point(454, 98);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(156, 71);
            this.B1.TabIndex = 2;
            this.B1.UseVisualStyleBackColor = false;
            this.B1.Click += new System.EventHandler(this.B1_Click);
            // 
            // B2
            // 
            this.B2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.B2.BackColor = System.Drawing.Color.Gold;
            this.B2.Location = new System.Drawing.Point(298, 175);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(156, 71);
            this.B2.TabIndex = 3;
            this.B2.UseVisualStyleBackColor = false;
            this.B2.Click += new System.EventHandler(this.B2_Click);
            // 
            // Star
            // 
            this.Star.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Star.Location = new System.Drawing.Point(298, 278);
            this.Star.Name = "Star";
            this.Star.Size = new System.Drawing.Size(156, 28);
            this.Star.TabIndex = 4;
            this.Star.Text = "Star";
            this.Star.UseVisualStyleBackColor = true;
            this.Star.Click += new System.EventHandler(this.Star_Click);
            // 
            // lbl_puntos
            // 
            this.lbl_puntos.AutoSize = true;
            this.lbl_puntos.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_puntos.Location = new System.Drawing.Point(704, 21);
            this.lbl_puntos.Name = "lbl_puntos";
            this.lbl_puntos.Size = new System.Drawing.Size(13, 13);
            this.lbl_puntos.TabIndex = 5;
            this.lbl_puntos.Text = "--";
            this.lbl_puntos.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(325, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "SIMON";
            // 
            // SIMON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(773, 331);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_puntos);
            this.Controls.Add(this.Star);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B0);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SIMON";
            this.Text = "SIMON";
            this.Load += new System.EventHandler(this.SIMON_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B0;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Star;
        private System.Windows.Forms.Label lbl_puntos;
        private System.Windows.Forms.Label label1;
    }
}

