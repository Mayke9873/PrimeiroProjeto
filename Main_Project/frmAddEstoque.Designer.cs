namespace Main_Project
{
    partial class frmAddEstoque
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mtbCnpj_Forn = new System.Windows.Forms.MaskedTextBox();
            this.txtDesc_prod = new System.Windows.Forms.TextBox();
            this.txtCod_prod = new System.Windows.Forms.TextBox();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblCod_prod = new System.Windows.Forms.Label();
            this.btnCancelar_Forn = new System.Windows.Forms.Button();
            this.btnCadastra_Forn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(73, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(406, 181);
            this.dataGridView1.TabIndex = 87;
            // 
            // mtbCnpj_Forn
            // 
            this.mtbCnpj_Forn.Font = new System.Drawing.Font("Arial", 10F);
            this.mtbCnpj_Forn.Location = new System.Drawing.Point(400, 44);
            this.mtbCnpj_Forn.Mask = "00/00/0000";
            this.mtbCnpj_Forn.Name = "mtbCnpj_Forn";
            this.mtbCnpj_Forn.Size = new System.Drawing.Size(79, 23);
            this.mtbCnpj_Forn.TabIndex = 84;
            this.mtbCnpj_Forn.ValidatingType = typeof(System.DateTime);
            // 
            // txtDesc_prod
            // 
            this.txtDesc_prod.Font = new System.Drawing.Font("Arial", 10F);
            this.txtDesc_prod.Location = new System.Drawing.Point(73, 105);
            this.txtDesc_prod.Name = "txtDesc_prod";
            this.txtDesc_prod.Size = new System.Drawing.Size(406, 23);
            this.txtDesc_prod.TabIndex = 83;
            // 
            // txtCod_prod
            // 
            this.txtCod_prod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtCod_prod.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtCod_prod.CausesValidation = false;
            this.txtCod_prod.Font = new System.Drawing.Font("Arial", 10F);
            this.txtCod_prod.Location = new System.Drawing.Point(145, 44);
            this.txtCod_prod.Name = "txtCod_prod";
            this.txtCod_prod.Size = new System.Drawing.Size(109, 23);
            this.txtCod_prod.TabIndex = 82;
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblCNPJ.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCNPJ.Location = new System.Drawing.Point(260, 44);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(137, 21);
            this.lblCNPJ.TabIndex = 81;
            this.lblCNPJ.Text = "Data da Compra:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblDescricao.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDescricao.Location = new System.Drawing.Point(69, 81);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(89, 21);
            this.lblDescricao.TabIndex = 80;
            this.lblDescricao.Text = "Descrição:";
            // 
            // lblCod_prod
            // 
            this.lblCod_prod.AutoSize = true;
            this.lblCod_prod.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblCod_prod.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCod_prod.Location = new System.Drawing.Point(69, 46);
            this.lblCod_prod.Name = "lblCod_prod";
            this.lblCod_prod.Size = new System.Drawing.Size(70, 21);
            this.lblCod_prod.TabIndex = 79;
            this.lblCod_prod.Text = "Codigo:";
            // 
            // btnCancelar_Forn
            // 
            this.btnCancelar_Forn.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelar_Forn.Image = global::Main_Project.Properties.Resources.not_icon;
            this.btnCancelar_Forn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancelar_Forn.Location = new System.Drawing.Point(150, 321);
            this.btnCancelar_Forn.Name = "btnCancelar_Forn";
            this.btnCancelar_Forn.Size = new System.Drawing.Size(75, 56);
            this.btnCancelar_Forn.TabIndex = 85;
            this.btnCancelar_Forn.UseVisualStyleBackColor = false;
            // 
            // btnCadastra_Forn
            // 
            this.btnCadastra_Forn.BackColor = System.Drawing.SystemColors.Control;
            this.btnCadastra_Forn.Image = global::Main_Project.Properties.Resources.accept_icon;
            this.btnCadastra_Forn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCadastra_Forn.Location = new System.Drawing.Point(330, 321);
            this.btnCadastra_Forn.Name = "btnCadastra_Forn";
            this.btnCadastra_Forn.Size = new System.Drawing.Size(75, 56);
            this.btnCadastra_Forn.TabIndex = 86;
            this.btnCadastra_Forn.UseVisualStyleBackColor = false;
            // 
            // frmAddEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 421);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.mtbCnpj_Forn);
            this.Controls.Add(this.txtDesc_prod);
            this.Controls.Add(this.txtCod_prod);
            this.Controls.Add(this.lblCNPJ);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblCod_prod);
            this.Controls.Add(this.btnCancelar_Forn);
            this.Controls.Add(this.btnCadastra_Forn);
            this.Name = "frmAddEstoque";
            this.Text = "Entrada de Estoque";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox mtbCnpj_Forn;
        private System.Windows.Forms.TextBox txtDesc_prod;
        private System.Windows.Forms.TextBox txtCod_prod;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblCod_prod;
        private System.Windows.Forms.Button btnCancelar_Forn;
        private System.Windows.Forms.Button btnCadastra_Forn;
    }
}