namespace ProjetoArrays
{
    partial class frmVetores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVetores));
            this.gpbNomes = new System.Windows.Forms.GroupBox();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.gpbListaNomes = new System.Windows.Forms.GroupBox();
            this.ltbNomes = new System.Windows.Forms.ListBox();
            this.lblTamanho = new System.Windows.Forms.Label();
            this.txtTamanho = new System.Windows.Forms.TextBox();
            this.txtInsiraNome = new System.Windows.Forms.TextBox();
            this.lblInsiranome = new System.Windows.Forms.Label();
            this.gpbNomes.SuspendLayout();
            this.gpbListaNomes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbNomes
            // 
            this.gpbNomes.Controls.Add(this.txtInsiraNome);
            this.gpbNomes.Controls.Add(this.lblInsiranome);
            this.gpbNomes.Controls.Add(this.txtTamanho);
            this.gpbNomes.Controls.Add(this.lblTamanho);
            this.gpbNomes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbNomes.Location = new System.Drawing.Point(12, 12);
            this.gpbNomes.Name = "gpbNomes";
            this.gpbNomes.Size = new System.Drawing.Size(313, 235);
            this.gpbNomes.TabIndex = 0;
            this.gpbNomes.TabStop = false;
            this.gpbNomes.Text = "Nomes";
            // 
            // btnCarregar
            // 
            this.btnCarregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregar.Location = new System.Drawing.Point(12, 432);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(123, 41);
            this.btnCarregar.TabIndex = 1;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // gpbListaNomes
            // 
            this.gpbListaNomes.Controls.Add(this.ltbNomes);
            this.gpbListaNomes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbListaNomes.Location = new System.Drawing.Point(399, 12);
            this.gpbListaNomes.Name = "gpbListaNomes";
            this.gpbListaNomes.Size = new System.Drawing.Size(325, 305);
            this.gpbListaNomes.TabIndex = 1;
            this.gpbListaNomes.TabStop = false;
            this.gpbListaNomes.Text = "Lista nomes";
            // 
            // ltbNomes
            // 
            this.ltbNomes.FormattingEnabled = true;
            this.ltbNomes.ItemHeight = 18;
            this.ltbNomes.Location = new System.Drawing.Point(6, 23);
            this.ltbNomes.Name = "ltbNomes";
            this.ltbNomes.Size = new System.Drawing.Size(251, 184);
            this.ltbNomes.TabIndex = 0;
            // 
            // lblTamanho
            // 
            this.lblTamanho.AutoSize = true;
            this.lblTamanho.Location = new System.Drawing.Point(20, 48);
            this.lblTamanho.Name = "lblTamanho";
            this.lblTamanho.Size = new System.Drawing.Size(71, 18);
            this.lblTamanho.TabIndex = 2;
            this.lblTamanho.Text = "Tamanho";
            // 
            // txtTamanho
            // 
            this.txtTamanho.Location = new System.Drawing.Point(23, 78);
            this.txtTamanho.MaxLength = 3;
            this.txtTamanho.Name = "txtTamanho";
            this.txtTamanho.Size = new System.Drawing.Size(100, 24);
            this.txtTamanho.TabIndex = 3;
            // 
            // txtInsiraNome
            // 
            this.txtInsiraNome.Location = new System.Drawing.Point(23, 152);
            this.txtInsiraNome.MaxLength = 100;
            this.txtInsiraNome.Name = "txtInsiraNome";
            this.txtInsiraNome.Size = new System.Drawing.Size(270, 24);
            this.txtInsiraNome.TabIndex = 5;
            // 
            // lblInsiranome
            // 
            this.lblInsiranome.AutoSize = true;
            this.lblInsiranome.Location = new System.Drawing.Point(20, 122);
            this.lblInsiranome.Name = "lblInsiranome";
            this.lblInsiranome.Size = new System.Drawing.Size(110, 18);
            this.lblInsiranome.TabIndex = 4;
            this.lblInsiranome.Text = "Insira um nome";
            // 
            // frmVetores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 525);
            this.Controls.Add(this.gpbListaNomes);
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(this.gpbNomes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmVetores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vetores";
            this.gpbNomes.ResumeLayout(false);
            this.gpbNomes.PerformLayout();
            this.gpbListaNomes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbNomes;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.GroupBox gpbListaNomes;
        private System.Windows.Forms.ListBox ltbNomes;
        private System.Windows.Forms.TextBox txtTamanho;
        private System.Windows.Forms.Label lblTamanho;
        private System.Windows.Forms.TextBox txtInsiraNome;
        private System.Windows.Forms.Label lblInsiranome;
    }
}