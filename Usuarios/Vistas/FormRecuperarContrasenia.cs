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
    public partial class FormRecuperarContrasenia : Form
    {
        UsuariosControl usuariosControl = new UsuariosControl();
        public FormRecuperarContrasenia()
        {
            InitializeComponent();
            cb_nombre.DataSource = usuariosControl.NombresDB();
            panel_contra.Visible = false;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Owner.Visible= true;
            this.Close();
        }

        private void btn_corroborar_Click(object sender, EventArgs e)
        {
            if (usuariosControl.CorroborarPregunta(cb_nombre.Text,txt_respuesta.Text))
            {
                panel_contra.Visible = true;
            }
            else
            {
                MessageBox.Show("Respuesta incorrecta");
            }

        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (panel_contra.Visible==true)
            {
                usuariosControl.CambiarContra(cb_nombre.Text, txt_contra.Text);
                MessageBox.Show("Contraseña cambiada con exito");
                this.Owner.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Corrobore la respuesta");
            }
        }

        private void cb_nombre_TextChanged(object sender, EventArgs e)
        {
            txt_pregunta.Text = usuariosControl.BuscarPregunta(cb_nombre.Text);
        }
    }
}
