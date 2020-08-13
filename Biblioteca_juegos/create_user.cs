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
    public partial class create_user : Form
    {
        public create_user()
        {
            InitializeComponent();
        }
        Procedures procedimientos = new Procedures();
        Complements complementos = new Complements();

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que quiere cerrar?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            //condiciones
            if (txt_user.Text == "")
            {
                Error.SetError(txt_user, "Ingrese el nombre de usuario");
                txt_user.Focus();
                return;
            }
            Error.SetError(txt_user, "");
            if (txt_pass.Text == "")
            {
                Error.SetError(txt_pass, "Ingrese la contraseña");
                txt_pass.Focus();
                return;
            }
            Error.SetError(txt_pass, "");
            if (txt_pass2.Text == "")
            {
                Error.SetError(txt_pass2, "Ingrese la contraseña");
                txt_pass2.Focus();
                return;
            }
            Error.SetError(txt_pass2, "");
            if (txt_pass.Text != txt_pass2.Text)
            {
                Error.SetError(txt_pass2, "Las contraseñas no coinciden");
                txt_pass2.Focus();
                return;
            }
            Error.SetError(txt_pass2, "");
            //store procedure
            if (procedimientos.CHECK_USER(txt_user))
            {
                MessageBox.Show("Nombre de usuario ya existente");
            }
            else
            {
                procedimientos.CREATE_USER(txt_user, txt_pass);
                this.Close();
            }
        }

        private void txt_user_KeyPress(object sender, KeyPressEventArgs e)
        {
            complementos.Teclado_SinEspacio(e);
        }

        private void txt_pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            complementos.Teclado_SinEspacio(e);
        }

        private void txt_pass2_KeyPress(object sender, KeyPressEventArgs e)
        {
            complementos.Teclado_SinEspacio(e);
        }
    }
}
