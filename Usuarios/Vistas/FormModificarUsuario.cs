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
    public partial class FormModificarUsuario : Form
    {
        UsuariosControl usuariosControl = new UsuariosControl();
        string usuario;
        public FormModificarUsuario(string us)
        {
            InitializeComponent();
            usuario = us;
        }

        private void btn_cambiar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(usuariosControl.CambiarPregunta(usuario,cb_pregunta.Text,txt_respuesta.Text));

        }
    }
}
