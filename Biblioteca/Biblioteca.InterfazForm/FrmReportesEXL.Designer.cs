
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
            this._btnExL = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaAlta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._btnAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridReporteEjemplares)).BeginInit();
            this.SuspendLayout();
            // 
            // _lblNombreLibro
            // 
            this._lblNombreLibro.AutoSize = true;
            this._lblNombreLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblNombreLibro.ForeColor = System.Drawing.Color.Blue;
            this._lblNombreLibro.Location = new System.Drawing.Point(477, 28);
            this._lblNombreLibro.Name = "_lblNombreLibro";
            this._lblNombreLibro.Size = new System.Drawing.Size(0, 29);
            this._lblNombreLibro.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(242, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 29);
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
            this._dataGridReporteEjemplares.Location = new System.Drawing.Point(241, 78);
            this._dataGridReporteEjemplares.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._dataGridReporteEjemplares.Name = "_dataGridReporteEjemplares";
            this._dataGridReporteEjemplares.RowHeadersWidth = 51;
            this._dataGridReporteEjemplares.RowTemplate.Height = 24;
            this._dataGridReporteEjemplares.Size = new System.Drawing.Size(559, 446);
            this._dataGridReporteEjemplares.TabIndex = 7;
            // 
            // _inputReporteLibro
            // 
            this._inputReporteLibro.Location = new System.Drawing.Point(18, 106);
            this._inputReporteLibro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._inputReporteLibro.Name = "_inputReporteLibro";
            this._inputReporteLibro.Size = new System.Drawing.Size(165, 26);
            this._inputReporteLibro.TabIndex = 6;
            this._inputReporteLibro.TextChanged += new System.EventHandler(this._inputReporteLibro_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ingrese el ID del libro";
            // 
            // _btnExL
            // 
            this._btnExL.Location = new System.Drawing.Point(19, 149);
            this._btnExL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._btnExL.Name = "_btnExL";
            this._btnExL.Size = new System.Drawing.Size(94, 40);
            this._btnExL.TabIndex = 10;
            this._btnExL.Text = "Buscar";
            this._btnExL.UseVisualStyleBackColor = true;
            this._btnExL.Click += new System.EventHandler(this._btnExL_Click);
            // 
            // id
            // 
            this.id.HeaderText = "Nro de ejemplar";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 125;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Fecha de Alta";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.Width = 125;
            // 
            // FechaAlta
            // 
            this.FechaAlta.HeaderText = "Precio";
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
            // _btnAtras
            // 
            this._btnAtras.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this._btnAtras.Location = new System.Drawing.Point(19, 393);
            this._btnAtras.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._btnAtras.Name = "_btnAtras";
            this._btnAtras.Size = new System.Drawing.Size(134, 36);
            this._btnAtras.TabIndex = 31;
            this._btnAtras.Text = "Volver";
            this._btnAtras.UseVisualStyleBackColor = false;
            this._btnAtras.Click += new System.EventHandler(this._btnAtras_Click);
            // 
            // FrmReportesEXL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 701);
            this.Controls.Add(this._btnAtras);
            this.Controls.Add(this._btnExL);
            this.Controls.Add(this._lblNombreLibro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._dataGridReporteEjemplares);
            this.Controls.Add(this._inputReporteLibro);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.TextBox _inputReporteLibro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _btnExL;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaAlta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones;
        private System.Windows.Forms.Button _btnAtras;
    }
}