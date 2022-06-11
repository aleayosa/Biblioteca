
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
            this.label4 = new System.Windows.Forms.Label();
            this._inputPlazo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._btnAlta = new System.Windows.Forms.Button();
            this._inputIdEjemplar = new System.Windows.Forms.TextBox();
            this._inputidCliente = new System.Windows.Forms.TextBox();
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
            this._inputIdPrestamoEliminar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this._inputIdFinalizado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridPrestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(324, 24);
            this.label5.TabIndex = 24;
            this.label5.Text = "Ingrese los datos del nuevo préstamo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Plazo";
            // 
            // _inputPlazo
            // 
            this._inputPlazo.Location = new System.Drawing.Point(112, 127);
            this._inputPlazo.Name = "_inputPlazo";
            this._inputPlazo.Size = new System.Drawing.Size(228, 22);
            this._inputPlazo.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Ejemplar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Cliente";
            // 
            // _btnAlta
            // 
            this._btnAlta.Location = new System.Drawing.Point(228, 168);
            this._btnAlta.Name = "_btnAlta";
            this._btnAlta.Size = new System.Drawing.Size(112, 23);
            this._btnAlta.TabIndex = 15;
            this._btnAlta.Text = "Solicitar";
            this._btnAlta.UseVisualStyleBackColor = true;
            this._btnAlta.Click += new System.EventHandler(this._btnAlta_Click);
            // 
            // _inputIdEjemplar
            // 
            this._inputIdEjemplar.Location = new System.Drawing.Point(112, 96);
            this._inputIdEjemplar.Name = "_inputIdEjemplar";
            this._inputIdEjemplar.Size = new System.Drawing.Size(228, 22);
            this._inputIdEjemplar.TabIndex = 14;
            // 
            // _inputidCliente
            // 
            this._inputidCliente.Location = new System.Drawing.Point(112, 68);
            this._inputidCliente.Name = "_inputidCliente";
            this._inputidCliente.Size = new System.Drawing.Size(228, 22);
            this._inputidCliente.TabIndex = 13;
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
            this._dataGridPrestamos.Location = new System.Drawing.Point(379, 74);
            this._dataGridPrestamos.Name = "_dataGridPrestamos";
            this._dataGridPrestamos.RowHeadersWidth = 51;
            this._dataGridPrestamos.RowTemplate.Height = 24;
            this._dataGridPrestamos.Size = new System.Drawing.Size(1214, 675);
            this._dataGridPrestamos.TabIndex = 27;
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 125;
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
            this.IdEjemplar.HeaderText = "Ejemplar";
            this.IdEjemplar.MinimumWidth = 6;
            this.IdEjemplar.Name = "IdEjemplar";
            this.IdEjemplar.Width = 125;
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
            this._btnVolver3.Location = new System.Drawing.Point(1474, 28);
            this._btnVolver3.Name = "_btnVolver3";
            this._btnVolver3.Size = new System.Drawing.Size(119, 29);
            this._btnVolver3.TabIndex = 26;
            this._btnVolver3.Text = "Volver";
            this._btnVolver3.UseVisualStyleBackColor = false;
            this._btnVolver3.Click += new System.EventHandler(this._btnVolver3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(387, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 24);
            this.label7.TabIndex = 25;
            this.label7.Text = "Listado de Préstamos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(316, 24);
            this.label6.TabIndex = 39;
            this.label6.Text = "Ingrese el ID del Préstamo a eliminar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 17);
            this.label8.TabIndex = 38;
            this.label8.Text = "ID";
            // 
            // _btnEliminarLibro
            // 
            this._btnEliminarLibro.Location = new System.Drawing.Point(216, 288);
            this._btnEliminarLibro.Name = "_btnEliminarLibro";
            this._btnEliminarLibro.Size = new System.Drawing.Size(112, 23);
            this._btnEliminarLibro.TabIndex = 37;
            this._btnEliminarLibro.Text = "Eliminar";
            this._btnEliminarLibro.UseVisualStyleBackColor = true;
            this._btnEliminarLibro.Click += new System.EventHandler(this._btnEliminarLibro_Click);
            // 
            // _inputIdPrestamoEliminar
            // 
            this._inputIdPrestamoEliminar.Location = new System.Drawing.Point(92, 261);
            this._inputIdPrestamoEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._inputIdPrestamoEliminar.Name = "_inputIdPrestamoEliminar";
            this._inputIdPrestamoEliminar.Size = new System.Drawing.Size(236, 22);
            this._inputIdPrestamoEliminar.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 372);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(313, 24);
            this.label9.TabIndex = 43;
            this.label9.Text = "Ingrese el ID del Préstamo finalizado";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 407);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 17);
            this.label10.TabIndex = 42;
            this.label10.Text = "ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(216, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 41;
            this.button1.Text = "Finalizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // _inputIdFinalizado
            // 
            this._inputIdFinalizado.Location = new System.Drawing.Point(92, 407);
            this._inputIdFinalizado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._inputIdFinalizado.Name = "_inputIdFinalizado";
            this._inputIdFinalizado.Size = new System.Drawing.Size(236, 22);
            this._inputIdFinalizado.TabIndex = 40;
            // 
            // FrmPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1620, 778);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this._inputIdFinalizado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this._btnEliminarLibro);
            this.Controls.Add(this._inputIdPrestamoEliminar);
            this.Controls.Add(this._dataGridPrestamos);
            this.Controls.Add(this._btnVolver3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._inputPlazo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._btnAlta);
            this.Controls.Add(this._inputIdEjemplar);
            this.Controls.Add(this._inputidCliente);
            this.Name = "FrmPrestamos";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Préstamos";
            this.Load += new System.EventHandler(this.FrmPrestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this._dataGridPrestamos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _inputPlazo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _btnAlta;
        private System.Windows.Forms.TextBox _inputIdEjemplar;
        private System.Windows.Forms.TextBox _inputidCliente;
        private System.Windows.Forms.DataGridView _dataGridPrestamos;
        private System.Windows.Forms.Button _btnVolver3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEjemplar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaAlta;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaBaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaBajaReal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button _btnEliminarLibro;
        private System.Windows.Forms.TextBox _inputIdPrestamoEliminar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox _inputIdFinalizado;
    }
}