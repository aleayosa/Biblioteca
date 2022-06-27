
namespace Biblioteca.InterfazForm
{
    partial class FrmPrestamos
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
            this.label3 = new System.Windows.Forms.Label();
            this._lblPlazo = new System.Windows.Forms.Label();
            this._inputPlazo = new System.Windows.Forms.TextBox();
            this._lblEjemplarP = new System.Windows.Forms.Label();
            this._lblClienteP = new System.Windows.Forms.Label();
            this._btnAlta = new System.Windows.Forms.Button();
            this._dataGridPrestamos = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEjemplar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaAlta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaBaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaBajaReal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._btnVolver3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this._btnEliminarLibro = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this._cmbClientes = new System.Windows.Forms.ComboBox();
            this._cmbEjemplares = new System.Windows.Forms.ComboBox();
            this._cmbIdEliminar = new System.Windows.Forms.ComboBox();
            this._cmbIdFinalizar = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridPrestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(374, 26);
            this.label5.TabIndex = 24;
            this.label5.Text = "Ingrese los datos del nuevo préstamo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 21;
            // 
            // _lblPlazo
            // 
            this._lblPlazo.AutoSize = true;
            this._lblPlazo.Location = new System.Drawing.Point(26, 162);
            this._lblPlazo.Name = "_lblPlazo";
            this._lblPlazo.Size = new System.Drawing.Size(48, 20);
            this._lblPlazo.TabIndex = 20;
            this._lblPlazo.Text = "Plazo";
            // 
            // _inputPlazo
            // 
            this._inputPlazo.Location = new System.Drawing.Point(126, 159);
            this._inputPlazo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._inputPlazo.Name = "_inputPlazo";
            this._inputPlazo.Size = new System.Drawing.Size(256, 26);
            this._inputPlazo.TabIndex = 18;
            // 
            // _lblEjemplarP
            // 
            this._lblEjemplarP.AutoSize = true;
            this._lblEjemplarP.Location = new System.Drawing.Point(26, 125);
            this._lblEjemplarP.Name = "_lblEjemplarP";
            this._lblEjemplarP.Size = new System.Drawing.Size(71, 20);
            this._lblEjemplarP.TabIndex = 17;
            this._lblEjemplarP.Text = "Ejemplar";
            // 
            // _lblClienteP
            // 
            this._lblClienteP.AutoSize = true;
            this._lblClienteP.Location = new System.Drawing.Point(26, 89);
            this._lblClienteP.Name = "_lblClienteP";
            this._lblClienteP.Size = new System.Drawing.Size(58, 20);
            this._lblClienteP.TabIndex = 16;
            this._lblClienteP.Text = "Cliente";
            // 
            // _btnAlta
            // 
            this._btnAlta.Location = new System.Drawing.Point(256, 209);
            this._btnAlta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._btnAlta.Name = "_btnAlta";
            this._btnAlta.Size = new System.Drawing.Size(126, 29);
            this._btnAlta.TabIndex = 15;
            this._btnAlta.Text = "Solicitar";
            this._btnAlta.UseVisualStyleBackColor = true;
            this._btnAlta.Click += new System.EventHandler(this._btnAlta_Click);
            // 
            // _dataGridPrestamos
            // 
            this._dataGridPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridPrestamos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.IdCliente,
            this.IdEjemplar,
            this.Titulo,
            this.Autor,
            this.FechaAlta,
            this.FechaBaja,
            this.FechaBajaReal});
            this._dataGridPrestamos.Location = new System.Drawing.Point(426, 92);
            this._dataGridPrestamos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._dataGridPrestamos.Name = "_dataGridPrestamos";
            this._dataGridPrestamos.RowHeadersWidth = 51;
            this._dataGridPrestamos.RowTemplate.Height = 24;
            this._dataGridPrestamos.Size = new System.Drawing.Size(1614, 842);
            this._dataGridPrestamos.TabIndex = 27;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 62;
            // 
            // IdCliente
            // 
            this.IdCliente.HeaderText = "Cliente";
            this.IdCliente.MinimumWidth = 6;
            this.IdCliente.Name = "IdCliente";
            this.IdCliente.Width = 125;
            // 
            // IdEjemplar
            // 
            this.IdEjemplar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.IdEjemplar.HeaderText = "Ejemplar";
            this.IdEjemplar.MinimumWidth = 6;
            this.IdEjemplar.Name = "IdEjemplar";
            this.IdEjemplar.Width = 107;
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
            // FechaAlta
            // 
            this.FechaAlta.HeaderText = "Fecha de Alta";
            this.FechaAlta.MinimumWidth = 6;
            this.FechaAlta.Name = "FechaAlta";
            this.FechaAlta.Width = 125;
            // 
            // FechaBaja
            // 
            this.FechaBaja.HeaderText = "Fecha de Baja";
            this.FechaBaja.MinimumWidth = 6;
            this.FechaBaja.Name = "FechaBaja";
            this.FechaBaja.Width = 125;
            // 
            // FechaBajaReal
            // 
            this.FechaBajaReal.HeaderText = "Fecha de Baja Real";
            this.FechaBajaReal.MinimumWidth = 6;
            this.FechaBajaReal.Name = "FechaBajaReal";
            this.FechaBajaReal.Width = 125;
            // 
            // _btnVolver3
            // 
            this._btnVolver3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this._btnVolver3.Location = new System.Drawing.Point(1140, 22);
            this._btnVolver3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._btnVolver3.Name = "_btnVolver3";
            this._btnVolver3.Size = new System.Drawing.Size(134, 36);
            this._btnVolver3.TabIndex = 26;
            this._btnVolver3.Text = "Volver";
            this._btnVolver3.UseVisualStyleBackColor = false;
            this._btnVolver3.Click += new System.EventHandler(this._btnVolver3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(435, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(227, 29);
            this.label7.TabIndex = 25;
            this.label7.Text = "Listado de Préstamos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(371, 26);
            this.label6.TabIndex = 39;
            this.label6.Text = "Ingrese el ID del Préstamo a eliminar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 20);
            this.label8.TabIndex = 38;
            this.label8.Text = "ID";
            // 
            // _btnEliminarLibro
            // 
            this._btnEliminarLibro.Location = new System.Drawing.Point(243, 360);
            this._btnEliminarLibro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._btnEliminarLibro.Name = "_btnEliminarLibro";
            this._btnEliminarLibro.Size = new System.Drawing.Size(126, 29);
            this._btnEliminarLibro.TabIndex = 37;
            this._btnEliminarLibro.Text = "Eliminar";
            this._btnEliminarLibro.UseVisualStyleBackColor = true;
            this._btnEliminarLibro.Click += new System.EventHandler(this._btnEliminarLibro_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 465);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(368, 26);
            this.label9.TabIndex = 43;
            this.label9.Text = "Ingrese el ID del Préstamo finalizado";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 509);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 20);
            this.label10.TabIndex = 42;
            this.label10.Text = "ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(243, 542);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 29);
            this.button1.TabIndex = 41;
            this.button1.Text = "Finalizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // _cmbClientes
            // 
            this._cmbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbClientes.FormattingEnabled = true;
            this._cmbClientes.Location = new System.Drawing.Point(126, 80);
            this._cmbClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._cmbClientes.Name = "_cmbClientes";
            this._cmbClientes.Size = new System.Drawing.Size(256, 28);
            this._cmbClientes.TabIndex = 44;
            // 
            // _cmbEjemplares
            // 
            this._cmbEjemplares.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbEjemplares.FormattingEnabled = true;
            this._cmbEjemplares.Location = new System.Drawing.Point(126, 119);
            this._cmbEjemplares.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._cmbEjemplares.Name = "_cmbEjemplares";
            this._cmbEjemplares.Size = new System.Drawing.Size(256, 28);
            this._cmbEjemplares.TabIndex = 45;
            // 
            // _cmbIdEliminar
            // 
            this._cmbIdEliminar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbIdEliminar.FormattingEnabled = true;
            this._cmbIdEliminar.Location = new System.Drawing.Point(56, 325);
            this._cmbIdEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._cmbIdEliminar.Name = "_cmbIdEliminar";
            this._cmbIdEliminar.Size = new System.Drawing.Size(312, 28);
            this._cmbIdEliminar.TabIndex = 46;
            // 
            // _cmbIdFinalizar
            // 
            this._cmbIdFinalizar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbIdFinalizar.FormattingEnabled = true;
            this._cmbIdFinalizar.Location = new System.Drawing.Point(56, 505);
            this._cmbIdFinalizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._cmbIdFinalizar.Name = "_cmbIdFinalizar";
            this._cmbIdFinalizar.Size = new System.Drawing.Size(312, 28);
            this._cmbIdFinalizar.TabIndex = 47;
            // 
            // FrmPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 980);
            this.Controls.Add(this._cmbIdFinalizar);
            this.Controls.Add(this._cmbIdEliminar);
            this.Controls.Add(this._cmbEjemplares);
            this.Controls.Add(this._cmbClientes);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this._btnEliminarLibro);
            this.Controls.Add(this._dataGridPrestamos);
            this.Controls.Add(this._btnVolver3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._lblPlazo);
            this.Controls.Add(this._inputPlazo);
            this.Controls.Add(this._lblEjemplarP);
            this.Controls.Add(this._lblClienteP);
            this.Controls.Add(this._btnAlta);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmPrestamos";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Préstamos";
            this.Load += new System.EventHandler(this.FrmPrestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this._dataGridPrestamos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label _lblPlazo;
        private System.Windows.Forms.TextBox _inputPlazo;
        private System.Windows.Forms.Label _lblEjemplarP;
        private System.Windows.Forms.Label _lblClienteP;
        private System.Windows.Forms.Button _btnAlta;
        private System.Windows.Forms.DataGridView _dataGridPrestamos;
        private System.Windows.Forms.Button _btnVolver3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button _btnEliminarLibro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox _cmbClientes;
        private System.Windows.Forms.ComboBox _cmbEjemplares;
        private System.Windows.Forms.ComboBox _cmbIdEliminar;
        private System.Windows.Forms.ComboBox _cmbIdFinalizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEjemplar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaAlta;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaBaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaBajaReal;
    }
}