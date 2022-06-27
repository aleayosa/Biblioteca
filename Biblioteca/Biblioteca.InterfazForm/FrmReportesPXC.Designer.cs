
namespace Biblioteca.InterfazForm
{
    partial class FrmReportesPXC
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
            this.label1 = new System.Windows.Forms.Label();
            this._dataGridReportePrestamos = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ejemplar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaAlta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaBaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this._lblNombreCliente = new System.Windows.Forms.Label();
            this._btnPxC = new System.Windows.Forms.Button();
            this._btnVolver5 = new System.Windows.Forms.Button();
            this._cmbClientesP = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridReportePrestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el ID del cliente ";
            // 
            // _dataGridReportePrestamos
            // 
            this._dataGridReportePrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridReportePrestamos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Titulo,
            this.Autor,
            this.Ejemplar,
            this.FechaAlta,
            this.FechaBaja});
            this._dataGridReportePrestamos.Location = new System.Drawing.Point(240, 82);
            this._dataGridReportePrestamos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._dataGridReportePrestamos.Name = "_dataGridReportePrestamos";
            this._dataGridReportePrestamos.RowHeadersWidth = 51;
            this._dataGridReportePrestamos.RowTemplate.Height = 24;
            this._dataGridReportePrestamos.Size = new System.Drawing.Size(1764, 852);
            this._dataGridReportePrestamos.TabIndex = 2;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 62;
            // 
            // Titulo
            // 
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.MinimumWidth = 6;
            this.Titulo.Name = "Titulo";
            this.Titulo.Width = 125;
            // 
            // Autor
            // 
            this.Autor.HeaderText = "Autor";
            this.Autor.MinimumWidth = 6;
            this.Autor.Name = "Autor";
            this.Autor.Width = 125;
            // 
            // Ejemplar
            // 
            this.Ejemplar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Ejemplar.HeaderText = "Ejemplar";
            this.Ejemplar.MinimumWidth = 6;
            this.Ejemplar.Name = "Ejemplar";
            this.Ejemplar.Width = 107;
            // 
            // FechaAlta
            // 
            this.FechaAlta.HeaderText = "Fecha de Alta";
            this.FechaAlta.MinimumWidth = 6;
            this.FechaAlta.Name = "FechaAlta";
            this.FechaAlta.Width = 125;
            // 
            // FechaBaja
            // 
            this.FechaBaja.HeaderText = "Fecha De Baja";
            this.FechaBaja.MinimumWidth = 6;
            this.FechaBaja.Name = "FechaBaja";
            this.FechaBaja.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(235, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Préstamos del cliente:";
            // 
            // _lblNombreCliente
            // 
            this._lblNombreCliente.AutoSize = true;
            this._lblNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblNombreCliente.ForeColor = System.Drawing.Color.Blue;
            this._lblNombreCliente.Location = new System.Drawing.Point(512, 26);
            this._lblNombreCliente.Name = "_lblNombreCliente";
            this._lblNombreCliente.Size = new System.Drawing.Size(0, 29);
            this._lblNombreCliente.TabIndex = 4;
            // 
            // _btnPxC
            // 
            this._btnPxC.Location = new System.Drawing.Point(143, 145);
            this._btnPxC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._btnPxC.Name = "_btnPxC";
            this._btnPxC.Size = new System.Drawing.Size(84, 32);
            this._btnPxC.TabIndex = 5;
            this._btnPxC.Text = "Buscar";
            this._btnPxC.UseVisualStyleBackColor = true;
            this._btnPxC.Click += new System.EventHandler(this._btnPxC_Click);
            // 
            // _btnVolver5
            // 
            this._btnVolver5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this._btnVolver5.Location = new System.Drawing.Point(1140, 22);
            this._btnVolver5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._btnVolver5.Name = "_btnVolver5";
            this._btnVolver5.Size = new System.Drawing.Size(134, 36);
            this._btnVolver5.TabIndex = 18;
            this._btnVolver5.Text = "Volver";
            this._btnVolver5.UseVisualStyleBackColor = false;
            this._btnVolver5.Click += new System.EventHandler(this._btnVolver5_Click);
            // 
            // _cmbClientesP
            // 
            this._cmbClientesP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbClientesP.FormattingEnabled = true;
            this._cmbClientesP.Location = new System.Drawing.Point(17, 112);
            this._cmbClientesP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._cmbClientesP.Name = "_cmbClientesP";
            this._cmbClientesP.Size = new System.Drawing.Size(208, 28);
            this._cmbClientesP.TabIndex = 45;
            // 
            // FrmReportesPXC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 992);
            this.Controls.Add(this._cmbClientesP);
            this.Controls.Add(this._btnVolver5);
            this.Controls.Add(this._btnPxC);
            this.Controls.Add(this._lblNombreCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._dataGridReportePrestamos);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmReportesPXC";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Préstamos Por Cliente";
            this.Load += new System.EventHandler(this.FrmReportesPXC_Load);
            ((System.ComponentModel.ISupportInitialize)(this._dataGridReportePrestamos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView _dataGridReportePrestamos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label _lblNombreCliente;
        private System.Windows.Forms.Button _btnPxC;
        private System.Windows.Forms.Button _btnVolver5;
        private System.Windows.Forms.ComboBox _cmbClientesP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ejemplar;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaAlta;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaBaja;
    }
}