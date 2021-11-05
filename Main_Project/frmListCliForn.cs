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

    public partial class frmListCliForn : Form
    {
        public frmListCliForn()
        {
            InitializeComponent();

            string strconn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Desenvolvimento\Banco\CalhasDB.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection connection = new SqlConnection(strconn);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Cliente", connection); 
            try 
            {
                connection.Open(); 
                cmd.ExecuteNonQuery();
                                       
                SqlDataAdapter da = new SqlDataAdapter(); /* da, adapta o banco de dados ao nosso projeto */
                DataSet ds = new DataSet();
                da.SelectCommand = cmd; // adapta cmd ao projeto
                da.Fill(ds); // preenche todas as informações dentro do DataSet                                          
                dtvClientes.DataSource = ds; //Datagridview recebe ds já preenchido
                dtvClientes.DataMember = ds.Tables[0].TableName;  /*Agora Datagridview exibe o banco de dados*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message); /*Se ocorer algum erro será informado em um msgbox*/
                throw;
            }

            finally
            {
                connection.Close();
            }

            SqlCommand cmd2 = new SqlCommand("SELECT * FROM FORNECEDOR", connection);
            try
            {
                connection.Open(); // abre a conexão com o banco   
                cmd2.ExecuteNonQuery(); // executa cmd
                                        /*Pronto após o cmd.ExecuteNonQuery(); selecionamos tudo o que tinha dentro do banco, agora os passos seguintes irão exibir as informações para que o usuário possa vê-las    */
                SqlDataAdapter da = new SqlDataAdapter(); /* da, adapta o banco de dados ao nosso projeto */
                DataSet ds = new DataSet();
                da.SelectCommand = cmd2; // adapta cmd ao projeto
                da.Fill(ds); // preenche todas as informações dentro do DataSet                                          
                dtvForn.DataSource = ds; //Datagridview recebe ds já preenchido
                dtvForn.DataMember = ds.Tables[0].TableName;  /*Agora Datagridview exibe o banco de dados*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message); /*Se ocorer algum erro será informado em um msgbox*/
                throw;
            }

            finally
            {
                connection.Close(); /* Se tudo ocorrer bem fecha a conexão com o banco da dados, sempre é bom fechar a conexão após executar até o final o que nos interessa, isso pode evitar problemas futuros */
            }
        }
        
        private void cadastrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadCliente frmCadCliente = new frmCadCliente();
            frmCadCliente.Show();
        }

        private void cadastrarFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadFornecedor cadFornecedor = new frmCadFornecedor();
            cadFornecedor.Show();
        }

        private void tsbAtualiza_Click(object sender, EventArgs e)
        {

            string strconn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Desenvolvimento\Banco\CalhasDB.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection connection = new SqlConnection(strconn);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Cliente", connection); /*cmd possui mais de um parâmetro, neste caso coloquei o comando SQL "SELECT * FROM tabela" que irá selecionar tudo(*) de tabela, o segundo parâmetro indica onde o banco está conectado,ou seja se estamos selecionando informações do banco precisamos dizer onde ele está localizado */
            try //Tenta executar o que estiver abaixo
            {
                connection.Open(); // abre a conexão com o banco   
                cmd.ExecuteNonQuery(); // executa cmd
                                       /*Pronto após o cmd.ExecuteNonQuery(); selecionamos tudo o que tinha dentro do banco, agora os passos seguintes irão exibir as informações para que o usuário possa vê-las    */
                SqlDataAdapter da = new SqlDataAdapter(); /* da, adapta o banco de dados ao nosso projeto */
                DataSet ds = new DataSet();
                da.SelectCommand = cmd; // adapta cmd ao projeto
                da.Fill(ds); // preenche todas as informações dentro do DataSet                                          
                dtvClientes.DataSource = ds; //Datagridview recebe ds já preenchido
                dtvClientes.DataMember = ds.Tables[0].TableName;  /*Agora Datagridview exibe o banco de dados*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message); /*Se ocorer algum erro será informado em um msgbox*/
                throw;
            }

            finally
            {
                connection.Close(); /* Se tudo ocorrer bem fecha a conexão com o banco da dados, sempre é bom fechar a conexão após executar até o final o que nos interessa, isso pode evitar problemas futuros */
            }

            SqlCommand cmd2 = new SqlCommand("SELECT * FROM FORNECEDOR", connection); /*cmd possui mais de um parâmetro, neste caso coloquei o comando SQL "SELECT * FROM tabela" que irá selecionar tudo(*) de tabela, o segundo parâmetro indica onde o banco está conectado,ou seja se estamos selecionando informações do banco precisamos dizer onde ele está localizado */
            try //Tenta executar o que estiver abaixo
            {
                connection.Open(); // abre a conexão com o banco   
                cmd2.ExecuteNonQuery(); // executa cmd
                                        /*Pronto após o cmd.ExecuteNonQuery(); selecionamos tudo o que tinha dentro do banco, agora os passos seguintes irão exibir as informações para que o usuário possa vê-las    */
                SqlDataAdapter da = new SqlDataAdapter(); /* da, adapta o banco de dados ao nosso projeto */
                DataSet ds = new DataSet();
                da.SelectCommand = cmd2; // adapta cmd ao projeto
                da.Fill(ds); // preenche todas as informações dentro do DataSet                                          
                dtvForn.DataSource = ds; //Datagridview recebe ds já preenchido
                dtvForn.DataMember = ds.Tables[0].TableName;  /*Agora Datagridview exibe o banco de dados*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message); /*Se ocorer algum erro será informado em um msgbox*/
                throw;
            }

            finally
            {
                connection.Close(); /* Se tudo ocorrer bem fecha a conexão com o banco da dados, sempre é bom fechar a conexão após executar até o final o que nos interessa, isso pode evitar problemas futuros */
            }
        }

        private void tsbExit_CliForn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
