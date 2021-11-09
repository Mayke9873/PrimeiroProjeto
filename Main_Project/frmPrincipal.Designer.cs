namespace Main_Project
{
    partial class frmPrincipal
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
            this.menuPrincipal = new System.Windows.Forms.ToolStrip();
            this.tsbCliForn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbVenda = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbOs = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbEstoque = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbFecharSist = new System.Windows.Forms.ToolStripButton();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.AutoSize = false;
            this.menuPrincipal.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menuPrincipal.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.menuPrincipal.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCliForn,
            this.toolStripSeparator4,
            this.tsbVenda,
            this.toolStripSeparator1,
            this.tsbOs,
            this.toolStripSeparator2,
            this.tsbEstoque,
            this.toolStripSeparator3,
            this.tsbFecharSist});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(860, 40);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "Menu Principal";
            // 
            // tsbCliForn
            // 
            this.tsbCliForn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCliForn.Image = global::Main_Project.Properties.Resources.List_Cli_Forn;
            this.tsbCliForn.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.tsbCliForn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCliForn.Name = "tsbCliForn";
            this.tsbCliForn.Size = new System.Drawing.Size(36, 37);
            this.tsbCliForn.Text = "Cliente / Fornecedor";
            this.tsbCliForn.Click += new System.EventHandler(this.tsbCliForn_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 40);
            // 
            // tsbVenda
            // 
            this.tsbVenda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbVenda.Image = global::Main_Project.Properties.Resources.moeda_de_dolar;
            this.tsbVenda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbVenda.Name = "tsbVenda";
            this.tsbVenda.Size = new System.Drawing.Size(36, 37);
            this.tsbVenda.Text = "Vendas";
            this.tsbVenda.Click += new System.EventHandler(this.tsbVenda_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 40);
            // 
            // tsbOs
            // 
            this.tsbOs.AutoSize = false;
            this.tsbOs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbOs.Image = global::Main_Project.Properties.Resources.Os_icon;
            this.tsbOs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOs.Name = "tsbOs";
            this.tsbOs.Size = new System.Drawing.Size(35, 35);
            this.tsbOs.Text = "O.S.";
            this.tsbOs.Click += new System.EventHandler(this.tsbOs_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 40);
            // 
            // tsbEstoque
            // 
            this.tsbEstoque.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEstoque.Image = global::Main_Project.Properties.Resources.if_application_form_edit_35650;
            this.tsbEstoque.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEstoque.Name = "tsbEstoque";
            this.tsbEstoque.Size = new System.Drawing.Size(36, 37);
            this.tsbEstoque.Text = "Estoque";
            this.tsbEstoque.Click += new System.EventHandler(this.tsbEstoque_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 40);
            // 
            // tsbFecharSist
            // 
            this.tsbFecharSist.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFecharSist.Image = global::Main_Project.Properties.Resources.if_Shutdown_64_32118;
            this.tsbFecharSist.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFecharSist.Name = "tsbFecharSist";
            this.tsbFecharSist.Size = new System.Drawing.Size(36, 37);
            this.tsbFecharSist.Text = "Fechar Sistema";
            this.tsbFecharSist.Click += new System.EventHandler(this.tsbFecharSist_Click);
            // 
            // grpInfo
            // 
            this.grpInfo.Location = new System.Drawing.Point(0, 43);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(860, 523);
            this.grpInfo.TabIndex = 2;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Info";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 568);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.menuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Controle de O.S. ";
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripButton tsbCliForn;
        private System.Windows.Forms.ToolStripButton tsbOs;
        private System.Windows.Forms.GroupBox grpInfo;
        public System.Windows.Forms.ToolStripButton tsbEstoque;
        public System.Windows.Forms.ToolStrip menuPrincipal;
        private System.Windows.Forms.ToolStripButton tsbFecharSist;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbVenda;
    }
}