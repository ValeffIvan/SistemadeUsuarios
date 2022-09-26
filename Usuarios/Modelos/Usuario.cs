using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuarios.Modelos
{
    public class Usuario
    {
        public int id_usuario { get; set; }
        public string nombre { get; set; }
        public string password { get; set; }
        //la pregunta guarda el numero de pregunta, del 1 al 5
        public int pregunta { get; set; }
        public string respuesta { get; set; }
        public bool administrador { get; set; }

        public Usuario (string nombre, string password, int pregunta, string respuesta, bool administrador)
        {
            this.nombre = nombre;
            this.password = password;
            this.pregunta = pregunta;
            this.respuesta = respuesta;
            this.administrador = administrador;
        }
        public Usuario(int id_usuario,string nombre, string password, int pregunta, string respuesta, bool administrador)
        {
            this.id_usuario = id_usuario;
            this.nombre = nombre;
            this.password = password;
            this.pregunta = pregunta;
            this.respuesta = respuesta;
            this.administrador = administrador;
        }
        public Usuario()
        { }
    }
}
