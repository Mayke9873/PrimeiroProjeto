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
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

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
                connection.Open();
                cmd2.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd2;
                da.Fill(ds);
                dtvForn.DataSource = ds;
                dtvForn.DataMember = ds.Tables[0].TableName;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);
                throw;
            }

            finally
            {
                connection.Close();
            }
        }

        private void cadastrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadCliente frmCadCliente = new frmCadCliente();
            frmCadCliente.ShowDialog();
        }

        private void cadastrarFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadFornecedor cadFornecedor = new frmCadFornecedor();
            cadFornecedor.ShowDialog();
        }

        private void tsbAtualiza_Click(object sender, EventArgs e)
        {
            string strconn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Desenvolvimento\Banco\CalhasDB.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection connection = new SqlConnection(strconn);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Cliente", connection); /*cmd possui mais de um parâmetro, neste caso coloquei o comando SQL "SELECT * FROM tabela" que irá selecionar tudo(*) de tabela, o segundo parâmetro indica onde o banco está conectado,ou seja se estamos selecionando informações do banco precisamos dizer onde ele está localizado */

            //Atualiza a pag Cliente
            try
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
                connection.Close();
            }

            //Atualiza a pag Fornecedor.
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM FORNECEDOR", connection); /*cmd possui mais de um parâmetro, neste caso coloquei o comando SQL "SELECT * FROM tabela" que irá selecionar tudo(*) de tabela, o segundo parâmetro indica onde o banco está conectado,ou seja se estamos selecionando informações do banco precisamos dizer onde ele está localizado */
            try //Tenta executar o que estiver abaixo
            {
                connection.Open(); 
                cmd2.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd2;
                da.Fill(ds);                                        
                dtvForn.DataSource = ds;
                dtvForn.DataMember = ds.Tables[0].TableName;
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
        }

        private void tsbExit_CliForn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
