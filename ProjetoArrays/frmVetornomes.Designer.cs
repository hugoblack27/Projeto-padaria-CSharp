namespace ProjetoArrays
{
    partial class frmVetornomes
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
            this.btnNomes = new System.Windows.Forms.Button();
            this.txtNomes = new System.Windows.Forms.TextBox();
            this.lblNomes = new System.Windows.Forms.Label();
            this.ltbListanomes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnNomes
            // 
            this.btnNomes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNomes.Location = new System.Drawing.Point(48, 391);
            this.btnNomes.Name = "btnNomes";
            this.btnNomes.Size = new System.Drawing.Size(222, 47);
            this.btnNomes.TabIndex = 0;
            this.btnNomes.Text = "nomes";
            this.btnNomes.UseVisualStyleBackColor = true;
            this.btnNomes.Click += new System.EventHandler(this.btnNomes_Click);
            // 
            // txtNomes
            // 
            this.txtNomes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomes.Location = new System.Drawing.Point(48, 109);
            this.txtNomes.Name = "txtNomes";
            this.txtNomes.Size = new System.Drawing.Size(201, 24);
            this.txtNomes.TabIndex = 1;
            // 
            // lblNomes
            // 
            this.lblNomes.AutoSize = true;
            this.lblNomes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomes.Location = new System.Drawing.Point(45, 65);
            this.lblNomes.Name = "lblNomes";
            this.lblNomes.Size = new System.Drawing.Size(57, 18);
            this.lblNomes.TabIndex = 2;
            this.lblNomes.Text = "Nomes";
            // 
            // ltbListanomes
            // 
            this.ltbListanomes.FormattingEnabled = true;
            this.ltbListanomes.Location = new System.Drawing.Point(511, 52);
            this.ltbListanomes.Name = "ltbListanomes";
            this.ltbListanomes.Size = new System.Drawing.Size(237, 212);
            this.ltbListanomes.TabIndex = 3;
            // 
            // frmVetornomes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 450);
            this.Controls.Add(this.ltbListanomes);
            this.Controls.Add(this.lblNomes);
            this.Controls.Add(this.txtNomes);
            this.Controls.Add(this.btnNomes);
            this.Name = "frmVetornomes";
            this.Text = "frmVetornomes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNomes;
        private System.Windows.Forms.TextBox txtNomes;
        private System.Windows.Forms.Label lblNomes;
        private System.Windows.Forms.ListBox ltbListanomes;
    }
}