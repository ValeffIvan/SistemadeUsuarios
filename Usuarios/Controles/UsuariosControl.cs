using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Usuarios.Datos;
using Usuarios.Modelos;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Usuarios.Controles
{
    internal class UsuariosControl
    {

        DataUsuarios dataUsuarios = new DataUsuarios();

        internal bool CorroborarAdministrador(string nom)
        {
            foreach (Usuario usuario in dataUsuarios.Listar())
            {
                if (usuario.nombre == nom && usuario.administrador == true)
                {
                    return true;
                }
            }
            return false;
        }

        internal List<Usuario> Listar()
        {
            return dataUsuarios.Listar();
        }

        internal string Agregar(string nom, string cont, string preg, string resp, bool adm)
        {
            if (nom == "" || cont == "" || preg == "" || resp == "")
            {
                return "Campo incompleto";
            }
            else
            {
                if (dataUsuarios.Existe(nom))
                {
                    return "El usuario ya existe";
                }
                else
                {
                    Usuario usuario;
                    usuario = new Usuario(nom, cont, Pregunta(preg), resp, adm);
                    return dataUsuarios.Agregar(usuario);
                }
            }
        }

        internal int Pregunta (string preg)
        {
            int i;
            if (preg == "Nombre de su primera mascota")
            {
                return i = 1;

            }
            else if (preg == "Cual fue tu primer auto")
            {
                return i = 2;

            }
            else if (preg == "Cual es tu pelicula favorita")
            {
                return i = 3;

            }
            else if (preg == "Nombre de tu hermano/a")
            {
                return i = 4;

            }
            else if (preg == "Banda favorita")
            {
                return i = 5;
            }
            else
                return i = 0;

        }

        internal bool Ingresar(string nom, string contra)
        {
            if (dataUsuarios.Existe(nom))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal string CambiarPregunta (string nom, string preg, string respuesta)
        {
            foreach (Usuario usuario in dataUsuarios.Listar())
            {
                if (usuario.nombre == nom)
                {
                    dataUsuarios.Eliminar(usuario);
                    int i = Pregunta(preg);
                    usuario.pregunta = i;
                    usuario.respuesta = respuesta;
                    dataUsuarios.Agregar(usuario);
                    break;
                }    
            }
            return $"Pregunta de {nom} cambiada con exito";
        }

        internal bool CorroborarPregunta(string nom, string respuesta)
        {
            foreach (Usuario usuario in dataUsuarios.Listar())
            {
                if (usuario.nombre == nom && usuario.respuesta==respuesta)
                {
                    return true;
                }
            }
            return false;
        }

        internal void CambiarContra(string nom, string con)
        {
            foreach (Usuario usuario in dataUsuarios.Listar())
            {
                if (usuario.nombre==nom)
                {
                    usuario.password = con;
                    break;
                }
            }
        }

        internal Usuario BuscarUsuarioPorNombre(string nom)
        {
            foreach (Usuario usuario in dataUsuarios.Listar())
            {
                if (usuario.nombre==nom)
                {
                    return usuario;
                }
            }
            return null;
        }

        internal string ModificarUsuario(string nom, string con, string res, int preg,bool admin)
        {

            if (dataUsuarios.Existe(nom))
            {
                Usuario usuario = new Usuario(nom,con,preg,res,admin);
                return dataUsuarios.modificar(usuario);
            }
            else
            {
                return "El usuario no existe";
            }


    
        }

        internal void EliminarUsuario(string nom)
        {
            foreach (Usuario user in dataUsuarios.Listar())
            {
                if (user.nombre == nom)
                {
                    dataUsuarios.Eliminar(user);
                }
            }
        }
    }
}
