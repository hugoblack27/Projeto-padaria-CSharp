namespace Padaria
{
    partial class frmSlpash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSlpash));
            this.lblNUM = new System.Windows.Forms.Label();
            this.lblPorcentagem = new System.Windows.Forms.Label();
            this.pgbLogo = new System.Windows.Forms.ProgressBar();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNUM
            // 
            this.lblNUM.AutoSize = true;
            this.lblNUM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNUM.Location = new System.Drawing.Point(382, 296);
            this.lblNUM.Name = "lblNUM";
            this.lblNUM.Size = new System.Drawing.Size(18, 20);
            this.lblNUM.TabIndex = 0;
            this.lblNUM.Text = "0";
            this.lblNUM.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPorcentagem
            // 
            this.lblPorcentagem.AutoSize = true;
            this.lblPorcentagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentagem.Location = new System.Drawing.Point(397, 296);
            this.lblPorcentagem.Name = "lblPorcentagem";
            this.lblPorcentagem.Size = new System.Drawing.Size(23, 20);
            this.lblPorcentagem.TabIndex = 1;
            this.lblPorcentagem.Text = "%";
            this.lblPorcentagem.Click += new System.EventHandler(this.label2_Click);
            // 
            // pgbLogo
            // 
            this.pgbLogo.Location = new System.Drawing.Point(280, 334);
            this.pgbLogo.Name = "pgbLogo";
            this.pgbLogo.Size = new System.Drawing.Size(241, 18);
            this.pgbLogo.TabIndex = 3;
            // 
            // pcbLogo
            // 
            this.pcbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pcbLogo.Image")));
            this.pcbLogo.Location = new System.Drawing.Point(299, 150);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(197, 127);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLogo.TabIndex = 4;
            this.pcbLogo.TabStop = false;
            // 
            // frmSlpash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pcbLogo);
            this.Controls.Add(this.pgbLogo);
            this.Controls.Add(this.lblPorcentagem);
            this.Controls.Add(this.lblNUM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSlpash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "padaria - Slpash";
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNUM;
        private System.Windows.Forms.Label lblPorcentagem;
        private System.Windows.Forms.ProgressBar pgbLogo;
        private System.Windows.Forms.PictureBox pcbLogo;
    }
}