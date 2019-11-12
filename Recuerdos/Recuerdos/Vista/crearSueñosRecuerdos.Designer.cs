namespace Recuerdos
{
    partial class crearSueñosRecuerdos
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
            this.lblTexto = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.txtNuevoNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTexto.Location = new System.Drawing.Point(18, 20);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(261, 19);
            this.lblTexto.TabIndex = 0;
            this.lblTexto.Text = "Ingrese el nuevo nombre para el";
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCrear.FlatAppearance.BorderSize = 0;
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.Location = new System.Drawing.Point(82, 107);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(74, 34);
            this.btnCrear.TabIndex = 1;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Cancelar.FlatAppearance.BorderSize = 0;
            this.Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancelar.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.Location = new System.Drawing.Point(212, 107);
            this.Cancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(74, 34);
            this.Cancelar.TabIndex = 2;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = false;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // txtNuevoNombre
            // 
            this.txtNuevoNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNuevoNombre.Location = new System.Drawing.Point(59, 58);
            this.txtNuevoNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNuevoNombre.Multiline = true;
            this.txtNuevoNombre.Name = "txtNuevoNombre";
            this.txtNuevoNombre.Size = new System.Drawing.Size(249, 22);
            this.txtNuevoNombre.TabIndex = 3;
            // 
            // crearSueñosRecuerdos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(366, 162);
            this.Controls.Add(this.txtNuevoNombre);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.lblTexto);
            this.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "crearSueñosRecuerdos";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "crearSueñosRecuerdos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.TextBox txtNuevoNombre;
    }
}