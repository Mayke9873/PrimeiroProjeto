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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        Usuario login = new Usuario();

        //Código para tecla de atalho.
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                this.Close();
                break;

                case Keys.Enter:
                    if (txtUsuario.Text == "")
                    {
                        MessageBox.Show("Preencher Usuario");
                    }
                    else if (txtSenha.Text == "")
                    {
                        MessageBox.Show("Preencher Senha");
                    }
                    else
                    {
                        login.nome_user = txtUsuario.Text;
                        login.senha_user = txtSenha.Text;

                        login.EfetuarLogin();
                    }
                    break;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            login.nome_user = txtUsuario.Text;
            login.senha_user = txtSenha.Text;

            login.EfetuarLogin();
        }
        
        private void BtnCancela_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
