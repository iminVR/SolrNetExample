namespace SolrNetPrimer
{
    partial class Form1
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
            this.btnPretrazivanje = new System.Windows.Forms.Button();
            this.btnIndeksiranje = new System.Windows.Forms.Button();
            this.lblPolje = new System.Windows.Forms.Label();
            this.txtUpit = new System.Windows.Forms.TextBox();
            this.lblUpit = new System.Windows.Forms.Label();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.cmbPolje = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPretrazivanje
            // 
            this.btnPretrazivanje.Location = new System.Drawing.Point(419, 63);
            this.btnPretrazivanje.Name = "btnPretrazivanje";
            this.btnPretrazivanje.Size = new System.Drawing.Size(149, 32);
            this.btnPretrazivanje.TabIndex = 0;
            this.btnPretrazivanje.Text = "Pretraživanje";
            this.btnPretrazivanje.UseVisualStyleBackColor = true;
            this.btnPretrazivanje.Click += new System.EventHandler(this.btnPretrazivanje_Click);
            // 
            // btnIndeksiranje
            // 
            this.btnIndeksiranje.Location = new System.Drawing.Point(12, 12);
            this.btnIndeksiranje.Name = "btnIndeksiranje";
            this.btnIndeksiranje.Size = new System.Drawing.Size(149, 32);
            this.btnIndeksiranje.TabIndex = 1;
            this.btnIndeksiranje.Text = "Indeksiranje";
            this.btnIndeksiranje.UseVisualStyleBackColor = true;
            this.btnIndeksiranje.Click += new System.EventHandler(this.btnIndeksiranje_Click);
            // 
            // lblPolje
            // 
            this.lblPolje.AutoSize = true;
            this.lblPolje.Location = new System.Drawing.Point(12, 71);
            this.lblPolje.Name = "lblPolje";
            this.lblPolje.Size = new System.Drawing.Size(43, 17);
            this.lblPolje.TabIndex = 2;
            this.lblPolje.Text = "Polje:";
            // 
            // txtUpit
            // 
            this.txtUpit.Location = new System.Drawing.Point(271, 68);
            this.txtUpit.Name = "txtUpit";
            this.txtUpit.Size = new System.Drawing.Size(100, 22);
            this.txtUpit.TabIndex = 5;
            // 
            // lblUpit
            // 
            this.lblUpit.AutoSize = true;
            this.lblUpit.Location = new System.Drawing.Point(222, 71);
            this.lblUpit.Name = "lblUpit";
            this.lblUpit.Size = new System.Drawing.Size(37, 17);
            this.lblUpit.TabIndex = 4;
            this.lblUpit.Text = "Upit:";
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            this.dgvResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Location = new System.Drawing.Point(0, 128);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.ReadOnly = true;
            this.dgvResults.RowHeadersWidth = 51;
            this.dgvResults.RowTemplate.Height = 24;
            this.dgvResults.Size = new System.Drawing.Size(800, 322);
            this.dgvResults.TabIndex = 6;
            // 
            // cmbPolje
            // 
            this.cmbPolje.FormattingEnabled = true;
            this.cmbPolje.Items.AddRange(new object[] {
            "body",
            "id",
            "link"});
            this.cmbPolje.Location = new System.Drawing.Point(62, 64);
            this.cmbPolje.Name = "cmbPolje";
            this.cmbPolje.Size = new System.Drawing.Size(121, 24);
            this.cmbPolje.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbPolje);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.txtUpit);
            this.Controls.Add(this.lblUpit);
            this.Controls.Add(this.lblPolje);
            this.Controls.Add(this.btnIndeksiranje);
            this.Controls.Add(this.btnPretrazivanje);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPretrazivanje;
        private System.Windows.Forms.Button btnIndeksiranje;
        private System.Windows.Forms.Label lblPolje;
        private System.Windows.Forms.TextBox txtUpit;
        private System.Windows.Forms.Label lblUpit;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.ComboBox cmbPolje;
    }
}

