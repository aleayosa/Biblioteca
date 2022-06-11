
namespace Biblioteca.InterfazForm
{
    partial class FrmBiblioteca
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._btnClientes = new System.Windows.Forms.Button();
            this._btnLibros = new System.Windows.Forms.Button();
            this._btnEjemplares = new System.Windows.Forms.Button();
            this._btnPrestamos = new System.Windows.Forms.Button();
            this._btnReportesPrestamos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this._btnReporteEjemplares = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 106);
            this.label1.TabIndex = 0;
            this.label1.Text = "Biblioteca General \r\nJeremias Springfield";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(242, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 49);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bienvenidos a la";
            // 
            // _btnClientes
            // 
            this._btnClientes.Location = new System.Drawing.Point(146, 301);
            this._btnClientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._btnClientes.Name = "_btnClientes";
            this._btnClientes.Size = new System.Drawing.Size(177, 66);
            this._btnClientes.TabIndex = 3;
            this._btnClientes.Text = "Clientes";
            this._btnClientes.UseVisualStyleBackColor = true;
            this._btnClientes.Click += new System.EventHandler(this._btnClientes_Click);
            // 
            // _btnLibros
            // 
            this._btnLibros.Location = new System.Drawing.Point(380, 301);
            this._btnLibros.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._btnLibros.Name = "_btnLibros";
            this._btnLibros.Size = new System.Drawing.Size(177, 66);
            this._btnLibros.TabIndex = 4;
            this._btnLibros.Text = "Libros";
            this._btnLibros.UseVisualStyleBackColor = true;
            this._btnLibros.Click += new System.EventHandler(this._btnLibros_Click);
            // 
            // _btnEjemplares
            // 
            this._btnEjemplares.Location = new System.Drawing.Point(380, 400);
            this._btnEjemplares.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._btnEjemplares.Name = "_btnEjemplares";
            this._btnEjemplares.Size = new System.Drawing.Size(177, 66);
            this._btnEjemplares.TabIndex = 5;
            this._btnEjemplares.Text = "Ejemplares";
            this._btnEjemplares.UseVisualStyleBackColor = true;
            this._btnEjemplares.Click += new System.EventHandler(this._btnEjemplares_Click);
            // 
            // _btnPrestamos
            // 
            this._btnPrestamos.Location = new System.Drawing.Point(146, 400);
            this._btnPrestamos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._btnPrestamos.Name = "_btnPrestamos";
            this._btnPrestamos.Size = new System.Drawing.Size(177, 66);
            this._btnPrestamos.TabIndex = 6;
            this._btnPrestamos.Text = "Préstamos";
            this._btnPrestamos.UseVisualStyleBackColor = true;
            this._btnPrestamos.Click += new System.EventHandler(this._btnPrestamos_Click);
            // 
            // _btnReportesPrestamos
            // 
            this._btnReportesPrestamos.Location = new System.Drawing.Point(146, 500);
            this._btnReportesPrestamos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._btnReportesPrestamos.Name = "_btnReportesPrestamos";
            this._btnReportesPrestamos.Size = new System.Drawing.Size(177, 66);
            this._btnReportesPrestamos.TabIndex = 7;
            this._btnReportesPrestamos.Text = "Reporte de Préstamos";
            this._btnReportesPrestamos.UseVisualStyleBackColor = true;
            this._btnReportesPrestamos.Click += new System.EventHandler(this._btnReportesPrestamos_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Biblioteca.InterfazForm.Properties.Resources.Jeremias;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(660, 68);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(316, 666);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // _btnReporteEjemplares
            // 
            this._btnReporteEjemplares.Location = new System.Drawing.Point(380, 500);
            this._btnReporteEjemplares.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._btnReporteEjemplares.Name = "_btnReporteEjemplares";
            this._btnReporteEjemplares.Size = new System.Drawing.Size(177, 66);
            this._btnReporteEjemplares.TabIndex = 8;
            this._btnReporteEjemplares.Text = "Reporte de Ejemplares";
            this._btnReporteEjemplares.UseVisualStyleBackColor = true;
            this._btnReporteEjemplares.Click += new System.EventHandler(this._btnReporteEjemplares_Click);
            // 
            // FrmBiblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1125, 1038);
            this.Controls.Add(this._btnReporteEjemplares);
            this.Controls.Add(this._btnReportesPrestamos);
            this.Controls.Add(this._btnPrestamos);
            this.Controls.Add(this._btnEjemplares);
            this.Controls.Add(this._btnLibros);
            this.Controls.Add(this._btnClientes);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmBiblioteca";
            this.Text = "Bienvenidos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button _btnClientes;
        private System.Windows.Forms.Button _btnLibros;
        private System.Windows.Forms.Button _btnEjemplares;
        private System.Windows.Forms.Button _btnPrestamos;
        private System.Windows.Forms.Button _btnReportesPrestamos;
        private System.Windows.Forms.Button _btnReporteEjemplares;
    }
}

