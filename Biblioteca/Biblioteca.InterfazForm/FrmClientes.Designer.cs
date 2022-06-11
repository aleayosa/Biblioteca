
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._inputDireccion = new System.Windows.Forms.TextBox();
            this._inputTelefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._inputEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
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
            this._btnVolver.Location = new System.Drawing.Point(1459, 18);
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
            this._dataGridClientes.Location = new System.Drawing.Point(387, 80);
            this._dataGridClientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._dataGridClientes.Name = "_dataGridClientes";
            this._dataGridClientes.RowHeadersWidth = 51;
            this._dataGridClientes.RowTemplate.Height = 24;
            this._dataGridClientes.Size = new System.Drawing.Size(1234, 717);
            this._dataGridClientes.TabIndex = 18;
            this._dataGridClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._dataGridClientes_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 125;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Apellido";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Dirección";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Teléfono";
            // 
            // _inputEmail
            // 
            this._inputEmail.Location = new System.Drawing.Point(98, 226);
            this._inputEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._inputEmail.Name = "_inputEmail";
            this._inputEmail.Size = new System.Drawing.Size(256, 26);
            this._inputEmail.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Email";
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
            this.ClientSize = new System.Drawing.Size(1613, 830);
            this.Controls.Add(this._dataGridClientes);
            this.Controls.Add(this._btnVolver);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this._inputEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._inputTelefono);
            this.Controls.Add(this._inputDireccion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._btnAlta);
            this.Controls.Add(this._inputApellido);
            this.Controls.Add(this._inputNombre);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _inputDireccion;
        private System.Windows.Forms.TextBox _inputTelefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _inputEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}