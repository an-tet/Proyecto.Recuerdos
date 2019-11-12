namespace Recuerdos.Vista
{
    partial class Registro
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContracena = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContracena = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblConfirmarContracena = new System.Windows.Forms.Label();
            this.txtConfirmarContracena = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(5, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(628, 56);
            this.label2.TabIndex = 1;
            this.label2.Text = "Para registrarte, rellena el siguiente formulari. Prometemos que solo te \r\ntomará" +
    " un minuto......... o dos (づ￣ 3￣)づ\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombres.ForeColor = System.Drawing.Color.White;
            this.lblNombres.Location = new System.Drawing.Point(46, 114);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(87, 23);
            this.lblNombres.TabIndex = 2;
            this.lblNombres.Text = "Nombres*";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.ForeColor = System.Drawing.Color.White;
            this.lblApellidos.Location = new System.Drawing.Point(345, 111);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(86, 23);
            this.lblApellidos.TabIndex = 3;
            this.lblApellidos.Text = "Apellidos*";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(46, 154);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(75, 23);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Usuario*";
            // 
            // lblContracena
            // 
            this.lblContracena.AutoSize = true;
            this.lblContracena.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContracena.ForeColor = System.Drawing.Color.White;
            this.lblContracena.Location = new System.Drawing.Point(345, 154);
            this.lblContracena.Name = "lblContracena";
            this.lblContracena.Size = new System.Drawing.Size(104, 23);
            this.lblContracena.TabIndex = 5;
            this.lblContracena.Text = "Contraseña*";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(143, 108);
            this.txtNombres.MaxLength = 20;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(173, 22);
            this.txtNombres.TabIndex = 6;
            this.txtNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombres_KeyPress);
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(455, 108);
            this.txtApellidos.MaxLength = 15;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(173, 22);
            this.txtApellidos.TabIndex = 7;
            this.txtApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidos_KeyPress);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(143, 154);
            this.txtUsuario.MaxLength = 15;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(173, 22);
            this.txtUsuario.TabIndex = 8;
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // txtContracena
            // 
            this.txtContracena.Location = new System.Drawing.Point(455, 154);
            this.txtContracena.MaxLength = 20;
            this.txtContracena.Name = "txtContracena";
            this.txtContracena.PasswordChar = '*';
            this.txtContracena.Size = new System.Drawing.Size(173, 22);
            this.txtContracena.TabIndex = 9;
            this.txtContracena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContracena_KeyPress);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrar.Location = new System.Drawing.Point(196, 298);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(84, 34);
            this.btnRegistrar.TabIndex = 10;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(356, 298);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 34);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCorreo.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.White;
            this.lblCorreo.Location = new System.Drawing.Point(46, 233);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(158, 23);
            this.lblCorreo.TabIndex = 12;
            this.lblCorreo.Text = "Correo electrónico*";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(231, 233);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(415, 22);
            this.txtCorreo.TabIndex = 13;
            this.txtCorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCorreo_KeyPress);
            // 
            // lblConfirmarContracena
            // 
            this.lblConfirmarContracena.AutoSize = true;
            this.lblConfirmarContracena.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmarContracena.ForeColor = System.Drawing.Color.White;
            this.lblConfirmarContracena.Location = new System.Drawing.Point(46, 198);
            this.lblConfirmarContracena.Name = "lblConfirmarContracena";
            this.lblConfirmarContracena.Size = new System.Drawing.Size(182, 23);
            this.lblConfirmarContracena.TabIndex = 14;
            this.lblConfirmarContracena.Text = "Confirmar contraseña*";
            // 
            // txtConfirmarContracena
            // 
            this.txtConfirmarContracena.Location = new System.Drawing.Point(231, 198);
            this.txtConfirmarContracena.Name = "txtConfirmarContracena";
            this.txtConfirmarContracena.Size = new System.Drawing.Size(173, 22);
            this.txtConfirmarContracena.TabIndex = 15;
            this.txtConfirmarContracena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConfirmarContracena_KeyPress);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(709, 344);
            this.ControlBox = false;
            this.Controls.Add(this.txtConfirmarContracena);
            this.Controls.Add(this.lblConfirmarContracena);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtContracena);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.lblContracena);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Registro";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContracena;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContracena;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblConfirmarContracena;
        private System.Windows.Forms.TextBox txtConfirmarContracena;
    }
}