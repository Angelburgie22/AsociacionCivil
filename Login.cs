using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BCrypt.Net;

namespace AsociacionCivil
{
    class Login
    {
        public static string TryLogin(string username, string password)
        {
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionString);

            connection.Open();

            string query = "SELECT hash_passwd, adm_id, nivel_usuario FROM usuario WHERE nombre_usuario = @nombre_usuario";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("nombre_usuario", username);

            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();

                string hash = reader["hash_passwd"].ToString();

                if(BCrypt.Net.BCrypt.Verify(password, hash))
                {
                    Properties.Settings.Default.AdminIndex = int.Parse(reader["adm_id"].ToString());
                    Properties.Settings.Default.TypeUser = reader["nivel_usuario"].ToString();
                    Properties.Settings.Default.UserName = username;

                    reader.Close();

                    string query2 = "SELECT email FROM administrador WHERE adm_id = @adm_id";
                    SqlCommand command2 = new SqlCommand(query2, connection);
                    command2.Parameters.AddWithValue("adm_id", Properties.Settings.Default.AdminIndex);

                    using(SqlDataReader reader2 = command2.ExecuteReader())
                    {
                        while (reader2.Read())
                        {
                            Properties.Settings.Default.AdminEmail = reader2["email"].ToString();
                        }
                    }

                    return "success";
                }
            }

            return "failure";
        }
    }
}
