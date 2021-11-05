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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Usuario login = new Usuario();
            login.nome_user = txtUsuario.Text;
            login.senha_user = txtSenha.Text;

            login.EfetuarLogin();
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
