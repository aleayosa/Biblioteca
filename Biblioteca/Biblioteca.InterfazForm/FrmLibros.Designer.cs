
namespace Biblioteca.InterfazForm
{
    partial class FrmLibros
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
            this._inputPaginas = new System.Windows.Forms.Label();
            this._inputEmail = new System.Windows.Forms.TextBox();
            this._inputEditorial = new System.Windows.Forms.Label();
            this._inputEdicion = new System.Windows.Forms.Label();
            this._inputTelefono = new System.Windows.Forms.TextBox();
            this._inputDireccion = new System.Windows.Forms.TextBox();
            this._inputAutor = new System.Windows.Forms.Label();
            this._inputTitulo = new System.Windows.Forms.Label();
            this._btnAlta = new System.Windows.Forms.Button();
            this._inputApellido = new System.Windows.Forms.TextBox();
            this._inputNombre = new System.Windows.Forms.TextBox();
            this._inputTemas = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this._lblListaLibros = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this._btnAtras = new System.Windows.Forms.Button();
            this._dataGridLibros = new System.Windows.Forms.DataGridView();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paginas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(287, 24);
            this.label5.TabIndex = 24;
            this.label5.Text = "Ingrese los datos del nuevo libro:";
            // 
            // _inputPaginas
            // 
            this._inputPaginas.AutoSize = true;
            this._inputPaginas.Location = new System.Drawing.Point(13, 187);
            this._inputPaginas.Name = "_inputPaginas";
            this._inputPaginas.Size = new System.Drawing.Size(59, 17);
            this._inputPaginas.TabIndex = 23;
            this._inputPaginas.Text = "Páginas";
            // 
            // _inputEmail
            // 
            this._inputEmail.Location = new System.Drawing.Point(85, 184);
            this._inputEmail.Name = "_inputEmail";
            this._inputEmail.Size = new System.Drawing.Size(228, 22);
            this._inputEmail.TabIndex = 22;
            // 
            // _inputEditorial
            // 
            this._inputEditorial.AutoSize = true;
            this._inputEditorial.Location = new System.Drawing.Point(13, 159);
            this._inputEditorial.Name = "_inputEditorial";
            this._inputEditorial.Size = new System.Drawing.Size(59, 17);
            this._inputEditorial.TabIndex = 21;
            this._inputEditorial.Text = "Editorial";
            // 
            // _inputEdicion
            // 
            this._inputEdicion.AutoSize = true;
            this._inputEdicion.Location = new System.Drawing.Point(13, 130);
            this._inputEdicion.Name = "_inputEdicion";
            this._inputEdicion.Size = new System.Drawing.Size(54, 17);
            this._inputEdicion.TabIndex = 20;
            this._inputEdicion.Text = "Edición";
            // 
            // _inputTelefono
            // 
            this._inputTelefono.Location = new System.Drawing.Point(85, 155);
            this._inputTelefono.Name = "_inputTelefono";
            this._inputTelefono.Size = new System.Drawing.Size(228, 22);
            this._inputTelefono.TabIndex = 19;
            // 
            // _inputDireccion
            // 
            this._inputDireccion.Location = new System.Drawing.Point(85, 127);
            this._inputDireccion.Name = "_inputDireccion";
            this._inputDireccion.Size = new System.Drawing.Size(228, 22);
            this._inputDireccion.TabIndex = 18;
            // 
            // _inputAutor
            // 
            this._inputAutor.AutoSize = true;
            this._inputAutor.Location = new System.Drawing.Point(13, 100);
            this._inputAutor.Name = "_inputAutor";
            this._inputAutor.Size = new System.Drawing.Size(42, 17);
            this._inputAutor.TabIndex = 17;
            this._inputAutor.Text = "Autor";
            // 
            // _inputTitulo
            // 
            this._inputTitulo.AutoSize = true;
            this._inputTitulo.Location = new System.Drawing.Point(13, 71);
            this._inputTitulo.Name = "_inputTitulo";
            this._inputTitulo.Size = new System.Drawing.Size(43, 17);
            this._inputTitulo.TabIndex = 16;
            this._inputTitulo.Text = "Título";
            // 
            // _btnAlta
            // 
            this._btnAlta.Location = new System.Drawing.Point(201, 248);
            this._btnAlta.Name = "_btnAlta";
            this._btnAlta.Size = new System.Drawing.Size(112, 23);
            this._btnAlta.TabIndex = 15;
            this._btnAlta.Text = "Crear";
            this._btnAlta.UseVisualStyleBackColor = true;
            this._btnAlta.Click += new System.EventHandler(this._btnAlta_Click);
            // 
            // _inputApellido
            // 
            this._inputApellido.Location = new System.Drawing.Point(85, 96);
            this._inputApellido.Name = "_inputApellido";
            this._inputApellido.Size = new System.Drawing.Size(228, 22);
            this._inputApellido.TabIndex = 14;
            // 
            // _inputNombre
            // 
            this._inputNombre.Location = new System.Drawing.Point(85, 68);
            this._inputNombre.Name = "_inputNombre";
            this._inputNombre.Size = new System.Drawing.Size(228, 22);
            this._inputNombre.TabIndex = 13;
            // 
            // _inputTemas
            // 
            this._inputTemas.AutoSize = true;
            this._inputTemas.Location = new System.Drawing.Point(13, 215);
            this._inputTemas.Name = "_inputTemas";
            this._inputTemas.Size = new System.Drawing.Size(51, 17);
            this._inputTemas.TabIndex = 26;
            this._inputTemas.Text = "Temas";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 212);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 22);
            this.textBox1.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(339, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 24);
            this.label7.TabIndex = 28;
            this.label7.Text = "Listado de Libros";
            // 
            // _lblListaLibros
            // 
            this._lblListaLibros.AutoSize = true;
            this._lblListaLibros.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblListaLibros.ForeColor = System.Drawing.Color.Red;
            this._lblListaLibros.Location = new System.Drawing.Point(339, 68);
            this._lblListaLibros.Name = "_lblListaLibros";
            this._lblListaLibros.Size = new System.Drawing.Size(0, 23);
            this._lblListaLibros.TabIndex = 27;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = global::Biblioteca.InterfazForm.Properties.Resources.libros;
            this.pictureBox1.Location = new System.Drawing.Point(16, 291);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 355);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // _btnAtras
            // 
            this._btnAtras.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this._btnAtras.Location = new System.Drawing.Point(869, 21);
            this._btnAtras.Name = "_btnAtras";
            this._btnAtras.Size = new System.Drawing.Size(119, 29);
            this._btnAtras.TabIndex = 30;
            this._btnAtras.Text = "Volver";
            this._btnAtras.UseVisualStyleBackColor = false;
            this._btnAtras.Click += new System.EventHandler(this._btnAtras_Click);
            // 
            // _dataGridLibros
            // 
            this._dataGridLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titulo,
            this.Autor,
            this.Edicion,
            this.Editorial,
            this.Paginas,
            this.Tema});
            this._dataGridLibros.Location = new System.Drawing.Point(343, 71);
            this._dataGridLibros.Name = "_dataGridLibros";
            this._dataGridLibros.RowHeadersWidth = 51;
            this._dataGridLibros.RowTemplate.Height = 24;
            this._dataGridLibros.Size = new System.Drawing.Size(645, 533);
            this._dataGridLibros.TabIndex = 31;
            // 
            // Titulo
            // 
            this.Titulo.HeaderText = "Título";
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
            // Edicion
            // 
            this.Edicion.HeaderText = "Edición";
            this.Edicion.MinimumWidth = 6;
            this.Edicion.Name = "Edicion";
            this.Edicion.Width = 125;
            // 
            // Editorial
            // 
            this.Editorial.HeaderText = "Editorial";
            this.Editorial.MinimumWidth = 6;
            this.Editorial.Name = "Editorial";
            this.Editorial.Width = 125;
            // 
            // Paginas
            // 
            this.Paginas.HeaderText = "Páginas";
            this.Paginas.MinimumWidth = 6;
            this.Paginas.Name = "Paginas";
            this.Paginas.Width = 125;
            // 
            // Tema
            // 
            this.Tema.HeaderText = "Tema";
            this.Tema.MinimumWidth = 6;
            this.Tema.Name = "Tema";
            this.Tema.Width = 125;
            // 
            // FrmLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1000, 830);
            this.Controls.Add(this._dataGridLibros);
            this.Controls.Add(this._btnAtras);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this._lblListaLibros);
            this.Controls.Add(this._inputTemas);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._inputPaginas);
            this.Controls.Add(this._inputEmail);
            this.Controls.Add(this._inputEditorial);
            this.Controls.Add(this._inputEdicion);
            this.Controls.Add(this._inputTelefono);
            this.Controls.Add(this._inputDireccion);
            this.Controls.Add(this._inputAutor);
            this.Controls.Add(this._inputTitulo);
            this.Controls.Add(this._btnAlta);
            this.Controls.Add(this._inputApellido);
            this.Controls.Add(this._inputNombre);
            this.Name = "FrmLibros";
            this.Text = "Libros";
            this.Load += new System.EventHandler(this.FrmLibros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridLibros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label _inputPaginas;
        private System.Windows.Forms.TextBox _inputEmail;
        private System.Windows.Forms.Label _inputEditorial;
        private System.Windows.Forms.Label _inputEdicion;
        private System.Windows.Forms.TextBox _inputTelefono;
        private System.Windows.Forms.TextBox _inputDireccion;
        private System.Windows.Forms.Label _inputAutor;
        private System.Windows.Forms.Label _inputTitulo;
        private System.Windows.Forms.Button _btnAlta;
        private System.Windows.Forms.TextBox _inputApellido;
        private System.Windows.Forms.TextBox _inputNombre;
        private System.Windows.Forms.Label _inputTemas;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label _lblListaLibros;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button _btnAtras;
        private System.Windows.Forms.DataGridView _dataGridLibros;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Editorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paginas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tema;
    }
}