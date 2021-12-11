
namespace Login
{
    partial class Ventana
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.login = new System.Windows.Forms.Button();
            this.tbusuario = new System.Windows.Forms.TextBox();
            this.tbcontraseña = new System.Windows.Forms.TextBox();
            this.UsuarioLB = new System.Windows.Forms.Label();
            this.contraseñaLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.SystemColors.Window;
            this.login.ForeColor = System.Drawing.SystemColors.ControlText;
            this.login.Location = new System.Drawing.Point(155, 217);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(125, 33);
            this.login.TabIndex = 0;
            this.login.Text = "Iniciar sesión";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // tbusuario
            // 
            this.tbusuario.Location = new System.Drawing.Point(228, 75);
            this.tbusuario.Name = "tbusuario";
            this.tbusuario.Size = new System.Drawing.Size(100, 20);
            this.tbusuario.TabIndex = 1;
            // 
            // tbcontraseña
            // 
            this.tbcontraseña.Location = new System.Drawing.Point(228, 144);
            this.tbcontraseña.Name = "tbcontraseña";
            this.tbcontraseña.Size = new System.Drawing.Size(100, 20);
            this.tbcontraseña.TabIndex = 2;
            // 
            // UsuarioLB
            // 
            this.UsuarioLB.AutoSize = true;
            this.UsuarioLB.Location = new System.Drawing.Point(92, 78);
            this.UsuarioLB.Name = "UsuarioLB";
            this.UsuarioLB.Size = new System.Drawing.Size(96, 13);
            this.UsuarioLB.TabIndex = 3;
            this.UsuarioLB.Text = "Nombre de usuario";
            this.UsuarioLB.Click += new System.EventHandler(this.UsuarioLB_Click);
            // 
            // contraseñaLB
            // 
            this.contraseñaLB.AutoSize = true;
            this.contraseñaLB.Location = new System.Drawing.Point(107, 147);
            this.contraseñaLB.Name = "contraseñaLB";
            this.contraseñaLB.Size = new System.Drawing.Size(61, 13);
            this.contraseñaLB.TabIndex = 4;
            this.contraseñaLB.Text = "Contraseña";
            this.contraseñaLB.Click += new System.EventHandler(this.label2_Click);
            // 
            // Ventana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(426, 314);
            this.Controls.Add(this.contraseñaLB);
            this.Controls.Add(this.UsuarioLB);
            this.Controls.Add(this.tbcontraseña);
            this.Controls.Add(this.tbusuario);
            this.Controls.Add(this.login);
            this.Name = "Ventana";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Ventana_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login;
        private System.Windows.Forms.TextBox tbusuario;
        private System.Windows.Forms.TextBox tbcontraseña;
        private System.Windows.Forms.Label UsuarioLB;
        private System.Windows.Forms.Label contraseñaLB;
    }
}

