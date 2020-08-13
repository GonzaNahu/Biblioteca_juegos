namespace Biblioteca_juegos
{
    partial class create_user
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
            this.components = new System.ComponentModel.Container();
            this.btn_exit = new System.Windows.Forms.Button();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.txt_pass2 = new System.Windows.Forms.TextBox();
            this.lbl_pass2 = new System.Windows.Forms.Label();
            this.btn_create = new System.Windows.Forms.Button();
            this.Error = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(138, 169);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(134, 34);
            this.btn_exit.TabIndex = 7;
            this.btn_exit.Text = "Cerrar";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(112, 49);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(164, 20);
            this.txt_pass.TabIndex = 11;
            this.txt_pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pass_KeyPress);
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(90, 6);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(186, 20);
            this.txt_user.TabIndex = 10;
            this.txt_user.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_user_KeyPress);
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Location = new System.Drawing.Point(12, 49);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(61, 13);
            this.lbl_pass.TabIndex = 9;
            this.lbl_pass.Text = "Contraseña";
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Location = new System.Drawing.Point(12, 9);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(43, 13);
            this.lbl_user.TabIndex = 8;
            this.lbl_user.Text = "Usuario";
            // 
            // txt_pass2
            // 
            this.txt_pass2.Location = new System.Drawing.Point(112, 93);
            this.txt_pass2.Name = "txt_pass2";
            this.txt_pass2.PasswordChar = '*';
            this.txt_pass2.Size = new System.Drawing.Size(164, 20);
            this.txt_pass2.TabIndex = 13;
            this.txt_pass2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pass2_KeyPress);
            // 
            // lbl_pass2
            // 
            this.lbl_pass2.AutoSize = true;
            this.lbl_pass2.Location = new System.Drawing.Point(12, 96);
            this.lbl_pass2.Name = "lbl_pass2";
            this.lbl_pass2.Size = new System.Drawing.Size(94, 13);
            this.lbl_pass2.TabIndex = 12;
            this.lbl_pass2.Text = "Repita contraseña";
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(15, 129);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(261, 34);
            this.btn_create.TabIndex = 14;
            this.btn_create.Text = "Crear usuario";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // Error
            // 
            this.Error.ContainerControl = this;
            // 
            // create_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 213);
            this.ControlBox = false;
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.txt_pass2);
            this.Controls.Add(this.lbl_pass2);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.btn_exit);
            this.Name = "create_user";
            this.Text = "Crear usuario";
            ((System.ComponentModel.ISupportInitialize)(this.Error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label lbl_pass2;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.ErrorProvider Error;
        public System.Windows.Forms.TextBox txt_pass;
        public System.Windows.Forms.TextBox txt_user;
        public System.Windows.Forms.TextBox txt_pass2;
    }
}