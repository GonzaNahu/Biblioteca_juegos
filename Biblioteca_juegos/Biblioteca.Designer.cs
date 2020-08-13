namespace Biblioteca_juegos
{
    partial class Biblioteca
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
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_user = new System.Windows.Forms.Label();
            this.btn_exit2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mENUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirJuegoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirmodificareliminarPlataformaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.btn_mod = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(345, 490);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(134, 34);
            this.btn_exit.TabIndex = 7;
            this.btn_exit.Text = "Salir";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Location = new System.Drawing.Point(19, 472);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(35, 13);
            this.lbl_user.TabIndex = 8;
            this.lbl_user.Text = "label1";
            // 
            // btn_exit2
            // 
            this.btn_exit2.Location = new System.Drawing.Point(15, 490);
            this.btn_exit2.Name = "btn_exit2";
            this.btn_exit2.Size = new System.Drawing.Size(134, 34);
            this.btn_exit2.TabIndex = 9;
            this.btn_exit2.Text = "Cerrar sesión";
            this.btn_exit2.UseVisualStyleBackColor = true;
            this.btn_exit2.Click += new System.EventHandler(this.btn_exit2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mENUToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(491, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mENUToolStripMenuItem
            // 
            this.mENUToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirJuegoToolStripMenuItem,
            this.añadirmodificareliminarPlataformaToolStripMenuItem});
            this.mENUToolStripMenuItem.Name = "mENUToolStripMenuItem";
            this.mENUToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.mENUToolStripMenuItem.Text = "MENU";
            // 
            // añadirJuegoToolStripMenuItem
            // 
            this.añadirJuegoToolStripMenuItem.Name = "añadirJuegoToolStripMenuItem";
            this.añadirJuegoToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.añadirJuegoToolStripMenuItem.Text = "Añadir juego";
            this.añadirJuegoToolStripMenuItem.Click += new System.EventHandler(this.añadirJuegoToolStripMenuItem_Click);
            // 
            // añadirmodificareliminarPlataformaToolStripMenuItem
            // 
            this.añadirmodificareliminarPlataformaToolStripMenuItem.Name = "añadirmodificareliminarPlataformaToolStripMenuItem";
            this.añadirmodificareliminarPlataformaToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.añadirmodificareliminarPlataformaToolStripMenuItem.Text = "Añadir plataforma";
            this.añadirmodificareliminarPlataformaToolStripMenuItem.Click += new System.EventHandler(this.añadirmodificareliminarPlataformaToolStripMenuItem_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(15, 27);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(324, 442);
            this.dgv.TabIndex = 11;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(345, 435);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(134, 34);
            this.btn_refresh.TabIndex = 12;
            this.btn_refresh.Text = "Refrescar";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_borrar
            // 
            this.btn_borrar.Location = new System.Drawing.Point(345, 67);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(134, 34);
            this.btn_borrar.TabIndex = 13;
            this.btn_borrar.Text = "Eliminar";
            this.btn_borrar.UseVisualStyleBackColor = true;
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // btn_mod
            // 
            this.btn_mod.Location = new System.Drawing.Point(345, 27);
            this.btn_mod.Name = "btn_mod";
            this.btn_mod.Size = new System.Drawing.Size(134, 34);
            this.btn_mod.TabIndex = 14;
            this.btn_mod.Text = "Modificar";
            this.btn_mod.UseVisualStyleBackColor = true;
            this.btn_mod.Click += new System.EventHandler(this.btn_mod_Click);
            // 
            // Biblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 536);
            this.ControlBox = false;
            this.Controls.Add(this.btn_mod);
            this.Controls.Add(this.btn_borrar);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btn_exit2);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Biblioteca";
            this.Text = "Biblioteca";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        public System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Button btn_exit2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mENUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirJuegoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirmodificareliminarPlataformaToolStripMenuItem;
        public System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_borrar;
        private System.Windows.Forms.Button btn_mod;
    }
}