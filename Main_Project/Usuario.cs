using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Project
{
    class Usuario
    {
        public string nome_user { get; set; }
        public string senha_user { get; set; }

        public void EfetuarLogin()
        {
            string strconn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Desenvolvimento\Banco\CalhasDB.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection connection = new SqlConnection(strconn);
            connection.Open();

            try
            {
                string query = "SELECT LUSUARIO, LSENHA FROM LOGIN WHERE LUSUARIO=@USUARIO AND LSENHA=@SENHA";

                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@USUARIO", nome_user);
                cmd.Parameters.AddWithValue("@SENHA", senha_user);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    frmPrincipal principal = new frmPrincipal(nome_user);
                    principal.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválido!");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //connection.Close(); /* Se tudo ocorrer bem fecha a conexão com o banco da dados, sempre é bom fechar a conexão após executar até o final o que nos interessa, isso pode evitar problemas futuros */
            }
        }
    }
}
