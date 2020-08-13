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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        Procedures procedimientos = new Procedures();
        Complements complementos = new Complements();

        private void btn_connection_Click(object sender, EventArgs e)
        {
            //condiciones
            if(txt_user.Text == "")
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
            //storeprocedure
            if (procedimientos.LOGIN(txt_user,txt_pass))
            {
                Global.user = txt_user.Text;
                Global.id_user = Procedures.ID;      
                MessageBox.Show("Te logueaste correctamente");
                Biblioteca abrir = new Biblioteca();
                abrir.lbl_user.Text = "Bienvenido, " + Global.user +"!";
                abrir.Show();
                this.Hide();                           
            }
            else
            {
                MessageBox.Show("Error de usuario");
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

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que quiere salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            create_user abrir = new create_user();
            abrir.Show();
        }
    }
}
