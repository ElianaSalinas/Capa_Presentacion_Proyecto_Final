using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;


namespace ProyectoLogin.DAL
{
    public class UsuarioDAL
    {
        private string connectionString = "Server=.; Database=BD_Empleados; Integrated Security=true";

        public bool ValidarUsuario(string nombreUsuario, string contraseña)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Usuarios WHERE NombreUsuario = @nombre AND Contraseña = @password";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombreUsuario);
                    cmd.Parameters.AddWithValue("@password", contraseña);

                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }
    }
}
