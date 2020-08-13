namespace Biblioteca_juegos
{
    partial class Menu_juegos
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
            this.btn_agregar = new System.Windows.Forms.Button();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.cmb_plat = new System.Windows.Forms.ComboBox();
            this.cmb_splat = new System.Windows.Forms.ComboBox();
            this.Error = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbl_ID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(202, 161);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(134, 34);
            this.btn_exit.TabIndex = 8;
            this.btn_exit.Text = "Salir";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(12, 161);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(134, 34);
            this.btn_agregar.TabIndex = 14;
            this.btn_agregar.Text = "Añadir";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Location = new System.Drawing.Point(12, 13);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(90, 13);
            this.lbl_1.TabIndex = 15;
            this.lbl_1.Text = "Nombre del juego";
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.Location = new System.Drawing.Point(12, 61);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(57, 13);
            this.lbl_2.TabIndex = 16;
            this.lbl_2.Text = "Plataforma";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(15, 30);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(321, 20);
            this.txt_name.TabIndex = 17;
            // 
            // cmb_plat
            // 
            this.cmb_plat.FormattingEnabled = true;
            this.cmb_plat.Location = new System.Drawing.Point(15, 90);
            this.cmb_plat.Name = "cmb_plat";
            this.cmb_plat.Size = new System.Drawing.Size(121, 21);
            this.cmb_plat.TabIndex = 18;
            this.cmb_plat.SelectedIndexChanged += new System.EventHandler(this.cmb_plat_SelectedIndexChanged);
            // 
            // cmb_splat
            // 
            this.cmb_splat.FormattingEnabled = true;
            this.cmb_splat.Location = new System.Drawing.Point(202, 90);
            this.cmb_splat.Name = "cmb_splat";
            this.cmb_splat.Size = new System.Drawing.Size(121, 21);
            this.cmb_splat.TabIndex = 19;
            // 
            // Error
            // 
            this.Error.ContainerControl = this;
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(301, 14);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(18, 13);
            this.lbl_ID.TabIndex = 20;
            this.lbl_ID.Text = "ID";
            this.lbl_ID.Visible = false;
            // 
            // Menu_juegos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 210);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.cmb_splat);
            this.Controls.Add(this.cmb_plat);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_2);
            this.Controls.Add(this.lbl_1);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.btn_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Menu_juegos";
            this.Text = "Añadir juego";
            this.Load += new System.EventHandler(this.Menu_juegos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.Label lbl_2;
        private System.Windows.Forms.ErrorProvider Error;
        public System.Windows.Forms.Label lbl_ID;
        public System.Windows.Forms.TextBox txt_name;
        public System.Windows.Forms.ComboBox cmb_plat;
        public System.Windows.Forms.ComboBox cmb_splat;
        public System.Windows.Forms.Button btn_exit;
        public System.Windows.Forms.Button btn_agregar;
    }
}