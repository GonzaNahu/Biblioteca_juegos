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
    public partial class Menu_plataforma : Form
    {
        public Menu_plataforma()
        {
            InitializeComponent();
            cmb_alt.DataSource = Llenar.PLATAFORMAS();
            cmb_alt.ValueMember = "ID";
            cmb_alt.DisplayMember = "Plataforma";
        }
        Procedures procedimientos = new Procedures();
        ComboBox Llenar = new ComboBox();

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que quiere salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "")
            {
                Error.SetError(txt_name, "Ingrese el nombre");
                txt_name.Focus();
                return;
            }
            Error.SetError(txt_name, "");
            if (procedimientos.CHECK_PLATAFORM(txt_name))
            {
                MessageBox.Show("Plataforma ya existente");
            }
            else
            {
                procedimientos.CREATE_PLATAFORM(txt_name, cmb_alt);
                txt_name.Text = "";
            }
        }
    }
}
