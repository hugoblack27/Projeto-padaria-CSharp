namespace Padaria
{
    partial class frmCalculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculadora));
            this.lblNumero1 = new System.Windows.Forms.Label();
            this.lblNumero2 = new System.Windows.Forms.Label();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.gpbOperacoes = new System.Windows.Forms.GroupBox();
            this.rbtnDivisao = new System.Windows.Forms.RadioButton();
            this.rbtnMultiplicar = new System.Windows.Forms.RadioButton();
            this.rbtnSubitrair = new System.Windows.Forms.RadioButton();
            this.rbtnSomar = new System.Windows.Forms.RadioButton();
            this.txtbResposta = new System.Windows.Forms.TextBox();
            this.lblResposta = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.gpbOperacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumero1
            // 
            this.lblNumero1.AutoSize = true;
            this.lblNumero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero1.Location = new System.Drawing.Point(38, 69);
            this.lblNumero1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumero1.Name = "lblNumero1";
            this.lblNumero1.Size = new System.Drawing.Size(86, 20);
            this.lblNumero1.TabIndex = 0;
            this.lblNumero1.Text = "Número 1 :";
            // 
            // lblNumero2
            // 
            this.lblNumero2.AutoSize = true;
            this.lblNumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero2.Location = new System.Drawing.Point(38, 157);
            this.lblNumero2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumero2.Name = "lblNumero2";
            this.lblNumero2.Size = new System.Drawing.Size(86, 20);
            this.lblNumero2.TabIndex = 1;
            this.lblNumero2.Text = "Número 2 :";
            // 
            // txtNumero1
            // 
            this.txtNumero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero1.Location = new System.Drawing.Point(42, 108);
            this.txtNumero1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumero1.MaxLength = 10;
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(190, 26);
            this.txtNumero1.TabIndex = 0;
            // 
            // txtNumero2
            // 
            this.txtNumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero2.Location = new System.Drawing.Point(42, 198);
            this.txtNumero2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumero2.MaxLength = 10;
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(190, 26);
            this.txtNumero2.TabIndex = 1;
            // 
            // gpbOperacoes
            // 
            this.gpbOperacoes.Controls.Add(this.rbtnDivisao);
            this.gpbOperacoes.Controls.Add(this.rbtnMultiplicar);
            this.gpbOperacoes.Controls.Add(this.rbtnSubitrair);
            this.gpbOperacoes.Controls.Add(this.rbtnSomar);
            this.gpbOperacoes.Location = new System.Drawing.Point(369, 92);
            this.gpbOperacoes.Name = "gpbOperacoes";
            this.gpbOperacoes.Size = new System.Drawing.Size(236, 221);
            this.gpbOperacoes.TabIndex = 2;
            this.gpbOperacoes.TabStop = false;
            this.gpbOperacoes.Text = "Operações";
            // 
            // rbtnDivisao
            // 
            this.rbtnDivisao.AutoSize = true;
            this.rbtnDivisao.Location = new System.Drawing.Point(26, 164);
            this.rbtnDivisao.Name = "rbtnDivisao";
            this.rbtnDivisao.Size = new System.Drawing.Size(78, 24);
            this.rbtnDivisao.TabIndex = 6;
            this.rbtnDivisao.TabStop = true;
            this.rbtnDivisao.Text = "Divisão";
            this.rbtnDivisao.UseVisualStyleBackColor = true;
            // 
            // rbtnMultiplicar
            // 
            this.rbtnMultiplicar.AutoSize = true;
            this.rbtnMultiplicar.Location = new System.Drawing.Point(26, 124);
            this.rbtnMultiplicar.Name = "rbtnMultiplicar";
            this.rbtnMultiplicar.Size = new System.Drawing.Size(97, 24);
            this.rbtnMultiplicar.TabIndex = 5;
            this.rbtnMultiplicar.TabStop = true;
            this.rbtnMultiplicar.Text = "Multiplicar";
            this.rbtnMultiplicar.UseVisualStyleBackColor = true;
            // 
            // rbtnSubitrair
            // 
            this.rbtnSubitrair.AutoSize = true;
            this.rbtnSubitrair.Location = new System.Drawing.Point(26, 83);
            this.rbtnSubitrair.Name = "rbtnSubitrair";
            this.rbtnSubitrair.Size = new System.Drawing.Size(86, 24);
            this.rbtnSubitrair.TabIndex = 4;
            this.rbtnSubitrair.TabStop = true;
            this.rbtnSubitrair.Text = "Subitrair";
            this.rbtnSubitrair.UseVisualStyleBackColor = true;
            // 
            // rbtnSomar
            // 
            this.rbtnSomar.AutoSize = true;
            this.rbtnSomar.Location = new System.Drawing.Point(26, 42);
            this.rbtnSomar.Name = "rbtnSomar";
            this.rbtnSomar.Size = new System.Drawing.Size(74, 24);
            this.rbtnSomar.TabIndex = 3;
            this.rbtnSomar.TabStop = true;
            this.rbtnSomar.Text = "Somar";
            this.rbtnSomar.UseVisualStyleBackColor = true;
            // 
            // txtbResposta
            // 
            this.txtbResposta.Enabled = false;
            this.txtbResposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbResposta.Location = new System.Drawing.Point(42, 287);
            this.txtbResposta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbResposta.MaxLength = 10;
            this.txtbResposta.Name = "txtbResposta";
            this.txtbResposta.Size = new System.Drawing.Size(190, 26);
            this.txtbResposta.TabIndex = 10;
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResposta.Location = new System.Drawing.Point(38, 247);
            this.lblResposta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(86, 20);
            this.lblResposta.TabIndex = 6;
            this.lblResposta.Text = "Resposta :";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcular.Image")));
            this.btnCalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalcular.Location = new System.Drawing.Point(743, 59);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(189, 92);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("BtnLimpar.Image")));
            this.BtnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLimpar.Location = new System.Drawing.Point(743, 157);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(189, 92);
            this.BtnLimpar.TabIndex = 8;
            this.BtnLimpar.Text = "&Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(743, 261);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(189, 92);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 374);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.txtbResposta);
            this.Controls.Add(this.gpbOperacoes);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.lblNumero2);
            this.Controls.Add(this.lblNumero1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.gpbOperacoes.ResumeLayout(false);
            this.gpbOperacoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumero1;
        private System.Windows.Forms.Label lblNumero2;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.GroupBox gpbOperacoes;
        private System.Windows.Forms.RadioButton rbtnDivisao;
        private System.Windows.Forms.RadioButton rbtnMultiplicar;
        private System.Windows.Forms.RadioButton rbtnSubitrair;
        private System.Windows.Forms.RadioButton rbtnSomar;
        private System.Windows.Forms.TextBox txtbResposta;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button btnSair;
    }
}