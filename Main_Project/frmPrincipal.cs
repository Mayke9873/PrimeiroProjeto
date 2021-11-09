using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Project
{
    public partial class frmPrincipal : Form
    {
        private string v;

        public frmPrincipal(string v)
        {
            this.v = v;
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys key)
        {
            if (key == (Keys.Alt | Keys.F4))
            {
                if (MessageBox.Show("Deseja sair do sistema?","SAIR", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            return base.ProcessCmdKey(ref msg, key);
        }

        private void tsbCliForn_Click(object sender, EventArgs e)
        {
            frmListCliForn frmCliForn = new frmListCliForn ();
            frmCliForn.TopLevel = false;
            grpInfo.Controls.Add(frmCliForn);

           // frmCliForn.FormBorderStyle = FormBorderStyle.None;     ****Tira as bordas do formulário****
            frmCliForn.Show();
        }
   
        private void tsbOs_Click(object sender, EventArgs e)
        {
            frmOs frmOs = new frmOs();
            frmOs.TopLevel = false;

            grpInfo.Controls.Add(frmOs);

            frmOs.Show();
        }

        private void tsbVenda_Click(object sender, EventArgs e)
        {
            frmVenda venda = new frmVenda();
            venda.TopLevel = false;

            grpInfo.Controls.Add(venda);
            venda.Show();
        }

        private void tsbEstoque_Click(object sender, EventArgs e)
        {
            frmProdutos frmEstoque = new frmProdutos();
            frmEstoque.TopLevel = false;

            grpInfo.Controls.Add(frmEstoque);

            // frmCliForn.FormBorderStyle = FormBorderStyle.None;     ****Tira as bordas do formulário****
            frmEstoque.Show();
        }

        private void tsbFecharSist_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
