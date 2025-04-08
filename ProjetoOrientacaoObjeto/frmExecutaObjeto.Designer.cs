namespace ProjetoOrientacaoObjeto
{
    partial class frmExecutaObjeto
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
            this.btnsomar = new System.Windows.Forms.Button();
            this.lblResposta = new System.Windows.Forms.Label();
            this.btnSubitrair = new System.Windows.Forms.Button();
            this.btnmultiplicar = new System.Windows.Forms.Button();
            this.btndividir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnsomar
            // 
            this.btnsomar.Location = new System.Drawing.Point(12, 12);
            this.btnsomar.Name = "btnsomar";
            this.btnsomar.Size = new System.Drawing.Size(152, 57);
            this.btnsomar.TabIndex = 0;
            this.btnsomar.Text = "Somar";
            this.btnsomar.UseVisualStyleBackColor = true;
            this.btnsomar.Click += new System.EventHandler(this.btnsomar_Click);
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResposta.Location = new System.Drawing.Point(31, 398);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(78, 20);
            this.lblResposta.TabIndex = 1;
            this.lblResposta.Text = "Resposta";
            // 
            // btnSubitrair
            // 
            this.btnSubitrair.Location = new System.Drawing.Point(12, 87);
            this.btnSubitrair.Name = "btnSubitrair";
            this.btnSubitrair.Size = new System.Drawing.Size(152, 57);
            this.btnSubitrair.TabIndex = 2;
            this.btnSubitrair.Text = "subitrair";
            this.btnSubitrair.UseVisualStyleBackColor = true;
            this.btnSubitrair.Click += new System.EventHandler(this.btnSubitrair_Click);
            // 
            // btnmultiplicar
            // 
            this.btnmultiplicar.Location = new System.Drawing.Point(12, 163);
            this.btnmultiplicar.Name = "btnmultiplicar";
            this.btnmultiplicar.Size = new System.Drawing.Size(152, 57);
            this.btnmultiplicar.TabIndex = 3;
            this.btnmultiplicar.Text = "multiplicar";
            this.btnmultiplicar.UseVisualStyleBackColor = true;
            this.btnmultiplicar.Click += new System.EventHandler(this.btnmultiplicar_Click);
            // 
            // btndividir
            // 
            this.btndividir.Location = new System.Drawing.Point(12, 238);
            this.btndividir.Name = "btndividir";
            this.btndividir.Size = new System.Drawing.Size(152, 57);
            this.btndividir.TabIndex = 4;
            this.btndividir.Text = "dividir";
            this.btndividir.UseVisualStyleBackColor = true;
            this.btndividir.Click += new System.EventHandler(this.btndividir_Click);
            // 
            // frmExecutaObjeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 441);
            this.Controls.Add(this.btndividir);
            this.Controls.Add(this.btnmultiplicar);
            this.Controls.Add(this.btnSubitrair);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.btnsomar);
            this.Name = "frmExecutaObjeto";
            this.Text = "frmExecutaObjeto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsomar;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.Button btnSubitrair;
        private System.Windows.Forms.Button btnmultiplicar;
        private System.Windows.Forms.Button btndividir;
    }
}