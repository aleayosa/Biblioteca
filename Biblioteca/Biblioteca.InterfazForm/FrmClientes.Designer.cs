
namespace Biblioteca.InterfazForm
{
    partial class FrmClientes
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
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this._btnVolver = new System.Windows.Forms.Button();
            this._dataGridClientes = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._inputNombre = new System.Windows.Forms.TextBox();
            this._inputApellido = new System.Windows.Forms.TextBox();
            this._btnAlta = new System.Windows.Forms.Button();
            this._lblNombre = new System.Windows.Forms.Label();
            this._lblApellido = new System.Windows.Forms.Label();
            this._inputDireccion = new System.Windows.Forms.TextBox();
            this._inputTelefono = new System.Windows.Forms.TextBox();
            this._lblDireccion = new System.Windows.Forms.Label();
            this._lblTelefono = new System.Windows.Forms.Label();
            this._inputEmail = new System.Windows.Forms.TextBox();
            this._lblEmail = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(396, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 29);
            this.label7.TabIndex = 15;
            this.label7.Text = "Listado de Clientes";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Biblioteca.InterfazForm.Properties.Resources.Springfield;
            this.pictureBox1.Location = new System.Drawing.Point(0, 328);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(354, 392);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // _btnVolver
            // 
            this._btnVolver.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this._btnVolver.Location = new System.Drawing.Point(1140, 22);
            this._btnVolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._btnVolver.Name = "_btnVolver";
            this._btnVolver.Size = new System.Drawing.Size(134, 36);
            this._btnVolver.TabIndex = 17;
            this._btnVolver.Text = "Volver";
            this._btnVolver.UseVisualStyleBackColor = false;
            this._btnVolver.Click += new System.EventHandler(this._btnVolver_Click);
            // 
            // _dataGridClientes
            // 
            this._dataGridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Apellido,
            this.Direccion,
            this.Telefono,
            this.Email});
            this._dataGridClientes.Location = new System.Drawing.Point(400, 81);
            this._dataGridClientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._dataGridClientes.Name = "_dataGridClientes";
            this._dataGridClientes.RowHeadersWidth = 51;
            this._dataGridClientes.RowTemplate.Height = 24;
            this._dataGridClientes.Size = new System.Drawing.Size(1616, 851);
            this._dataGridClientes.TabIndex = 18;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 62;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.MinimumWidth = 6;
            this.Apellido.Name = "Apellido";
            this.Apellido.Width = 125;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Dirección";
            this.Direccion.MinimumWidth = 6;
            this.Direccion.Name = "Direccion";
            this.Direccion.Width = 125;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Teléfono";
            this.Telefono.MinimumWidth = 6;
            this.Telefono.Name = "Telefono";
            this.Telefono.Width = 125;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 125;
            // 
            // _inputNombre
            // 
            this._inputNombre.Location = new System.Drawing.Point(98, 81);
            this._inputNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._inputNombre.Name = "_inputNombre";
            this._inputNombre.Size = new System.Drawing.Size(256, 26);
            this._inputNombre.TabIndex = 0;
            this._inputNombre.TextChanged += new System.EventHandler(this._inputNombre_TextChanged);
            // 
            // _inputApellido
            // 
            this._inputApellido.Location = new System.Drawing.Point(98, 116);
            this._inputApellido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._inputApellido.Name = "_inputApellido";
            this._inputApellido.Size = new System.Drawing.Size(256, 26);
            this._inputApellido.TabIndex = 1;
            // 
            // _btnAlta
            // 
            this._btnAlta.Location = new System.Drawing.Point(223, 275);
            this._btnAlta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._btnAlta.Name = "_btnAlta";
            this._btnAlta.Size = new System.Drawing.Size(126, 29);
            this._btnAlta.TabIndex = 2;
            this._btnAlta.Text = "Crear";
            this._btnAlta.UseVisualStyleBackColor = true;
            this._btnAlta.Click += new System.EventHandler(this._btnAlta_Click);
            // 
            // _lblNombre
            // 
            this._lblNombre.AutoSize = true;
            this._lblNombre.Location = new System.Drawing.Point(17, 85);
            this._lblNombre.Name = "_lblNombre";
            this._lblNombre.Size = new System.Drawing.Size(65, 20);
            this._lblNombre.TabIndex = 3;
            this._lblNombre.Text = "Nombre";
            // 
            // _lblApellido
            // 
            this._lblApellido.AutoSize = true;
            this._lblApellido.Location = new System.Drawing.Point(17, 121);
            this._lblApellido.Name = "_lblApellido";
            this._lblApellido.Size = new System.Drawing.Size(65, 20);
            this._lblApellido.TabIndex = 4;
            this._lblApellido.Text = "Apellido";
            // 
            // _inputDireccion
            // 
            this._inputDireccion.Location = new System.Drawing.Point(98, 155);
            this._inputDireccion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._inputDireccion.Name = "_inputDireccion";
            this._inputDireccion.Size = new System.Drawing.Size(256, 26);
            this._inputDireccion.TabIndex = 5;
            // 
            // _inputTelefono
            // 
            this._inputTelefono.Location = new System.Drawing.Point(98, 190);
            this._inputTelefono.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._inputTelefono.Name = "_inputTelefono";
            this._inputTelefono.Size = new System.Drawing.Size(256, 26);
            this._inputTelefono.TabIndex = 6;
            // 
            // _lblDireccion
            // 
            this._lblDireccion.AutoSize = true;
            this._lblDireccion.Location = new System.Drawing.Point(17, 159);
            this._lblDireccion.Name = "_lblDireccion";
            this._lblDireccion.Size = new System.Drawing.Size(75, 20);
            this._lblDireccion.TabIndex = 7;
            this._lblDireccion.Text = "Dirección";
            // 
            // _lblTelefono
            // 
            this._lblTelefono.AutoSize = true;
            this._lblTelefono.Location = new System.Drawing.Point(17, 195);
            this._lblTelefono.Name = "_lblTelefono";
            this._lblTelefono.Size = new System.Drawing.Size(71, 20);
            this._lblTelefono.TabIndex = 8;
            this._lblTelefono.Text = "Teléfono";
            // 
            // _inputEmail
            // 
            this._inputEmail.Location = new System.Drawing.Point(98, 226);
            this._inputEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._inputEmail.Name = "_inputEmail";
            this._inputEmail.Size = new System.Drawing.Size(256, 26);
            this._inputEmail.TabIndex = 9;
            // 
            // _lblEmail
            // 
            this._lblEmail.AutoSize = true;
            this._lblEmail.Location = new System.Drawing.Point(17, 230);
            this._lblEmail.Name = "_lblEmail";
            this._lblEmail.Size = new System.Drawing.Size(48, 20);
            this._lblEmail.TabIndex = 11;
            this._lblEmail.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(346, 26);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ingrese los datos del nuevo cliente";
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 976);
            this.Controls.Add(this._dataGridClientes);
            this.Controls.Add(this._btnVolver);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._lblEmail);
            this.Controls.Add(this._inputEmail);
            this.Controls.Add(this._lblTelefono);
            this.Controls.Add(this._lblDireccion);
            this.Controls.Add(this._inputTelefono);
            this.Controls.Add(this._inputDireccion);
            this.Controls.Add(this._lblApellido);
            this.Controls.Add(this._lblNombre);
            this.Controls.Add(this._btnAlta);
            this.Controls.Add(this._inputApellido);
            this.Controls.Add(this._inputNombre);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.FrmAltaCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button _btnVolver;
        private System.Windows.Forms.DataGridView _dataGridClientes;
        private System.Windows.Forms.TextBox _inputNombre;
        private System.Windows.Forms.TextBox _inputApellido;
        private System.Windows.Forms.Button _btnAlta;
        private System.Windows.Forms.Label _lblNombre;
        private System.Windows.Forms.Label _lblApellido;
        private System.Windows.Forms.TextBox _inputDireccion;
        private System.Windows.Forms.TextBox _inputTelefono;
        private System.Windows.Forms.Label _lblDireccion;
        private System.Windows.Forms.Label _lblTelefono;
        private System.Windows.Forms.TextBox _inputEmail;
        private System.Windows.Forms.Label _lblEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}