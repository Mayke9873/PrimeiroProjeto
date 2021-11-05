namespace Main_Project
{
    partial class frmListCliForn
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
            this.tsCliForn = new System.Windows.Forms.ToolStrip();
            this.tsbAddCliForn = new System.Windows.Forms.ToolStripDropDownButton();
            this.cadastrarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarFornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbAtualiza = new System.Windows.Forms.ToolStripButton();
            this.tsbExit_CliForn = new System.Windows.Forms.ToolStripButton();
            this.tbcListCliForn = new System.Windows.Forms.TabControl();
            this.tbpCliente = new System.Windows.Forms.TabPage();
            this.dtvClientes = new System.Windows.Forms.DataGridView();
            this.tbpForn = new System.Windows.Forms.TabPage();
            this.dtvForn = new System.Windows.Forms.DataGridView();
            this.tsCliForn.SuspendLayout();
            this.tbcListCliForn.SuspendLayout();
            this.tbpCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvClientes)).BeginInit();
            this.tbpForn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvForn)).BeginInit();
            this.SuspendLayout();
            // 
            // tsCliForn
            // 
            this.tsCliForn.Dock = System.Windows.Forms.DockStyle.Left;
            this.tsCliForn.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsCliForn.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tsCliForn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddCliForn,
            this.tsbAtualiza,
            this.tsbExit_CliForn});
            this.tsCliForn.Location = new System.Drawing.Point(0, 0);
            this.tsCliForn.Name = "tsCliForn";
            this.tsCliForn.Size = new System.Drawing.Size(46, 523);
            this.tsCliForn.TabIndex = 0;
            this.tsCliForn.Text = "tsCliForn";
            // 
            // tsbAddCliForn
            // 
            this.tsbAddCliForn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddCliForn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarClienteToolStripMenuItem,
            this.cadastrarFornecedorToolStripMenuItem});
            this.tsbAddCliForn.Image = global::Main_Project.Properties.Resources.cli_forn_add;
            this.tsbAddCliForn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddCliForn.Name = "tsbAddCliForn";
            this.tsbAddCliForn.Size = new System.Drawing.Size(43, 36);
            this.tsbAddCliForn.Text = "Cadastro de Cliente / Fornecedor";
            // 
            // cadastrarClienteToolStripMenuItem
            // 
            this.cadastrarClienteToolStripMenuItem.Name = "cadastrarClienteToolStripMenuItem";
            this.cadastrarClienteToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.cadastrarClienteToolStripMenuItem.Text = "Cadastrar Cliente";
            this.cadastrarClienteToolStripMenuItem.Click += new System.EventHandler(this.cadastrarClienteToolStripMenuItem_Click);
            // 
            // cadastrarFornecedorToolStripMenuItem
            // 
            this.cadastrarFornecedorToolStripMenuItem.Name = "cadastrarFornecedorToolStripMenuItem";
            this.cadastrarFornecedorToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.cadastrarFornecedorToolStripMenuItem.Text = "Cadastrar Fornecedor";
            this.cadastrarFornecedorToolStripMenuItem.Click += new System.EventHandler(this.cadastrarFornecedorToolStripMenuItem_Click);
            // 
            // tsbAtualiza
            // 
            this.tsbAtualiza.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAtualiza.Image = global::Main_Project.Properties.Resources.atualizar_plus;
            this.tsbAtualiza.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAtualiza.Name = "tsbAtualiza";
            this.tsbAtualiza.Size = new System.Drawing.Size(43, 36);
            this.tsbAtualiza.Text = "Atualizar";
            this.tsbAtualiza.Click += new System.EventHandler(this.tsbAtualiza_Click);
            // 
            // tsbExit_CliForn
            // 
            this.tsbExit_CliForn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExit_CliForn.Image = global::Main_Project.Properties.Resources.Exit_icon;
            this.tsbExit_CliForn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExit_CliForn.Name = "tsbExit_CliForn";
            this.tsbExit_CliForn.Size = new System.Drawing.Size(43, 36);
            this.tsbExit_CliForn.Text = "toolStripButton3";
            this.tsbExit_CliForn.Click += new System.EventHandler(this.tsbExit_CliForn_Click);
            // 
            // tbcListCliForn
            // 
            this.tbcListCliForn.Controls.Add(this.tbpCliente);
            this.tbcListCliForn.Controls.Add(this.tbpForn);
            this.tbcListCliForn.Location = new System.Drawing.Point(40, 4);
            this.tbcListCliForn.Name = "tbcListCliForn";
            this.tbcListCliForn.SelectedIndex = 0;
            this.tbcListCliForn.Size = new System.Drawing.Size(818, 519);
            this.tbcListCliForn.TabIndex = 1;
            // 
            // tbpCliente
            // 
            this.tbpCliente.Controls.Add(this.dtvClientes);
            this.tbpCliente.Location = new System.Drawing.Point(4, 22);
            this.tbpCliente.Name = "tbpCliente";
            this.tbpCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCliente.Size = new System.Drawing.Size(810, 493);
            this.tbpCliente.TabIndex = 0;
            this.tbpCliente.Text = "Clientes";
            this.tbpCliente.UseVisualStyleBackColor = true;
            // 
            // dtvClientes
            // 
            this.dtvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtvClientes.Location = new System.Drawing.Point(3, 3);
            this.dtvClientes.Name = "dtvClientes";
            this.dtvClientes.Size = new System.Drawing.Size(804, 487);
            this.dtvClientes.TabIndex = 0;
            // 
            // tbpForn
            // 
            this.tbpForn.Controls.Add(this.dtvForn);
            this.tbpForn.Location = new System.Drawing.Point(4, 22);
            this.tbpForn.Name = "tbpForn";
            this.tbpForn.Padding = new System.Windows.Forms.Padding(3);
            this.tbpForn.Size = new System.Drawing.Size(810, 493);
            this.tbpForn.TabIndex = 1;
            this.tbpForn.Text = "Fornecedores";
            this.tbpForn.UseVisualStyleBackColor = true;
            // 
            // dtvForn
            // 
            this.dtvForn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvForn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtvForn.Location = new System.Drawing.Point(3, 3);
            this.dtvForn.Name = "dtvForn";
            this.dtvForn.Size = new System.Drawing.Size(804, 487);
            this.dtvForn.TabIndex = 0;
            // 
            // frmListCliForn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(860, 523);
            this.Controls.Add(this.tbcListCliForn);
            this.Controls.Add(this.tsCliForn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListCliForn";
            this.Text = "Sistema de Controle de O.S.  - Cliente / Fornecedor";
            this.tsCliForn.ResumeLayout(false);
            this.tsCliForn.PerformLayout();
            this.tbcListCliForn.ResumeLayout(false);
            this.tbpCliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtvClientes)).EndInit();
            this.tbpForn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtvForn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsCliForn;
        private System.Windows.Forms.ToolStripButton tsbExit_CliForn;
        private System.Windows.Forms.TabControl tbcListCliForn;
        private System.Windows.Forms.TabPage tbpCliente;
        private System.Windows.Forms.TabPage tbpForn;
        private System.Windows.Forms.DataGridView dtvClientes;
        private System.Windows.Forms.DataGridView dtvForn;
        private System.Windows.Forms.ToolStripDropDownButton tsbAddCliForn;
        private System.Windows.Forms.ToolStripMenuItem cadastrarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarFornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsbAtualiza;
    }
}