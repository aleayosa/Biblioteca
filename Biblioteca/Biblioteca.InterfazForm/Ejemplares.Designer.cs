
namespace Biblioteca.InterfazForm
{
    partial class Ejemplares
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
            this.label5 = new System.Windows.Forms.Label();
            this._inputEdicion = new System.Windows.Forms.Label();
            this._inputAutor = new System.Windows.Forms.Label();
            this._inputTitulo = new System.Windows.Forms.Label();
            this._btnAlta = new System.Windows.Forms.Button();
            this._inputPrecio = new System.Windows.Forms.TextBox();
            this._inputObservacion = new System.Windows.Forms.TextBox();
            this._dataGridEjemplares = new System.Windows.Forms.DataGridView();
            this._btnAtras = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridEjemplares)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(373, 26);
            this.label5.TabIndex = 38;
            this.label5.Text = "Ingrese los datos del nuevo ejemplar:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // _inputEdicion
            // 
            this._inputEdicion.AutoSize = true;
            this._inputEdicion.Location = new System.Drawing.Point(16, 148);
            this._inputEdicion.Name = "_inputEdicion";
            this._inputEdicion.Size = new System.Drawing.Size(0, 20);
            this._inputEdicion.TabIndex = 34;
            this._inputEdicion.Click += new System.EventHandler(this._inputEdicion_Click);
            // 
            // _inputAutor
            // 
            this._inputAutor.AutoSize = true;
            this._inputAutor.Location = new System.Drawing.Point(16, 111);
            this._inputAutor.Name = "_inputAutor";
            this._inputAutor.Size = new System.Drawing.Size(53, 20);
            this._inputAutor.TabIndex = 31;
            this._inputAutor.Text = "Precio";
            // 
            // _inputTitulo
            // 
            this._inputTitulo.AutoSize = true;
            this._inputTitulo.Location = new System.Drawing.Point(16, 75);
            this._inputTitulo.Name = "_inputTitulo";
            this._inputTitulo.Size = new System.Drawing.Size(114, 20);
            this._inputTitulo.TabIndex = 30;
            this._inputTitulo.Text = "Observaciones";
            // 
            // _btnAlta
            // 
            this._btnAlta.Location = new System.Drawing.Point(244, 148);
            this._btnAlta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._btnAlta.Name = "_btnAlta";
            this._btnAlta.Size = new System.Drawing.Size(126, 29);
            this._btnAlta.TabIndex = 29;
            this._btnAlta.Text = "Crear";
            this._btnAlta.UseVisualStyleBackColor = true;
            // 
            // _inputPrecio
            // 
            this._inputPrecio.Location = new System.Drawing.Point(136, 106);
            this._inputPrecio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._inputPrecio.Name = "_inputPrecio";
            this._inputPrecio.Size = new System.Drawing.Size(234, 26);
            this._inputPrecio.TabIndex = 28;
            // 
            // _inputObservacion
            // 
            this._inputObservacion.Location = new System.Drawing.Point(136, 71);
            this._inputObservacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._inputObservacion.Name = "_inputObservacion";
            this._inputObservacion.Size = new System.Drawing.Size(234, 26);
            this._inputObservacion.TabIndex = 27;
            // 
            // _dataGridEjemplares
            // 
            this._dataGridEjemplares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridEjemplares.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titulo,
            this.Autor});
            this._dataGridEjemplares.Location = new System.Drawing.Point(401, 75);
            this._dataGridEjemplares.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._dataGridEjemplares.Name = "_dataGridEjemplares";
            this._dataGridEjemplares.RowHeadersWidth = 51;
            this._dataGridEjemplares.RowTemplate.Height = 24;
            this._dataGridEjemplares.Size = new System.Drawing.Size(304, 300);
            this._dataGridEjemplares.TabIndex = 41;
            this._dataGridEjemplares.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._dataGridLibros_CellContentClick);
            // 
            // _btnAtras
            // 
            this._btnAtras.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this._btnAtras.Location = new System.Drawing.Point(993, 12);
            this._btnAtras.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._btnAtras.Name = "_btnAtras";
            this._btnAtras.Size = new System.Drawing.Size(10, 10);
            this._btnAtras.TabIndex = 40;
            this._btnAtras.Text = "Volver";
            this._btnAtras.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(396, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(232, 29);
            this.label7.TabIndex = 39;
            this.label7.Text = "Listado de Ejemplares";
            // 
            // Titulo
            // 
            this.Titulo.HeaderText = "Observaciones";
            this.Titulo.MinimumWidth = 6;
            this.Titulo.Name = "Titulo";
            this.Titulo.Width = 125;
            // 
            // Autor
            // 
            this.Autor.HeaderText = "Precio";
            this.Autor.MinimumWidth = 6;
            this.Autor.Name = "Autor";
            this.Autor.Width = 125;
            // 
            // Ejemplares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 436);
            this.Controls.Add(this._dataGridEjemplares);
            this.Controls.Add(this._btnAtras);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._inputEdicion);
            this.Controls.Add(this._inputAutor);
            this.Controls.Add(this._inputTitulo);
            this.Controls.Add(this._btnAlta);
            this.Controls.Add(this._inputPrecio);
            this.Controls.Add(this._inputObservacion);
            this.Name = "Ejemplares";
            this.Text = "Ejemplares";
            ((System.ComponentModel.ISupportInitialize)(this._dataGridEjemplares)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label _inputEdicion;
        private System.Windows.Forms.Label _inputAutor;
        private System.Windows.Forms.Label _inputTitulo;
        private System.Windows.Forms.Button _btnAlta;
        private System.Windows.Forms.TextBox _inputPrecio;
        private System.Windows.Forms.TextBox _inputObservacion;
        private System.Windows.Forms.DataGridView _dataGridEjemplares;
        private System.Windows.Forms.Button _btnAtras;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
    }
}