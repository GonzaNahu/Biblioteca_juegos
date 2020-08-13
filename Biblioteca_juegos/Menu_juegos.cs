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
    public partial class Menu_juegos : Form
    {
        public Menu_juegos()
        {
            InitializeComponent();
            cmb_plat.DataSource = Llenar.PLATAFORMAS();
            cmb_plat.ValueMember = "ID";
            cmb_plat.DisplayMember = "Plataforma";
        }
        Procedures procedimientos = new Procedures();
        ComboBox Llenar = new ComboBox();

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que quiere salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Global.ind = 0;
                this.Close();
            }
        }

        private void Menu_juegos_Load(object sender, EventArgs e)
        {
            if (Global.ind == 0)
            {
                btn_agregar.Text = "Añadir";
            }
            else if (Global.ind == 1)
            {
                btn_agregar.Text = "Modificar";
            }
            cmb_splat.DataSource = Llenar.SPLATAFORMAS(cmb_plat);
            cmb_splat.ValueMember = "IDS";
            cmb_splat.DisplayMember = "SPlataforma";
        }

        private void cmb_plat_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_splat.DataSource = Llenar.SPLATAFORMAS(cmb_plat);
            cmb_splat.ValueMember = "IDS";
            cmb_splat.DisplayMember = "SPlataforma";
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (Global.ind == 0)
            {
                if (txt_name.Text == "")
                {
                    Error.SetError(txt_name, "Ingrese el nombre del juego");
                    txt_name.Focus();
                    return;
                }
                Error.SetError(txt_name, "");
                if (procedimientos.CHECK_GAME(txt_name, cmb_plat, cmb_splat, Global.id_user))
                {
                    MessageBox.Show("Dato repetido");
                }
                else
                {
                    procedimientos.ADD_GAME(txt_name, cmb_plat, cmb_splat, Global.id_user);
                }
            }
            else if (Global.ind == 1)
            {
                if (txt_name.Text == "")
                {
                    Error.SetError(txt_name, "Ingrese el nombre del juego");
                    txt_name.Focus();
                    return;
                }
                Error.SetError(txt_name, "");
                if (procedimientos.CHECK_GAME(txt_name, cmb_plat, cmb_splat, Global.id_user))
                {
                    MessageBox.Show("Dato repetido");
                }
                else
                {
                    int ID = Convert.ToInt32(lbl_ID.Text);
                    procedimientos.DATA_MOD(ID,txt_name, cmb_plat, cmb_splat, Global.id_user);
                    this.Close();
                }
            }
            
        }
    }
}
