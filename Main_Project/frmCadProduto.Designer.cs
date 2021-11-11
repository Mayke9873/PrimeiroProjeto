namespace Main_Project
{
    partial class frmCadProduto
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
            this.txtGrupo = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtBarras = new System.Windows.Forms.TextBox();
            this.lblBarras = new System.Windows.Forms.Label();
            this.mtbCnpj_Forn = new System.Windows.Forms.MaskedTextBox();
            this.txtDesc_prod = new System.Windows.Forms.TextBox();
            this.txtCod_prod = new System.Windows.Forms.TextBox();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblCod_prod = new System.Windows.Forms.Label();
            this.btnCancelar_Prod = new System.Windows.Forms.Button();
            this.btnCadastra_Prod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtGrupo
            // 
            this.txtGrupo.Font = new System.Drawing.Font("Arial", 10F);
            this.txtGrupo.Location = new System.Drawing.Point(298, 165);
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.Size = new System.Drawing.Size(181, 23);
            this.txtGrupo.TabIndex = 5;
            // 
            // txtTipo
            // 
            this.txtTipo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTipo.Font = new System.Drawing.Font("Arial", 10F);
            this.txtTipo.Location = new System.Drawing.Point(73, 165);
            this.txtTipo.Multiline = true;
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(181, 23);
            this.txtTipo.TabIndex = 4;
            // 
            // txtBarras
            // 
            this.txtBarras.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtBarras.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtBarras.CausesValidation = false;
            this.txtBarras.Font = new System.Drawing.Font("Arial", 10F);
            this.txtBarras.Location = new System.Drawing.Point(351, 44);
            this.txtBarras.Name = "txtBarras";
            this.txtBarras.Size = new System.Drawing.Size(128, 23);
            this.txtBarras.TabIndex = 2;
            // 
            // lblBarras
            // 
            this.lblBarras.AutoSize = true;
            this.lblBarras.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblBarras.Location = new System.Drawing.Point(283, 46);
            this.lblBarras.Name = "lblBarras";
            this.lblBarras.Size = new System.Drawing.Size(62, 21);
            this.lblBarras.TabIndex = 78;
            this.lblBarras.Text = "Barras:";
            // 
            // mtbCnpj_Forn
            // 
            this.mtbCnpj_Forn.Font = new System.Drawing.Font("Arial", 10F);
            this.mtbCnpj_Forn.Location = new System.Drawing.Point(333, 229);
            this.mtbCnpj_Forn.Mask = "00/00/0000";
            this.mtbCnpj_Forn.Name = "mtbCnpj_Forn";
            this.mtbCnpj_Forn.Size = new System.Drawing.Size(79, 23);
            this.mtbCnpj_Forn.TabIndex = 6;
            this.mtbCnpj_Forn.ValidatingType = typeof(System.DateTime);
            // 
            // txtDesc_prod
            // 
            this.txtDesc_prod.Font = new System.Drawing.Font("Arial", 10F);
            this.txtDesc_prod.Location = new System.Drawing.Point(73, 105);
            this.txtDesc_prod.Name = "txtDesc_prod";
            this.txtDesc_prod.Size = new System.Drawing.Size(406, 23);
            this.txtDesc_prod.TabIndex = 3;
            // 
            // txtCod_prod
            // 
            this.txtCod_prod.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtCod_prod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCod_prod.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txtCod_prod.CausesValidation = false;
            this.txtCod_prod.Font = new System.Drawing.Font("Arial", 10F);
            this.txtCod_prod.Location = new System.Drawing.Point(145, 44);
            this.txtCod_prod.Multiline = true;
            this.txtCod_prod.Name = "txtCod_prod";
            this.txtCod_prod.ReadOnly = true;
            this.txtCod_prod.Size = new System.Drawing.Size(109, 20);
            this.txtCod_prod.TabIndex = 1;
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblCNPJ.Location = new System.Drawing.Point(141, 231);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(186, 21);
            this.lblCNPJ.TabIndex = 72;
            this.lblCNPJ.Text = "Data da ultima Compra:";
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblGrupo.Location = new System.Drawing.Point(294, 141);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(63, 21);
            this.lblGrupo.TabIndex = 71;
            this.lblGrupo.Text = "Grupo:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblTipo.Location = new System.Drawing.Point(69, 141);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(49, 21);
            this.lblTipo.TabIndex = 70;
            this.lblTipo.Text = "Tipo:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblDescricao.Location = new System.Drawing.Point(69, 81);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(89, 21);
            this.lblDescricao.TabIndex = 69;
            this.lblDescricao.Text = "Descrição:";
            // 
            // lblCod_prod
            // 
            this.lblCod_prod.AutoSize = true;
            this.lblCod_prod.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblCod_prod.Location = new System.Drawing.Point(69, 46);
            this.lblCod_prod.Name = "lblCod_prod";
            this.lblCod_prod.Size = new System.Drawing.Size(70, 21);
            this.lblCod_prod.TabIndex = 68;
            this.lblCod_prod.Text = "Codigo:";
            // 
            // btnCancelar_Prod
            // 
            this.btnCancelar_Prod.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelar_Prod.Image = global::Main_Project.Properties.Resources.not_icon;
            this.btnCancelar_Prod.Location = new System.Drawing.Point(150, 321);
            this.btnCancelar_Prod.Name = "btnCancelar_Prod";
            this.btnCancelar_Prod.Size = new System.Drawing.Size(75, 56);
            this.btnCancelar_Prod.TabIndex = 76;
            this.btnCancelar_Prod.UseVisualStyleBackColor = false;
            // 
            // btnCadastra_Prod
            // 
            this.btnCadastra_Prod.BackColor = System.Drawing.SystemColors.Control;
            this.btnCadastra_Prod.Image = global::Main_Project.Properties.Resources.accept_icon;
            this.btnCadastra_Prod.Location = new System.Drawing.Point(330, 321);
            this.btnCadastra_Prod.Name = "btnCadastra_Prod";
            this.btnCadastra_Prod.Size = new System.Drawing.Size(75, 56);
            this.btnCadastra_Prod.TabIndex = 77;
            this.btnCadastra_Prod.UseVisualStyleBackColor = false;
            this.btnCadastra_Prod.Click += new System.EventHandler(this.btnCadastra_Prod_Click);
            // 
            // frmCadProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 421);
            this.Controls.Add(this.txtGrupo);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtBarras);
            this.Controls.Add(this.lblBarras);
            this.Controls.Add(this.mtbCnpj_Forn);
            this.Controls.Add(this.txtDesc_prod);
            this.Controls.Add(this.txtCod_prod);
            this.Controls.Add(this.lblCNPJ);
            this.Controls.Add(this.lblGrupo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblCod_prod);
            this.Controls.Add(this.btnCancelar_Prod);
            this.Controls.Add(this.btnCadastra_Prod);
            this.Name = "frmCadProduto";
            this.Text = "Cadastro de Produto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGrupo;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtBarras;
        private System.Windows.Forms.Label lblBarras;
        private System.Windows.Forms.MaskedTextBox mtbCnpj_Forn;
        private System.Windows.Forms.TextBox txtDesc_prod;
        private System.Windows.Forms.TextBox txtCod_prod;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblCod_prod;
        private System.Windows.Forms.Button btnCancelar_Prod;
        private System.Windows.Forms.Button btnCadastra_Prod;
    }
}