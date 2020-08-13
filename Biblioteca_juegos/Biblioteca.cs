using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca_juegos
{
    public partial class Biblioteca : Form
    {
        public Biblioteca()
        {
            InitializeComponent();
            procedimientos.USER_DATA(Global.id_user, dgv);
            dgv.Columns["ID"].Visible = false;
            btn_borrar.Enabled = false;
            btn_mod.Enabled = false;
        }
        Procedures procedimientos = new Procedures();

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que quiere salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                login cerrar = new login();
                cerrar.Close();
                this.Close();
            }
        }

        private void btn_exit2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que quiere cerrar sesión?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                login abrir = new login();
                abrir.Show();
                this.Close();
            }
        }

        private void añadirmodificareliminarPlataformaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu_plataforma abrir = new Menu_plataforma();
            abrir.Show();
        }

        private void añadirJuegoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu_juegos abrir = new Menu_juegos();
            Global.ind = 0;
            abrir.Show();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            dgv.DataSource = null;
            dgv.Rows.Clear();
            procedimientos.USER_DATA(Global.id_user, dgv);
            dgv.Columns["ID"].Visible = false;
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            DataGridViewRow datos = dgv.CurrentRow;
            int ID = Convert.ToInt32(datos.Cells["ID"].Value);
            if (MessageBox.Show("¿Esta seguro de que desea eliminar el juego de la biblioteca?", "Eliminar juego", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                procedimientos.DATA_DELETE(ID, Global.id_user);
                dgv.DataSource = null;
                dgv.Rows.Clear();
                procedimientos.USER_DATA(Global.id_user, dgv);
                dgv.Columns["ID"].Visible = false;
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_mod.Enabled = true;
            btn_borrar.Enabled = true;
        }

        private void btn_mod_Click(object sender, EventArgs e)
        {
            Menu_juegos abrir = new Menu_juegos();
            DataGridViewRow datos = dgv.CurrentRow;
            int ID = Convert.ToInt32(datos.Cells["ID"].Value);
            abrir.Text = "Modificar juego";
            abrir.lbl_ID.Text = Convert.ToString(ID);
            abrir.txt_name.Text = datos.Cells["JUEGO"].Value.ToString();
            Global.ind = 1;
            abrir.Show();
        }
    }
}
