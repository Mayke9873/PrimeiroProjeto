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
    public partial class frmAjusteEstoque : Form
    {
        private string strConn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Desenvolvimento\Banco\CalhasDB.mdf;Integrated Security=True;Connect Timeout=30";
        SqlCommand command = null;
        SqlConnection conexao = null;

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        public frmAjusteEstoque()
        {
            InitializeComponent();
        }

        private void btnAjusteProd_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelarAjuste_Click(object sender, EventArgs e)
        {

        }
    }
}