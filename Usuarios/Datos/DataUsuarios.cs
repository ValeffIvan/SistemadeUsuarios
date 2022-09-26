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
        SqlConection cnn = new SqlConection();


        internal string Agregar(Usuario usuario)
        {
            try
            {
                cnn.Abrir(); 
                const string query = @"INSERT INTO  usuarios 
                                       (nombre, contrasenia,pregunta,respuesta,administrador)
                                       VALUES 
                                       (@nombre,@contrasenia,@pregunta,@respuesta,@administrador)";
                SqlCommand cmd = new SqlCommand(query, cnn.Conexion()); 
                cmd.Parameters.AddWithValue("@nombre", usuario.nombre);
                cmd.Parameters.AddWithValue("@contrasenia", usuario.password);
                cmd.Parameters.AddWithValue("@pregunta", usuario.pregunta);
                cmd.Parameters.AddWithValue("@respuesta", usuario.respuesta);
                cmd.Parameters.AddWithValue("@administrador", usuario.administrador);
                cmd.ExecuteNonQuery();
                cnn.Cerrar(); 
                return "Usuario Cargado con Exito"; 
            }
            catch (Exception e)
            {
                cnn.Cerrar(); 
                return e.Message; 
            }
        }

        internal string modificar(Usuario usuario)
        {
            try 
            {
                cnn.Abrir(); 
                const string query = @"UPDATE usuarios SET 
                                        nombre=@nombre, contrasenia=@contrasenia, 
                                        pregunta=@pregunta, respuesta=@respuesta,
                                        administrador=@administrador
                                      WHERE id_usuario=@id"; 
                SqlCommand cmd = new SqlCommand(query, cnn.Conexion()); 
                cmd.Parameters.AddWithValue("@id", usuario.id_usuario); 
                cmd.Parameters.AddWithValue("@nombre", usuario.nombre);
                cmd.Parameters.AddWithValue("@contrasenia", usuario.password);
                cmd.Parameters.AddWithValue("@pregunta", usuario.pregunta);
                cmd.Parameters.AddWithValue("@respuesta", usuario.respuesta);
                cmd.Parameters.AddWithValue("@administrador", usuario.administrador);
                cmd.ExecuteNonQuery(); 
                cnn.Cerrar(); 
                return "Usuario modificado con exito"; 
            }
            catch (Exception ex)
            {
                cnn.Cerrar(); 
                return ex.Message; 
            }
        }

        internal string Eliminar(Usuario usuario)
        {
            try
            {
                cnn.Abrir();
                const string query = "DELETE FROM usuarios WHERE nombre=@nombre";
                SqlCommand cmd = new SqlCommand(query,cnn.Conexion());
                cmd.Parameters.AddWithValue("@nombre", usuario.nombre);
                cmd.ExecuteNonQuery();
                cnn.Cerrar();
                return "Usuario eliminado con exito";
            }
            catch (Exception e)
            {
                return e.Message;
            }
            finally
            {
                cnn.Cerrar();
            }
        }

        internal bool Existe(string nom)
        {
            int id = 0;            
            cnn.Abrir();
            const string query = "SELECT * FROM usuarios where nombre=@nombre";                                                                  
            SqlCommand cmd = new SqlCommand(query, cnn.Conexion()); 
            cmd.Parameters.AddWithValue("@nombre", nom); 
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) 
            {
                id = Convert.ToInt32(reader["id_usuario"]); 
            }
            cnn.Cerrar(); 
            if (id == 0) 
            {
                return false; 
            }
            else
            {
                return true; 
            }
            
        }

        internal List<Usuario> Listar()
        {
            List<Usuario> usuarios = new List<Usuario>(); 
            cnn.Abrir(); 
            const string query = "SELECT * FROM usuarios ORDER BY id_usuario ASC"; 
            SqlCommand cmd = new SqlCommand(query, cnn.Conexion());
            SqlDataReader reader = cmd.ExecuteReader(); 

            while (reader.Read()) 
            {                
                Usuario usuario = new Usuario
                {
                    id_usuario = Convert.ToInt32(reader["id_usuario"]),
                    nombre = Convert.ToString(reader["nombre"]),
                    password = Convert.ToString(reader["contrasenia"]),
                    pregunta = Convert.ToInt32(reader["pregunta"]),
                    respuesta = Convert.ToString(reader["respuesta"]),
                    administrador = Convert.ToBoolean(reader["administrador"])
                };
                usuarios.Add(usuario); 
            }
            cnn.Cerrar(); 
            return usuarios;
        }
    }
}
