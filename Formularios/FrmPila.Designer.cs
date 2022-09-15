namespace Pilas_Y_Colas
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
            this.txtPilas = new System.Windows.Forms.TextBox();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.lstPilas = new System.Windows.Forms.ListBox();
            this.btnExtraer = new System.Windows.Forms.Button();
            this.btnVacia = new System.Windows.Forms.Button();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPilas
            // 
            this.txtPilas.Location = new System.Drawing.Point(31, 26);
            this.txtPilas.Name = "txtPilas";
            this.txtPilas.Size = new System.Drawing.Size(162, 20);
            this.txtPilas.TabIndex = 0;
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(217, 23);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(75, 23);
            this.btnAñadir.TabIndex = 1;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // lstPilas
            // 
            this.lstPilas.FormattingEnabled = true;
            this.lstPilas.Location = new System.Drawing.Point(31, 62);
            this.lstPilas.Name = "lstPilas";
            this.lstPilas.Size = new System.Drawing.Size(252, 212);
            this.lstPilas.TabIndex = 2;
            // 
            // btnExtraer
            // 
            this.btnExtraer.Location = new System.Drawing.Point(208, 300);
            this.btnExtraer.Name = "btnExtraer";
            this.btnExtraer.Size = new System.Drawing.Size(75, 23);
            this.btnExtraer.TabIndex = 3;
            this.btnExtraer.Text = "Extraer";
            this.btnExtraer.UseVisualStyleBackColor = true;
            this.btnExtraer.Click += new System.EventHandler(this.btnExtraer_Click);
            // 
            // btnVacia
            // 
            this.btnVacia.Location = new System.Drawing.Point(118, 300);
            this.btnVacia.Name = "btnVacia";
            this.btnVacia.Size = new System.Drawing.Size(75, 23);
            this.btnVacia.TabIndex = 4;
            this.btnVacia.Text = "Vacia?";
            this.btnVacia.UseVisualStyleBackColor = true;
            this.btnVacia.Click += new System.EventHandler(this.btnVacia_Click);
            // 
            // btnPrimero
            // 
            this.btnPrimero.Location = new System.Drawing.Point(31, 300);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(75, 23);
            this.btnPrimero.TabIndex = 5;
            this.btnPrimero.Text = "Primero";
            this.btnPrimero.UseVisualStyleBackColor = true;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 351);
            this.Controls.Add(this.btnPrimero);
            this.Controls.Add(this.btnVacia);
            this.Controls.Add(this.btnExtraer);
            this.Controls.Add(this.lstPilas);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.txtPilas);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(345, 390);
            this.MinimumSize = new System.Drawing.Size(345, 390);
            this.Name = "Form1";
            this.Text = "FrmPilas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPilas;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.ListBox lstPilas;
        private System.Windows.Forms.Button btnExtraer;
        private System.Windows.Forms.Button btnVacia;
        private System.Windows.Forms.Button btnPrimero;
    }
}

