namespace Folha_de_Pagamento
{
    partial class frmFolhadePagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFolhadePagamento));
            this.dttmpkrCalendario = new System.Windows.Forms.DateTimePicker();
            this.chkbxPlanodesaude = new System.Windows.Forms.CheckBox();
            this.txtbSalario = new System.Windows.Forms.TextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.cmbbClubes = new System.Windows.Forms.ComboBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblSalariofolha = new System.Windows.Forms.Label();
            this.lblImpostoderenda = new System.Windows.Forms.Label();
            this.lblSalarioliquido = new System.Windows.Forms.Label();
            this.txtSalariofolha = new System.Windows.Forms.TextBox();
            this.txtImpostoderenda = new System.Windows.Forms.TextBox();
            this.txtbSalarioliquido = new System.Windows.Forms.TextBox();
            this.lblDatafolha = new System.Windows.Forms.Label();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dttmpkrCalendario
            // 
            this.dttmpkrCalendario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dttmpkrCalendario.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dttmpkrCalendario.Location = new System.Drawing.Point(33, 63);
            this.dttmpkrCalendario.Name = "dttmpkrCalendario";
            this.dttmpkrCalendario.Size = new System.Drawing.Size(106, 24);
            this.dttmpkrCalendario.TabIndex = 0;
            // 
            // chkbxPlanodesaude
            // 
            this.chkbxPlanodesaude.AutoSize = true;
            this.chkbxPlanodesaude.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxPlanodesaude.Location = new System.Drawing.Point(33, 174);
            this.chkbxPlanodesaude.Name = "chkbxPlanodesaude";
            this.chkbxPlanodesaude.Size = new System.Drawing.Size(131, 22);
            this.chkbxPlanodesaude.TabIndex = 2;
            this.chkbxPlanodesaude.Text = "Plano de Saúde";
            this.chkbxPlanodesaude.UseVisualStyleBackColor = true;
            // 
            // txtbSalario
            // 
            this.txtbSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbSalario.Location = new System.Drawing.Point(33, 127);
            this.txtbSalario.Name = "txtbSalario";
            this.txtbSalario.Size = new System.Drawing.Size(114, 24);
            this.txtbSalario.TabIndex = 1;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.Location = new System.Drawing.Point(30, 100);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(62, 18);
            this.lblSalario.TabIndex = 3;
            this.lblSalario.Text = "Salário :";
            // 
            // cmbbClubes
            // 
            this.cmbbClubes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbClubes.FormattingEnabled = true;
            this.cmbbClubes.Items.AddRange(new object[] {
            "Clube A",
            "Clube B",
            "Clube C"});
            this.cmbbClubes.Location = new System.Drawing.Point(33, 243);
            this.cmbbClubes.Name = "cmbbClubes";
            this.cmbbClubes.Size = new System.Drawing.Size(156, 26);
            this.cmbbClubes.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcular.Image")));
            this.btnCalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalcular.Location = new System.Drawing.Point(243, 310);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(113, 50);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblSalariofolha
            // 
            this.lblSalariofolha.AutoSize = true;
            this.lblSalariofolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalariofolha.Location = new System.Drawing.Point(287, 87);
            this.lblSalariofolha.Name = "lblSalariofolha";
            this.lblSalariofolha.Size = new System.Drawing.Size(103, 18);
            this.lblSalariofolha.TabIndex = 6;
            this.lblSalariofolha.Text = "Salário Folha :";
            // 
            // lblImpostoderenda
            // 
            this.lblImpostoderenda.AutoSize = true;
            this.lblImpostoderenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpostoderenda.Location = new System.Drawing.Point(287, 133);
            this.lblImpostoderenda.Name = "lblImpostoderenda";
            this.lblImpostoderenda.Size = new System.Drawing.Size(137, 18);
            this.lblImpostoderenda.TabIndex = 7;
            this.lblImpostoderenda.Text = "Imposto de Renda :";
            // 
            // lblSalarioliquido
            // 
            this.lblSalarioliquido.AutoSize = true;
            this.lblSalarioliquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioliquido.Location = new System.Drawing.Point(287, 186);
            this.lblSalarioliquido.Name = "lblSalarioliquido";
            this.lblSalarioliquido.Size = new System.Drawing.Size(108, 18);
            this.lblSalarioliquido.TabIndex = 8;
            this.lblSalarioliquido.Text = "Salário liquido :";
            // 
            // txtSalariofolha
            // 
            this.txtSalariofolha.Enabled = false;
            this.txtSalariofolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalariofolha.Location = new System.Drawing.Point(434, 81);
            this.txtSalariofolha.Name = "txtSalariofolha";
            this.txtSalariofolha.Size = new System.Drawing.Size(170, 24);
            this.txtSalariofolha.TabIndex = 7;
            // 
            // txtImpostoderenda
            // 
            this.txtImpostoderenda.Enabled = false;
            this.txtImpostoderenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImpostoderenda.Location = new System.Drawing.Point(434, 133);
            this.txtImpostoderenda.Name = "txtImpostoderenda";
            this.txtImpostoderenda.Size = new System.Drawing.Size(170, 24);
            this.txtImpostoderenda.TabIndex = 8;
            // 
            // txtbSalarioliquido
            // 
            this.txtbSalarioliquido.Enabled = false;
            this.txtbSalarioliquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbSalarioliquido.Location = new System.Drawing.Point(434, 186);
            this.txtbSalarioliquido.Name = "txtbSalarioliquido";
            this.txtbSalarioliquido.Size = new System.Drawing.Size(170, 24);
            this.txtbSalarioliquido.TabIndex = 9;
            // 
            // lblDatafolha
            // 
            this.lblDatafolha.AutoSize = true;
            this.lblDatafolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatafolha.Location = new System.Drawing.Point(30, 31);
            this.lblDatafolha.Name = "lblDatafolha";
            this.lblDatafolha.Size = new System.Drawing.Size(103, 18);
            this.lblDatafolha.TabIndex = 12;
            this.lblDatafolha.Text = "Data da folha :";
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("BtnLimpar.Image")));
            this.BtnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLimpar.Location = new System.Drawing.Point(33, 310);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(88, 50);
            this.BtnLimpar.TabIndex = 4;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.Image = ((System.Drawing.Image)(resources.GetObject("BtnSair.Image")));
            this.BtnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSair.Location = new System.Drawing.Point(138, 310);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(88, 50);
            this.BtnSair.TabIndex = 5;
            this.BtnSair.Text = "Sair";
            this.BtnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Clube de lazer :";
            // 
            // frmFolhadePagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 389);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.lblDatafolha);
            this.Controls.Add(this.txtbSalarioliquido);
            this.Controls.Add(this.txtImpostoderenda);
            this.Controls.Add(this.txtSalariofolha);
            this.Controls.Add(this.lblSalarioliquido);
            this.Controls.Add(this.lblImpostoderenda);
            this.Controls.Add(this.lblSalariofolha);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.cmbbClubes);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.txtbSalario);
            this.Controls.Add(this.chkbxPlanodesaude);
            this.Controls.Add(this.dttmpkrCalendario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmFolhadePagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Folha de Pagamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dttmpkrCalendario;
        private System.Windows.Forms.CheckBox chkbxPlanodesaude;
        private System.Windows.Forms.TextBox txtbSalario;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.ComboBox cmbbClubes;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblSalariofolha;
        private System.Windows.Forms.Label lblImpostoderenda;
        private System.Windows.Forms.Label lblSalarioliquido;
        private System.Windows.Forms.TextBox txtSalariofolha;
        private System.Windows.Forms.TextBox txtImpostoderenda;
        private System.Windows.Forms.TextBox txtbSalarioliquido;
        private System.Windows.Forms.Label lblDatafolha;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Label label1;
    }
}