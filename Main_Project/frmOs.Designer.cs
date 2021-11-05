namespace Main_Project
{
    partial class frmOs
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpLista = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbpCadOs = new System.Windows.Forms.TabPage();
            this.tsFrmOs = new System.Windows.Forms.ToolStrip();
            this.tsbExitFrmOS = new System.Windows.Forms.ToolStripButton();
            this.tabControl1.SuspendLayout();
            this.tbpLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tsFrmOs.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpLista);
            this.tabControl1.Controls.Add(this.tbpCadOs);
            this.tabControl1.Location = new System.Drawing.Point(40, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(819, 523);
            this.tabControl1.TabIndex = 0;
            // 
            // tbpLista
            // 
            this.tbpLista.Controls.Add(this.dataGridView1);
            this.tbpLista.Location = new System.Drawing.Point(4, 22);
            this.tbpLista.Name = "tbpLista";
            this.tbpLista.Padding = new System.Windows.Forms.Padding(3);
            this.tbpLista.Size = new System.Drawing.Size(811, 497);
            this.tbpLista.TabIndex = 0;
            this.tbpLista.Text = "Lista";
            this.tbpLista.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(805, 491);
            this.dataGridView1.TabIndex = 0;
            // 
            // tbpCadOs
            // 
            this.tbpCadOs.Location = new System.Drawing.Point(4, 22);
            this.tbpCadOs.Name = "tbpCadOs";
            this.tbpCadOs.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCadOs.Size = new System.Drawing.Size(811, 497);
            this.tbpCadOs.TabIndex = 1;
            this.tbpCadOs.Text = "Cadastrar";
            this.tbpCadOs.UseVisualStyleBackColor = true;
            // 
            // tsFrmOs
            // 
            this.tsFrmOs.Dock = System.Windows.Forms.DockStyle.Left;
            this.tsFrmOs.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tsFrmOs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbExitFrmOS});
            this.tsFrmOs.Location = new System.Drawing.Point(0, 0);
            this.tsFrmOs.Name = "tsFrmOs";
            this.tsFrmOs.Size = new System.Drawing.Size(37, 523);
            this.tsFrmOs.TabIndex = 1;
            this.tsFrmOs.Text = "toolStrip1";
            // 
            // tsbExitFrmOS
            // 
            this.tsbExitFrmOS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExitFrmOS.Image = global::Main_Project.Properties.Resources.Exit_icon;
            this.tsbExitFrmOS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExitFrmOS.Name = "tsbExitFrmOS";
            this.tsbExitFrmOS.Size = new System.Drawing.Size(34, 36);
            this.tsbExitFrmOS.Text = "toolStripButton1";
            this.tsbExitFrmOS.Click += new System.EventHandler(this.tsbExitFrmOS_Click);
            // 
            // frmOs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 523);
            this.Controls.Add(this.tsFrmOs);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmOs";
            this.tabControl1.ResumeLayout(false);
            this.tbpLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tsFrmOs.ResumeLayout(false);
            this.tsFrmOs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpLista;
        private System.Windows.Forms.TabPage tbpCadOs;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip tsFrmOs;
        private System.Windows.Forms.ToolStripButton tsbExitFrmOS;
    }
}