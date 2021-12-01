namespace Main_Project
{
    partial class frmAjusteEstoque
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
            this.txtDesc_prod = new System.Windows.Forms.TextBox();
            this.txtCod_prod = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblCod_prod = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblQtd = new System.Windows.Forms.Label();
            this.btnCancelarAjuste = new System.Windows.Forms.Button();
            this.btnAjusteProd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDesc_prod
            // 
            this.txtDesc_prod.Font = new System.Drawing.Font("Arial", 10F);
            this.txtDesc_prod.Location = new System.Drawing.Point(95, 33);
            this.txtDesc_prod.Name = "txtDesc_prod";
            this.txtDesc_prod.Size = new System.Drawing.Size(336, 23);
            this.txtDesc_prod.TabIndex = 2;
            // 
            // txtCod_prod
            // 
            this.txtCod_prod.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtCod_prod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCod_prod.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txtCod_prod.CausesValidation = false;
            this.txtCod_prod.Font = new System.Drawing.Font("Arial", 10F);
            this.txtCod_prod.Location = new System.Drawing.Point(16, 33);
            this.txtCod_prod.Multiline = true;
            this.txtCod_prod.Name = "txtCod_prod";
            this.txtCod_prod.Size = new System.Drawing.Size(75, 23);
            this.txtCod_prod.TabIndex = 1;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblDescricao.Location = new System.Drawing.Point(91, 9);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(89, 21);
            this.lblDescricao.TabIndex = 83;
            this.lblDescricao.Text = "Descrição:";
            // 
            // lblCod_prod
            // 
            this.lblCod_prod.AutoSize = true;
            this.lblCod_prod.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblCod_prod.Location = new System.Drawing.Point(12, 9);
            this.lblCod_prod.Name = "lblCod_prod";
            this.lblCod_prod.Size = new System.Drawing.Size(70, 21);
            this.lblCod_prod.TabIndex = 82;
            this.lblCod_prod.Text = "Codigo:";
            // 
            // textBox1
            // 
            this.textBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.textBox1.CausesValidation = false;
            this.textBox1.Font = new System.Drawing.Font("Arial", 10F);
            this.textBox1.Location = new System.Drawing.Point(16, 109);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(95, 23);
            this.textBox1.TabIndex = 3;
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblQtd.Location = new System.Drawing.Point(12, 85);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(99, 21);
            this.lblQtd.TabIndex = 85;
            this.lblQtd.Text = "Quantidade:";
            // 
            // btnCancelarAjuste
            // 
            this.btnCancelarAjuste.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelarAjuste.Image = global::Main_Project.Properties.Resources.not_icon;
            this.btnCancelarAjuste.Location = new System.Drawing.Point(101, 151);
            this.btnCancelarAjuste.Name = "btnCancelarAjuste";
            this.btnCancelarAjuste.Size = new System.Drawing.Size(75, 56);
            this.btnCancelarAjuste.TabIndex = 5;
            this.btnCancelarAjuste.UseVisualStyleBackColor = false;
            this.btnCancelarAjuste.Click += new System.EventHandler(this.btnCancelarAjuste_Click);
            // 
            // btnAjusteProd
            // 
            this.btnAjusteProd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAjusteProd.Image = global::Main_Project.Properties.Resources.accept_icon;
            this.btnAjusteProd.Location = new System.Drawing.Point(281, 151);
            this.btnAjusteProd.Name = "btnAjusteProd";
            this.btnAjusteProd.Size = new System.Drawing.Size(75, 56);
            this.btnAjusteProd.TabIndex = 4;
            this.btnAjusteProd.UseVisualStyleBackColor = false;
            this.btnAjusteProd.Click += new System.EventHandler(this.btnAjusteProd_Click);
            // 
            // frmAjusteEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 228);
            this.Controls.Add(this.btnCancelarAjuste);
            this.Controls.Add(this.btnAjusteProd);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblQtd);
            this.Controls.Add(this.txtDesc_prod);
            this.Controls.Add(this.txtCod_prod);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblCod_prod);
            this.Name = "frmAjusteEstoque";
            this.Text = "frmAjusteEstoque";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDesc_prod;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblCod_prod;
        private System.Windows.Forms.TextBox txtCod_prod;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.Button btnCancelarAjuste;
        private System.Windows.Forms.Button btnAjusteProd;
    }
}