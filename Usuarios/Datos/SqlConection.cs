using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuarios.Datos
{
    internal class SqlConection
    {
        SqlConnection cnn;
        public SqlConection()
        {
            try
            {
                cnn = new SqlConnection("Data Source=192.168.0.29;Initial Catalog=u2;User ID=u2;Password=u2");
                cnn.Open();
                cnn.Close();
            }
            catch (Exception ex)
            {
                cnn = new SqlConnection("");
            }
        }
        internal void Abrir() 
        {
            cnn.Open(); 
        }
        internal void Cerrar() 
                            
        {
            cnn.Close(); 
        }
        internal SqlConnection Conexion() 
        {
            return cnn;
        }
    }
}
