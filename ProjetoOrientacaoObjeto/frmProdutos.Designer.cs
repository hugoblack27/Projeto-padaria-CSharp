namespace ProjetoOrientacaoObjeto
{
    partial class frmProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProdutos));
            this.gpbDadosProduto = new System.Windows.Forms.GroupBox();
            this.lblDatadeSaida = new System.Windows.Forms.Label();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.lblDataEntrada = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtquantidade = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.lbldescriç = new System.Windows.Forms.Label();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.gpbResposta = new System.Windows.Forms.GroupBox();
            this.lblExecutaDataSaida = new System.Windows.Forms.Label();
            this.lblExecutaDataEntrada = new System.Windows.Forms.Label();
            this.lblExecutaTotal = new System.Windows.Forms.Label();
            this.lblExecutaQuantidade = new System.Windows.Forms.Label();
            this.lblExecutaValor = new System.Windows.Forms.Label();
            this.lblExecutaDescricao = new System.Windows.Forms.Label();
            this.lblExecutacodigo = new System.Windows.Forms.Label();
            this.dtpDataEntrada = new System.Windows.Forms.DateTimePicker();
            this.dtpDataSaida = new System.Windows.Forms.DateTimePicker();
            this.gpbDadosProduto.SuspendLayout();
            this.gpbResposta.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbDadosProduto
            // 
            this.gpbDadosProduto.Controls.Add(this.dtpDataSaida);
            this.gpbDadosProduto.Controls.Add(this.dtpDataEntrada);
            this.gpbDadosProduto.Controls.Add(this.lblDatadeSaida);
            this.gpbDadosProduto.Controls.Add(this.txtvalor);
            this.gpbDadosProduto.Controls.Add(this.lblDataEntrada);
            this.gpbDadosProduto.Controls.Add(this.lblValor);
            this.gpbDadosProduto.Controls.Add(this.txtquantidade);
            this.gpbDadosProduto.Controls.Add(this.lblQuantidade);
            this.gpbDadosProduto.Controls.Add(this.txtcodigo);
            this.gpbDadosProduto.Controls.Add(this.txtdescricao);
            this.gpbDadosProduto.Controls.Add(this.lbldescriç);
            this.gpbDadosProduto.Controls.Add(this.lblcodigo);
            this.gpbDadosProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDadosProduto.Location = new System.Drawing.Point(12, 12);
            this.gpbDadosProduto.Name = "gpbDadosProduto";
            this.gpbDadosProduto.Size = new System.Drawing.Size(921, 180);
            this.gpbDadosProduto.TabIndex = 0;
            this.gpbDadosProduto.TabStop = false;
            this.gpbDadosProduto.Text = "Dados Produto";
            // 
            // lblDatadeSaida
            // 
            this.lblDatadeSaida.AutoSize = true;
            this.lblDatadeSaida.Location = new System.Drawing.Point(630, 71);
            this.lblDatadeSaida.Name = "lblDatadeSaida";
            this.lblDatadeSaida.Size = new System.Drawing.Size(111, 20);
            this.lblDatadeSaida.TabIndex = 13;
            this.lblDatadeSaida.Text = "Data de Saída";
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(101, 124);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(161, 26);
            this.txtvalor.TabIndex = 11;
            // 
            // lblDataEntrada
            // 
            this.lblDataEntrada.AutoSize = true;
            this.lblDataEntrada.Location = new System.Drawing.Point(630, 39);
            this.lblDataEntrada.Name = "lblDataEntrada";
            this.lblDataEntrada.Size = new System.Drawing.Size(125, 20);
            this.lblDataEntrada.TabIndex = 9;
            this.lblDataEntrada.Text = "Data de entrada";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(15, 127);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(46, 20);
            this.lblValor.TabIndex = 8;
            this.lblValor.Text = "Valor";
            // 
            // txtquantidade
            // 
            this.txtquantidade.Location = new System.Drawing.Point(447, 33);
            this.txtquantidade.Name = "txtquantidade";
            this.txtquantidade.Size = new System.Drawing.Size(161, 26);
            this.txtquantidade.TabIndex = 7;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(349, 36);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(92, 20);
            this.lblQuantidade.TabIndex = 4;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(101, 30);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(161, 26);
            this.txtcodigo.TabIndex = 3;
            // 
            // txtdescricao
            // 
            this.txtdescricao.Location = new System.Drawing.Point(101, 76);
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(161, 26);
            this.txtdescricao.TabIndex = 2;
            // 
            // lbldescriç
            // 
            this.lbldescriç.AutoSize = true;
            this.lbldescriç.Location = new System.Drawing.Point(15, 79);
            this.lbldescriç.Name = "lbldescriç";
            this.lbldescriç.Size = new System.Drawing.Size(80, 20);
            this.lbldescriç.TabIndex = 1;
            this.lbldescriç.Text = "Descrição";
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(15, 33);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(59, 20);
            this.lblcodigo.TabIndex = 0;
            this.lblcodigo.Text = "Código";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(38, 479);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(96, 40);
            this.btnCadastrar.TabIndex = 1;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(174, 479);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(96, 40);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(312, 479);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(96, 40);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // gpbResposta
            // 
            this.gpbResposta.Controls.Add(this.lblExecutaDataSaida);
            this.gpbResposta.Controls.Add(this.lblExecutaDataEntrada);
            this.gpbResposta.Controls.Add(this.lblExecutaTotal);
            this.gpbResposta.Controls.Add(this.lblExecutaQuantidade);
            this.gpbResposta.Controls.Add(this.lblExecutaValor);
            this.gpbResposta.Controls.Add(this.lblExecutaDescricao);
            this.gpbResposta.Controls.Add(this.lblExecutacodigo);
            this.gpbResposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbResposta.Location = new System.Drawing.Point(14, 207);
            this.gpbResposta.Name = "gpbResposta";
            this.gpbResposta.Size = new System.Drawing.Size(918, 210);
            this.gpbResposta.TabIndex = 4;
            this.gpbResposta.TabStop = false;
            this.gpbResposta.Text = "Resposta";
            // 
            // lblExecutaDataSaida
            // 
            this.lblExecutaDataSaida.AutoSize = true;
            this.lblExecutaDataSaida.Location = new System.Drawing.Point(347, 98);
            this.lblExecutaDataSaida.Name = "lblExecutaDataSaida";
            this.lblExecutaDataSaida.Size = new System.Drawing.Size(111, 20);
            this.lblExecutaDataSaida.TabIndex = 6;
            this.lblExecutaDataSaida.Text = "Data de Saída";
            // 
            // lblExecutaDataEntrada
            // 
            this.lblExecutaDataEntrada.AutoSize = true;
            this.lblExecutaDataEntrada.Location = new System.Drawing.Point(347, 55);
            this.lblExecutaDataEntrada.Name = "lblExecutaDataEntrada";
            this.lblExecutaDataEntrada.Size = new System.Drawing.Size(127, 20);
            this.lblExecutaDataEntrada.TabIndex = 5;
            this.lblExecutaDataEntrada.Text = "Data de Entrada";
            // 
            // lblExecutaTotal
            // 
            this.lblExecutaTotal.AutoSize = true;
            this.lblExecutaTotal.Location = new System.Drawing.Point(605, 170);
            this.lblExecutaTotal.Name = "lblExecutaTotal";
            this.lblExecutaTotal.Size = new System.Drawing.Size(44, 20);
            this.lblExecutaTotal.TabIndex = 4;
            this.lblExecutaTotal.Text = "Total";
            // 
            // lblExecutaQuantidade
            // 
            this.lblExecutaQuantidade.AutoSize = true;
            this.lblExecutaQuantidade.Location = new System.Drawing.Point(347, 170);
            this.lblExecutaQuantidade.Name = "lblExecutaQuantidade";
            this.lblExecutaQuantidade.Size = new System.Drawing.Size(92, 20);
            this.lblExecutaQuantidade.TabIndex = 3;
            this.lblExecutaQuantidade.Text = "Quantidade";
            // 
            // lblExecutaValor
            // 
            this.lblExecutaValor.AutoSize = true;
            this.lblExecutaValor.Location = new System.Drawing.Point(26, 170);
            this.lblExecutaValor.Name = "lblExecutaValor";
            this.lblExecutaValor.Size = new System.Drawing.Size(46, 20);
            this.lblExecutaValor.TabIndex = 2;
            this.lblExecutaValor.Text = "Valor";
            // 
            // lblExecutaDescricao
            // 
            this.lblExecutaDescricao.AutoSize = true;
            this.lblExecutaDescricao.Location = new System.Drawing.Point(21, 98);
            this.lblExecutaDescricao.Name = "lblExecutaDescricao";
            this.lblExecutaDescricao.Size = new System.Drawing.Size(80, 20);
            this.lblExecutaDescricao.TabIndex = 1;
            this.lblExecutaDescricao.Text = "Descrição";
            // 
            // lblExecutacodigo
            // 
            this.lblExecutacodigo.AutoSize = true;
            this.lblExecutacodigo.Location = new System.Drawing.Point(21, 55);
            this.lblExecutacodigo.Name = "lblExecutacodigo";
            this.lblExecutacodigo.Size = new System.Drawing.Size(59, 20);
            this.lblExecutacodigo.TabIndex = 0;
            this.lblExecutacodigo.Text = "Código";
            // 
            // dtpDataEntrada
            // 
            this.dtpDataEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataEntrada.Location = new System.Drawing.Point(770, 34);
            this.dtpDataEntrada.Name = "dtpDataEntrada";
            this.dtpDataEntrada.Size = new System.Drawing.Size(108, 26);
            this.dtpDataEntrada.TabIndex = 14;
            // 
            // dtpDataSaida
            // 
            this.dtpDataSaida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataSaida.Location = new System.Drawing.Point(770, 71);
            this.dtpDataSaida.Name = "dtpDataSaida";
            this.dtpDataSaida.Size = new System.Drawing.Size(108, 26);
            this.dtpDataSaida.TabIndex = 15;
            // 
            // frmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 533);
            this.Controls.Add(this.gpbResposta);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.gpbDadosProduto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Produtos ";
            this.gpbDadosProduto.ResumeLayout(false);
            this.gpbDadosProduto.PerformLayout();
            this.gpbResposta.ResumeLayout(false);
            this.gpbResposta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbDadosProduto;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.Label lbldescriç;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Label lblDatadeSaida;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.Label lblDataEntrada;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtquantidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox gpbResposta;
        private System.Windows.Forms.Label lblExecutaDataSaida;
        private System.Windows.Forms.Label lblExecutaDataEntrada;
        private System.Windows.Forms.Label lblExecutaTotal;
        private System.Windows.Forms.Label lblExecutaQuantidade;
        private System.Windows.Forms.Label lblExecutaValor;
        private System.Windows.Forms.Label lblExecutaDescricao;
        private System.Windows.Forms.Label lblExecutacodigo;
        private System.Windows.Forms.DateTimePicker dtpDataSaida;
        private System.Windows.Forms.DateTimePicker dtpDataEntrada;
    }
}