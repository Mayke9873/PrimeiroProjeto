namespace Main_Project
{
    partial class frmProdutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tsProdutos = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiCadProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiAjustestoque = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAtualiza_Prod = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsExit_Estoque = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.dtvEstoque = new System.Windows.Forms.DataGridView();
            this.tsProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // tsProdutos
            // 
            this.tsProdutos.Dock = System.Windows.Forms.DockStyle.Left;
            this.tsProdutos.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsProdutos.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tsProdutos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripDropDownButton1,
            this.tsAtualiza_Prod,
            this.toolStripSeparator2,
            this.tsExit_Estoque,
            this.toolStripSeparator3});
            this.tsProdutos.Location = new System.Drawing.Point(0, 0);
            this.tsProdutos.Name = "tsProdutos";
            this.tsProdutos.Size = new System.Drawing.Size(46, 523);
            this.tsProdutos.TabIndex = 0;
            this.tsProdutos.Text = "Menu de Produtos";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(43, 6);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCadProduto,
            this.tmsiEstoque});
            this.toolStripDropDownButton1.Image = global::Main_Project.Properties.Resources.Add_OS;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(43, 36);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // tsmiCadProduto
            // 
            this.tsmiCadProduto.Name = "tsmiCadProduto";
            this.tsmiCadProduto.Size = new System.Drawing.Size(180, 22);
            this.tsmiCadProduto.Text = "Cadastrar Produto";
            this.tsmiCadProduto.Click += new System.EventHandler(this.tsmiCadProduto_Click);
            // 
            // tmsiEstoque
            // 
            this.tmsiEstoque.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddEstoque,
            this.tmsiAjustestoque});
            this.tmsiEstoque.Name = "tmsiEstoque";
            this.tmsiEstoque.Size = new System.Drawing.Size(180, 22);
            this.tmsiEstoque.Text = "Estoque";
            // 
            // tsmiAddEstoque
            // 
            this.tsmiAddEstoque.Name = "tsmiAddEstoque";
            this.tsmiAddEstoque.Size = new System.Drawing.Size(180, 22);
            this.tsmiAddEstoque.Text = "Adicionar Estoque";
            this.tsmiAddEstoque.Click += new System.EventHandler(this.tsmiAddEstoque_Click);
            // 
            // tmsiAjustestoque
            // 
            this.tmsiAjustestoque.Name = "tmsiAjustestoque";
            this.tmsiAjustestoque.Size = new System.Drawing.Size(180, 22);
            this.tmsiAjustestoque.Text = "Ajuste de Estoque";
            this.tmsiAjustestoque.Click += new System.EventHandler(this.tmsiAjustestoque_Click);
            // 
            // tsAtualiza_Prod
            // 
            this.tsAtualiza_Prod.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsAtualiza_Prod.Image = global::Main_Project.Properties.Resources.atualizar_plus;
            this.tsAtualiza_Prod.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAtualiza_Prod.Name = "tsAtualiza_Prod";
            this.tsAtualiza_Prod.Size = new System.Drawing.Size(43, 36);
            this.tsAtualiza_Prod.Text = "Atualizar";
            this.tsAtualiza_Prod.Click += new System.EventHandler(this.tsAtualiza_Prod_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(43, 6);
            // 
            // tsExit_Estoque
            // 
            this.tsExit_Estoque.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsExit_Estoque.Image = global::Main_Project.Properties.Resources.Exit_icon;
            this.tsExit_Estoque.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsExit_Estoque.Name = "tsExit_Estoque";
            this.tsExit_Estoque.Size = new System.Drawing.Size(43, 36);
            this.tsExit_Estoque.Text = "Sair";
            this.tsExit_Estoque.Click += new System.EventHandler(this.tsExit_Estoque_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(43, 6);
            // 
            // dtvEstoque
            // 
            this.dtvEstoque.AllowUserToAddRows = false;
            this.dtvEstoque.AllowUserToDeleteRows = false;
            this.dtvEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvEstoque.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtvEstoque.Location = new System.Drawing.Point(46, 0);
            this.dtvEstoque.Name = "dtvEstoque";
            this.dtvEstoque.ReadOnly = true;
            this.dtvEstoque.Size = new System.Drawing.Size(814, 523);
            this.dtvEstoque.TabIndex = 1;
            // 
            // frmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 523);
            this.Controls.Add(this.dtvEstoque);
            this.Controls.Add(this.tsProdutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sistema de Controle de O.S.  -  Produtos";
            this.tsProdutos.ResumeLayout(false);
            this.tsProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvEstoque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsProdutos;
        private System.Windows.Forms.ToolStripButton tsAtualiza_Prod;
        private System.Windows.Forms.ToolStripButton tsExit_Estoque;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.DataGridView dtvEstoque;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem tsmiCadProduto;
        private System.Windows.Forms.ToolStripMenuItem tmsiEstoque;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddEstoque;
        private System.Windows.Forms.ToolStripMenuItem tmsiAjustestoque;
    }
}