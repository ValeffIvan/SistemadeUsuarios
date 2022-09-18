using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Usuarios.Modelos;

namespace Usuarios.Datos
{
    internal class DataUsuarios
    {
        DataConectar cnn = new DataConectar();
        internal void agregar()
        {
            throw new NotImplementedException();
        }

        internal void Agregar(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        internal void Eliminar(Usuario usuario)
        {

        }

        internal bool Existe(string nom)
        {

        }

        internal List<Usuario> Listar()
        {
            List<Usuario> usuarios = new List<Usuario>(); 
            cnn.Abrir(); 
            const string query = "SELECT * FROM usuarios ORDER BY Id_usuario ASC"; 
            SqlCommand cmd = new SqlCommand(query, cnn.Conexion());
            SqlDataReader reader = cmd.ExecuteReader(); 

            while (reader.Read()) 
            {
                Usuario usuario = new Usuario
                {
                    nombre = Convert.ToString(reader["Nombre"]),
                    password = Convert.ToString(reader["password"]),
                    pregunta = Convert.ToInt32(reader["pregunta"]),
                    respuesta = Convert.ToString(reader["respuesta"]),
                    administrador = Convert.ToBoolean(reader["administrador"]),
                };
                usuarios.Add(usuario); 
            }
            cnn.Cerrar(); 
            return usuarios;
        }
    }
}
