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
    public partial class frmCadProduto : Form
    {
        private string strConn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Desenvolvimento\Banco\CalhasDB.mdf;Integrated Security=True;Connect Timeout=30";
        SqlCommand command = null;
        SqlConnection conexao = null;

        public frmCadProduto()
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

        private void btnCadastra_Prod_Click(object sender, EventArgs e)
        {
            conexao = new SqlConnection(strConn);
            command = new SqlCommand("INSERT INTO PRODUTO (DESCRICAO, TIPO, GRUPO, BARRAS) VALUES" +
                "('" + txtDesc_prod.Text + "', '" + txtTipo.Text + "', '" + txtGrupo.Text + "', '" + txtBarras.Text + "')", conexao) ;

            try
            {
                if (txtDesc_prod.Text == "")
                {
                    MessageBox.Show("Preencher Descrição", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    conexao.Open();
                    command.ExecuteNonQuery();
                    
                    MessageBox.Show("Dados Gravados com Sucesso", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);
            }
            finally
            {
                txtBarras.Clear();
                txtDesc_prod.Clear();
                txtTipo.Clear();
                txtGrupo.Clear();
                mtbDtUltCompra.Clear();
                conexao.Close();
            }
        }
    }
}
