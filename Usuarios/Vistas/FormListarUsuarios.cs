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
using Usuarios.Modelos;

namespace Usuarios.Vistas
{
    public partial class FormListarUsuarios : Form
    {
        UsuariosControl usuariosControl = new UsuariosControl();
        public FormListarUsuarios()
        {
            InitializeComponent();
            dgv_usuarios.DataSource = usuariosControl.Listar();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            //pasar el id para buscar el usuario
            MessageBox.Show(usuariosControl.ModificarUsuario((int)dgv_usuarios.SelectedRows[0].Cells[0].Value,txt_nombre.Text, txt_contra.Text, txt_respuesta.Text, cb_pregunta.TabIndex, cb_admin.Checked));
            dgv_usuarios.DataSource = null;
            dgv_usuarios.DataSource = usuariosControl.Listar();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            panel_modificar.Visible = true;
            string nom = dgv_usuarios.SelectedRows[0].Cells[1].Value.ToString();
            Usuario user = usuariosControl.BuscarUsuarioPorNombre(nom);
            txt_nombre.Text = user.nombre;
            txt_contra.Text = user.password;
            txt_respuesta.Text = user.respuesta;
            cb_pregunta.TabIndex = user.pregunta;
        }

        private void txt_eliminar_Click(object sender, EventArgs e)
        {
            string nom = dgv_usuarios.SelectedRows[0].Cells[1].Value.ToString();
            usuariosControl.EliminarUsuario(nom);
            Recargardgv();
        }

        private void Recargardgv()
        {
            dgv_usuarios.DataSource = null;
            dgv_usuarios.DataSource = usuariosControl.Listar();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}
