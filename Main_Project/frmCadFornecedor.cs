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
    public partial class frmCadFornecedor : Form
    {
        public frmCadFornecedor()
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

        private void btnCadastra_Forn_Click(object sender, EventArgs e)
        {
            string strcon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Desenvolvimento\Banco\CalhasDB.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection conexao = new SqlConnection(strcon);

            SqlCommand cmd = new SqlCommand("INSERT INTO Fornecedor (NOME, EMAIL, TELEFONE1, TELEFONE2, CNPJ, ie, fENDERECO)" +
                "VALUES ('" + txtNome_Forn.Text + "',  '" + txtEmail_Forn.Text + "', '" + mtbTelefone_Forn.Text + "', '" +
                mtbCelular_Forn.Text + "', '" + mtbCnpj_Forn.Text + "', '" + mtbIe_Forn.Text + "', '"  + txtEndereco_Forn.Text + "')", conexao); /*cmd possui mais de um parâmetro, neste caso coloquei o comando SQL "SELECT * FROM tabela" que irá selecionar tudo(*) de tabela, o segundo parâmetro indica onde o banco está conectado,ou seja se estamos selecionando informações do banco precisamos dizer onde ele está localizado */


            if (txtNome_Forn.Text == "")
            {
                MessageBox.Show("Preencher Nome", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (mtbTelefone_Forn.Text.Replace("(","").Replace(")","").Replace("-","").Trim().Length == 0)
            {
                MessageBox.Show("Preencher Telefone", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (mtbCnpj_Forn.Text.Replace(".","").Replace("/","").Replace("-","").Trim().Length == 0)
            {
                MessageBox.Show("Preencher CNPJ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try //Tenta executar o que estiver abaixo (Verifica)
                {
                    conexao.Open(); // abre a conexão com o banco   
                    cmd.ExecuteNonQuery(); // executa a Query
                                           /*Pronto após o cmd.ExecuteNonQuery(); selecionamos tudo o que tinha dentro do banco, agora os passos seguintes irão exibir as informações para que o usuário possa vê-las    */
                    SqlDataAdapter da = new SqlDataAdapter(); /* da, adapta o banco de dados ao nosso projeto */
                    DataSet ds = new DataSet();

                    MessageBox.Show("Dados Gravados com Sucesso", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtNome_Forn.Clear();
                    txtEmail_Forn.Clear();
                    mtbTelefone_Forn.Clear();
                    mtbCelular_Forn.Clear();
                    mtbCnpj_Forn.Clear();
                    mtbIe_Forn.Clear();
                    txtEndereco_Forn.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro " + ex.Message); /*Se ocorer algum erro será informado em um msgbox*/
                }

                finally
                {
                    conexao.Close(); /* Se tudo ocorrer bem fecha a conexão com o banco da dados, sempre é bom fechar a conexão após executar até o final o que nos interessa, isso pode evitar problemas futuros */
                }
            }
        }
    }
}
