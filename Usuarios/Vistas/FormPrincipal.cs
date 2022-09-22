using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Usuarios.Controles;

namespace Usuarios.Vistas
{
    public partial class FormPrincipal : Form
    {
        string usuario;
        UsuariosControl usuariosControl = new UsuariosControl();
        public FormPrincipal(string us)
        {
            InitializeComponent();
            usuario = us;
            if (!usuariosControl.CorroborarAdministrador(usuario))
            {
                btn_crear.Enabled = false;
                btn_listar.Enabled = false;
                btn_eliminar.Enabled = false;
            }
        }

        private void btn_crear_Click(object sender, EventArgs e)
        {
            FormCrearUsuario formCrearUsuario = new FormCrearUsuario();
            formCrearUsuario.Owner = this;
            formCrearUsuario.Show();
            this.Hide();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (usuariosControl.CorroborarAdministrador(usuario))
            {
                FormListarUsuarios formListarUsuarios = new FormListarUsuarios();
                formListarUsuarios.Owner = this;
                formListarUsuarios.Show();
                this.Hide();
            }
            else
            {
                FormModificarUsuario formModificarUsuario = new FormModificarUsuario(usuario);
                formModificarUsuario.Owner = this;
                formModificarUsuario.Show();
                this.Hide();
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}
