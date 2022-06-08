
namespace Biblioteca.InterfazForm
{
    partial class FrmAltaDeCliente
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
            this._inputNombre = new System.Windows.Forms.TextBox();
            this._inputApellido = new System.Windows.Forms.TextBox();
            this._btnAltaCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._inputDireccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this._inputTelefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this._inputEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _inputNombre
            // 
            this._inputNombre.Location = new System.Drawing.Point(96, 62);
            this._inputNombre.Name = "_inputNombre";
            this._inputNombre.Size = new System.Drawing.Size(234, 22);
            this._inputNombre.TabIndex = 0;
            // 
            // _inputApellido
            // 
            this._inputApellido.Location = new System.Drawing.Point(96, 89);
            this._inputApellido.Name = "_inputApellido";
            this._inputApellido.Size = new System.Drawing.Size(234, 22);
            this._inputApellido.TabIndex = 1;
            // 
            // _btnAltaCliente
            // 
            this._btnAltaCliente.Location = new System.Drawing.Point(255, 219);
            this._btnAltaCliente.Name = "_btnAltaCliente";
            this._btnAltaCliente.Size = new System.Drawing.Size(75, 23);
            this._btnAltaCliente.TabIndex = 2;
            this._btnAltaCliente.Text = "Crear Cliente";
            this._btnAltaCliente.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dirección";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // _inputDireccion
            // 
            this._inputDireccion.Location = new System.Drawing.Point(96, 117);
            this._inputDireccion.Name = "_inputDireccion";
            this._inputDireccion.Size = new System.Drawing.Size(234, 22);
            this._inputDireccion.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Teléfono";
            // 
            // _inputTelefono
            // 
            this._inputTelefono.Location = new System.Drawing.Point(96, 146);
            this._inputTelefono.Name = "_inputTelefono";
            this._inputTelefono.Size = new System.Drawing.Size(234, 22);
            this._inputTelefono.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Email";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // _inputEmail
            // 
            this._inputEmail.Location = new System.Drawing.Point(96, 174);
            this._inputEmail.Name = "_inputEmail";
            this._inputEmail.Size = new System.Drawing.Size(234, 22);
            this._inputEmail.TabIndex = 9;
            this._inputEmail.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(25, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(336, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ingrese los datos del nuevo cliente";
            // 
            // FrmAltaDeCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._inputEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._inputTelefono);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._inputDireccion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._btnAltaCliente);
            this.Controls.Add(this._inputApellido);
            this.Controls.Add(this._inputNombre);
            this.Name = "FrmAltaDeCliente";
            this.Text = "Alta de Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _inputNombre;
        private System.Windows.Forms.TextBox _inputApellido;
        private System.Windows.Forms.Button _btnAltaCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _inputDireccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _inputTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _inputEmail;
        private System.Windows.Forms.Label label6;
    }
}