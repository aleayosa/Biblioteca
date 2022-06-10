
namespace Biblioteca.InterfazForm
{
    partial class FrmEjemplares
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
            this._btnAlta = new System.Windows.Forms.Button();
            this._lblListaEjemplares = new System.Windows.Forms.Label();
            this._btnAtras = new System.Windows.Forms.Button();
            this._dataGridEjemplares = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this._inputObservacion = new System.Windows.Forms.TextBox();
            this._inputLibro = new System.Windows.Forms.Label();
            this._inputObservaciones = new System.Windows.Forms.Label();
            this._inputIdLibro = new System.Windows.Forms.TextBox();
            this._inputPrecio = new System.Windows.Forms.Label();
            this.inputPrecio = new System.Windows.Forms.TextBox();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridEjemplares)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(373, 26);
            this.label5.TabIndex = 24;
            this.label5.Text = "Ingrese los datos del nuevo ejemplar:";
            // 
            // _btnAlta
            // 
            this._btnAlta.Location = new System.Drawing.Point(255, 215);
            this._btnAlta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._btnAlta.Name = "_btnAlta";
            this._btnAlta.Size = new System.Drawing.Size(126, 29);
            this._btnAlta.TabIndex = 15;
            this._btnAlta.Text = "Crear";
            this._btnAlta.UseVisualStyleBackColor = true;
            this._btnAlta.Click += new System.EventHandler(this._btnAlta_Click);
            // 
            // _lblListaEjemplares
            // 
            this._lblListaEjemplares.AutoSize = true;
            this._lblListaEjemplares.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblListaEjemplares.ForeColor = System.Drawing.Color.Red;
            this._lblListaEjemplares.Location = new System.Drawing.Point(381, 85);
            this._lblListaEjemplares.Name = "_lblListaEjemplares";
            this._lblListaEjemplares.Size = new System.Drawing.Size(0, 27);
            this._lblListaEjemplares.TabIndex = 27;
            // 
            // _btnAtras
            // 
            this._btnAtras.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this._btnAtras.Location = new System.Drawing.Point(748, 24);
            this._btnAtras.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._btnAtras.Name = "_btnAtras";
            this._btnAtras.Size = new System.Drawing.Size(134, 36);
            this._btnAtras.TabIndex = 30;
            this._btnAtras.Text = "Volver";
            this._btnAtras.UseVisualStyleBackColor = false;
            this._btnAtras.Click += new System.EventHandler(this._btnAtras_Click);
            // 
            // _dataGridEjemplares
            // 
            this._dataGridEjemplares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridEjemplares.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titulo,
            this.Observaciones,
            this.Precio});
            this._dataGridEjemplares.Location = new System.Drawing.Point(453, 85);
            this._dataGridEjemplares.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._dataGridEjemplares.Name = "_dataGridEjemplares";
            this._dataGridEjemplares.RowHeadersWidth = 51;
            this._dataGridEjemplares.RowTemplate.Height = 24;
            this._dataGridEjemplares.Size = new System.Drawing.Size(429, 312);
            this._dataGridEjemplares.TabIndex = 31;
            this._dataGridEjemplares.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._dataGridEjemplares_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(448, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(232, 29);
            this.label7.TabIndex = 28;
            this.label7.Text = "Listado de Ejemplares";
            // 
            // _inputObservacion
            // 
            this._inputObservacion.Location = new System.Drawing.Point(185, 125);
            this._inputObservacion.Name = "_inputObservacion";
            this._inputObservacion.Size = new System.Drawing.Size(196, 26);
            this._inputObservacion.TabIndex = 34;
            this._inputObservacion.TextChanged += new System.EventHandler(this._inputObservacion_TextChanged);
            // 
            // _inputLibro
            // 
            this._inputLibro.AutoSize = true;
            this._inputLibro.Location = new System.Drawing.Point(15, 86);
            this._inputLibro.Name = "_inputLibro";
            this._inputLibro.Size = new System.Drawing.Size(44, 20);
            this._inputLibro.TabIndex = 16;
            this._inputLibro.Text = "Libro";
            this._inputLibro.Click += new System.EventHandler(this._inputLibro_Click_1);
            // 
            // _inputObservaciones
            // 
            this._inputObservaciones.AutoSize = true;
            this._inputObservaciones.Location = new System.Drawing.Point(15, 125);
            this._inputObservaciones.Name = "_inputObservaciones";
            this._inputObservaciones.Size = new System.Drawing.Size(114, 20);
            this._inputObservaciones.TabIndex = 17;
            this._inputObservaciones.Text = "Observaciones";
            this._inputObservaciones.Click += new System.EventHandler(this._inputObservaciones_Click);
            // 
            // _inputIdLibro
            // 
            this._inputIdLibro.Location = new System.Drawing.Point(185, 83);
            this._inputIdLibro.Name = "_inputIdLibro";
            this._inputIdLibro.Size = new System.Drawing.Size(196, 26);
            this._inputIdLibro.TabIndex = 32;
            this._inputIdLibro.TextChanged += new System.EventHandler(this._inputPrecio_TextChanged);
            // 
            // _inputPrecio
            // 
            this._inputPrecio.AutoSize = true;
            this._inputPrecio.Location = new System.Drawing.Point(24, 172);
            this._inputPrecio.Name = "_inputPrecio";
            this._inputPrecio.Size = new System.Drawing.Size(53, 20);
            this._inputPrecio.TabIndex = 20;
            this._inputPrecio.Text = "Precio";
            this._inputPrecio.TextChanged += new System.EventHandler(this._inputPrecio_TextChanged);
            // 
            // inputPrecio
            // 
            this.inputPrecio.Location = new System.Drawing.Point(185, 166);
            this.inputPrecio.Name = "inputPrecio";
            this.inputPrecio.Size = new System.Drawing.Size(196, 26);
            this.inputPrecio.TabIndex = 35;
            // 
            // Titulo
            // 
            this.Titulo.HeaderText = "Libro";
            this.Titulo.MinimumWidth = 6;
            this.Titulo.Name = "Titulo";
            this.Titulo.Width = 125;
            // 
            // Observaciones
            // 
            this.Observaciones.HeaderText = "Observaciones";
            this.Observaciones.MinimumWidth = 6;
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.Width = 125;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.Width = 125;
            // 
            // FrmEjemplares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1125, 1038);
            this.Controls.Add(this.inputPrecio);
            this.Controls.Add(this._inputObservacion);
            this.Controls.Add(this._dataGridEjemplares);
            this.Controls.Add(this._btnAtras);
            this.Controls.Add(this.label7);
            this.Controls.Add(this._lblListaEjemplares);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._inputPrecio);
            this.Controls.Add(this._inputIdLibro);
            this.Controls.Add(this._inputObservaciones);
            this.Controls.Add(this._inputLibro);
            this.Controls.Add(this._btnAlta);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmEjemplares";
            this.Text = "Ejemplares";
            this.Load += new System.EventHandler(this.FrmEjemplares_Load);
            ((System.ComponentModel.ISupportInitialize)(this._dataGridEjemplares)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button _btnAlta;
        private System.Windows.Forms.TextBox _inputApellido;
        private System.Windows.Forms.TextBox _inputNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label _lblListaEjemplares;
        private System.Windows.Forms.Button _btnAtras;
        private System.Windows.Forms.DataGridView _dataGridEjemplares;
        private System.Windows.Forms.DataGridViewTextBoxColumn Libro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edicion;
        private System.Windows.Forms.TextBox _inputObservacion;
        private System.Windows.Forms.Label _inputLibro;
        private System.Windows.Forms.Label _inputObservaciones;
        private System.Windows.Forms.TextBox _inputIdLibro;
        private System.Windows.Forms.Label _inputPrecio;
        private System.Windows.Forms.TextBox inputPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
    }
}