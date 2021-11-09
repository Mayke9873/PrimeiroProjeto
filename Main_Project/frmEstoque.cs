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
    public partial class frmProdutos : Form
    {
        private string strConn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Desenvolvimento\Banco\CalhasDB.mdf;Integrated Security=True;Connect Timeout=30";
        SqlCommand command = null;
        SqlConnection conexao = null;


        public frmProdutos()
        {
            InitializeComponent();

            string strSQL = "SELECT * FROM PRODUTO";

            conexao = new SqlConnection(strConn);
            command = new SqlCommand(strSQL, conexao);

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable LisTable = new DataTable();

                adapter.Fill(LisTable);
                dtvEstoque.DataSource = LisTable;
                conexao.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void tsmiCadProduto_Click(object sender, EventArgs e)
        {
            frmCadProduto cadProduto = new frmCadProduto();

            cadProduto.Show();
        }

        private void tsmiAddEstoque_Click(object sender, EventArgs e)
        {
            frmAddEstoque addEstoque = new frmAddEstoque();

            addEstoque.Show();
        }

        private void tmsiAjustestoque_Click(object sender, EventArgs e)
        {

        }

        private void tsAtualiza_Prod_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable LisTable = new DataTable();

                adapter.Fill(LisTable);
                dtvEstoque.DataSource = LisTable;
                conexao.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void tsExit_Estoque_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
