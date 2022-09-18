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
    public partial class FormCrearUsuario : Form
    {
        UsuariosControl usuariosControl = new UsuariosControl();
        string usuario;
        public FormCrearUsuario()
        {
            InitializeComponent();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Owner.Visible = true;
            this.Close();
        }

        private void btn_crear_Click(object sender, EventArgs e)
        {
           MessageBox.Show(usuariosControl.Agregar(txt_nombre.Text, txt_contra.Text, cb_pregunta.Text, txt_respuesta.Text, cb_admin.Checked));
        }
    }
}
