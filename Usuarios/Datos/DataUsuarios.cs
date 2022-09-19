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


        internal void Agregar(Usuario usuario)
        {
            try
            {
                cnn.Abrir();
            }
            catch
            {

            }
            finally
            {
                cnn.Cerrar();
            }
        }

        internal void modificar(Usuario usuario)
        {
            try
            {
                cnn.Abrir();
            }
            catch
            {

            }
            finally
            {
                cnn.Cerrar();
            }
        }

        internal string Eliminar(int id)
        {
            try
            {
                cnn.Abrir();
                const string query = "DELETE FROM alumnos WHERE id_usuario=@id";
                SqlCommand cmd = new SqlCommand(query,cnn.Conexion());
                cmd.Parameters.AddWithValue("@id", id);
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
            try
            {
                cnn.Abrir();
            }
            catch
            {

            }
            finally
            {
                cnn.Cerrar();
            }
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
                    nombre = Convert.ToString(reader["nombre"]),
                    password = Convert.ToString(reader["password"]),
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
