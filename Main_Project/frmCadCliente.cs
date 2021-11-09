using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Main_Project
{
    public partial class frmCadCliente : Form
    {
        public frmCadCliente()
        {
              InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnCadastra_Cli_Click_1(object sender, EventArgs e)
        {
            string strcon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Desenvolvimento\Banco\CalhasDB.mdf;Integrated Security=True;Connect Timeout=30";

            SqlConnection conexao = new SqlConnection(strcon); /* conexao irá conectar o C# ao banco de dados */
            SqlCommand cmd = new SqlCommand("INSERT INTO Cliente (CNOME, CEMAIL, CTELEFONE, CCELULAR, CRG, CCPF, CENDERECO)" +
                "VALUES ('" + txtNome_Cli.Text + "',  '" + txtEmail_Cli.Text + "', '" + mtbTelefone_Cli.Text + "', '" +
                mtbCelular_Cli.Text + "', '" + mtbRg_Cli.Text + "', '" + mtbCpf_Cli.Text + "', '" + txtEndereco_Cli.Text + "')", conexao); /*cmd possui mais de um parâmetro, neste caso coloquei o comando SQL "SELECT * FROM tabela" que irá selecionar tudo(*) de tabela, o segundo parâmetro indica onde o banco está conectado,ou seja se estamos selecionando informações do banco precisamos dizer onde ele está localizado */


            if (txtNome_Cli.Text != "" && txtEmail_Cli.Text != "" && mtbCelular_Cli.Text != "" && mtbRg_Cli.Text != "" && mtbCpf_Cli.Text != "" && txtEndereco_Cli.Text != "")
            {
                try //Tenta executar o que estiver abaixo
                {
                    conexao.Open(); // abre a conexão com o banco   
                    cmd.ExecuteNonQuery(); // executa cmd
                                           /*Pronto após o cmd.ExecuteNonQuery(); selecionamos tudo o que tinha dentro do banco, agora os passos seguintes irão exibir as informações para que o usuário possa vê-las    */
                    SqlDataAdapter da = new SqlDataAdapter(); /* da, adapta o banco de dados ao nosso projeto */
                    DataSet ds = new DataSet();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro " + ex.Message); /*Se ocorer algum erro será informado em um msgbox*/
                }

                finally
                {
                    conexao.Close(); /* Se tudo ocorrer bem fecha a conexão com o banco da dados, sempre é bom fechar a conexão após executar até o final o que nos interessa, isso pode evitar problemas futuros */

                    MessageBox.Show("Dados Gravados com Sucesso", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtNome_Cli.Clear();
                    txtEmail_Cli.Clear();
                    mtbTelefone_Cli.Clear();
                    mtbCelular_Cli.Clear();
                    mtbRg_Cli.Clear();
                    mtbCpf_Cli.Clear();
                    txtEndereco_Cli.Clear();
                }
            }
        }
    }
}
