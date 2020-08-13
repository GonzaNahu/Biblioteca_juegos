namespace Biblioteca_juegos
{
    partial class Menu_plataforma
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
            this.lbl_1 = new System.Windows.Forms.Label();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.cmb_alt = new System.Windows.Forms.ComboBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.Error = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(63, 168);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(134, 34);
            this.btn_exit.TabIndex = 8;
            this.btn_exit.Text = "Salir";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Location = new System.Drawing.Point(12, 9);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(46, 13);
            this.lbl_1.TabIndex = 9;
            this.lbl_1.Text = "Sección";
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.Location = new System.Drawing.Point(14, 61);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(44, 13);
            this.lbl_2.TabIndex = 10;
            this.lbl_2.Text = "Nombre";
            // 
            // cmb_alt
            // 
            this.cmb_alt.FormattingEnabled = true;
            this.cmb_alt.Location = new System.Drawing.Point(12, 25);
            this.cmb_alt.Name = "cmb_alt";
            this.cmb_alt.Size = new System.Drawing.Size(242, 21);
            this.cmb_alt.TabIndex = 11;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(12, 88);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(242, 20);
            this.txt_name.TabIndex = 12;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(63, 128);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(134, 34);
            this.btn_agregar.TabIndex = 13;
            this.btn_agregar.Text = "Añadir";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // Error
            // 
            this.Error.ContainerControl = this;
            // 
            // Menu_plataforma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 217);
            this.ControlBox = false;
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.cmb_alt);
            this.Controls.Add(this.lbl_2);
            this.Controls.Add(this.lbl_1);
            this.Controls.Add(this.btn_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Menu_plataforma";
            this.Text = "Añadir/modificar/eliminar plataformas";
            ((System.ComponentModel.ISupportInitialize)(this.Error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.Label lbl_2;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.ErrorProvider Error;
        public System.Windows.Forms.ComboBox cmb_alt;
    }
}