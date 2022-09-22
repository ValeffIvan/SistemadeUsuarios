using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Usuarios.Vistas;
using Usuarios.Controles;

namespace Usuarios
{
    public partial class FormLogin : Form
    {
        UsuariosControl usuariosControl = new UsuariosControl();
        string usuario;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            if (usuariosControl.Ingresar(txt_nombre.Text, txt_password.Text))
            {
                usuario = txt_nombre.Text;
                FormPrincipal formPrincipal = new FormPrincipal(usuario);
                formPrincipal.Owner = this;
                formPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecto");
            }
        }

        private void lbllink_recuperar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRecuperarContrasenia formRecuperarContrasenia = new FormRecuperarContrasenia();
            formRecuperarContrasenia.Owner = this;
            formRecuperarContrasenia.Show();
            this.Hide();
        }
    }
}
