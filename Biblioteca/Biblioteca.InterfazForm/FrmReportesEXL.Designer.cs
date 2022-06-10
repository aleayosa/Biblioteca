
namespace Biblioteca.InterfazForm
{
    partial class FrmReportesEXL
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
            this._lblNombreLibro = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._dataGridReporteEjemplares = new System.Windows.Forms.DataGridView();
            this._inputReporteLibro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaAlta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridReporteEjemplares)).BeginInit();
            this.SuspendLayout();
            // 
            // _lblNombreLibro
            // 
            this._lblNombreLibro.AutoSize = true;
            this._lblNombreLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblNombreLibro.ForeColor = System.Drawing.Color.Blue;
            this._lblNombreLibro.Location = new System.Drawing.Point(424, 22);
            this._lblNombreLibro.Name = "_lblNombreLibro";
            this._lblNombreLibro.Size = new System.Drawing.Size(177, 25);
            this._lblNombreLibro.TabIndex = 9;
            this._lblNombreLibro.Text = "Ayosa, Alejandra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(215, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ejemplares del Libro:";
            // 
            // _dataGridReporteEjemplares
            // 
            this._dataGridReporteEjemplares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridReporteEjemplares.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Precio,
            this.FechaAlta,
            this.Observaciones});
            this._dataGridReporteEjemplares.Location = new System.Drawing.Point(214, 62);
            this._dataGridReporteEjemplares.Name = "_dataGridReporteEjemplares";
            this._dataGridReporteEjemplares.RowHeadersWidth = 51;
            this._dataGridReporteEjemplares.RowTemplate.Height = 24;
            this._dataGridReporteEjemplares.Size = new System.Drawing.Size(678, 357);
            this._dataGridReporteEjemplares.TabIndex = 7;
            // 
            // _inputReporteLibro
            // 
            this._inputReporteLibro.Location = new System.Drawing.Point(16, 85);
            this._inputReporteLibro.Name = "_inputReporteLibro";
            this._inputReporteLibro.Size = new System.Drawing.Size(147, 22);
            this._inputReporteLibro.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ingrese el ID del libro";
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 125;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.Width = 125;
            // 
            // FechaAlta
            // 
            this.FechaAlta.HeaderText = "Fecha de Alta";
            this.FechaAlta.MinimumWidth = 6;
            this.FechaAlta.Name = "FechaAlta";
            this.FechaAlta.Width = 125;
            // 
            // Observaciones
            // 
            this.Observaciones.HeaderText = "Observaciones";
            this.Observaciones.MinimumWidth = 6;
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.Width = 125;
            // 
            // FrmReportesEXL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 561);
            this.Controls.Add(this._lblNombreLibro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._dataGridReporteEjemplares);
            this.Controls.Add(this._inputReporteLibro);
            this.Controls.Add(this.label1);
            this.Name = "FrmReportesEXL";
            this.Text = "Ejemplares Por Libro";
            ((System.ComponentModel.ISupportInitialize)(this._dataGridReporteEjemplares)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblNombreLibro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView _dataGridReporteEjemplares;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaAlta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones;
        private System.Windows.Forms.TextBox _inputReporteLibro;
        private System.Windows.Forms.Label label1;
    }
}