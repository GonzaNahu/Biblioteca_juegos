namespace Biblioteca_juegos
{
    partial class login
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
            this.components = new System.ComponentModel.Container();
            this.lbl_user = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.btn_connection = new System.Windows.Forms.Button();
            this.btn_create = new System.Windows.Forms.Button();
            this.Error = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Location = new System.Drawing.Point(13, 17);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(43, 13);
            this.lbl_user.TabIndex = 0;
            this.lbl_user.Text = "Usuario";
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Location = new System.Drawing.Point(13, 57);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(61, 13);
            this.lbl_pass.TabIndex = 1;
            this.lbl_pass.Text = "Contraseña";
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(91, 14);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(186, 20);
            this.txt_user.TabIndex = 2;
            this.txt_user.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_user_KeyPress);
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(91, 57);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(186, 20);
            this.txt_pass.TabIndex = 3;
            this.txt_pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pass_KeyPress);
            // 
            // btn_connection
            // 
            this.btn_connection.Location = new System.Drawing.Point(182, 92);
            this.btn_connection.Name = "btn_connection";
            this.btn_connection.Size = new System.Drawing.Size(134, 34);
            this.btn_connection.TabIndex = 4;
            this.btn_connection.Text = "Entrar";
            this.btn_connection.UseVisualStyleBackColor = true;
            this.btn_connection.Click += new System.EventHandler(this.btn_connection_Click);
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(42, 92);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(134, 34);
            this.btn_create.TabIndex = 5;
            this.btn_create.Text = "Crear usuario";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // Error
            // 
            this.Error.ContainerControl = this;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(182, 132);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(134, 34);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.Text = "Salir";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 176);
            this.ControlBox = false;
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.btn_connection);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_user);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.Error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Button btn_connection;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.ErrorProvider Error;
        private System.Windows.Forms.Button btn_exit;
    }
}

