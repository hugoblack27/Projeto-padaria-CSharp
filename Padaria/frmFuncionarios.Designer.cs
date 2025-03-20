namespace Padaria
{
    partial class frmFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFuncionarios));
            this.gpbDadosPessoais = new System.Windows.Forms.GroupBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtbCodigo = new System.Windows.Forms.TextBox();
            this.txtbNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtbEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.mskdTxtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblDatanasc = new System.Windows.Forms.Label();
            this.dtTpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.lblCelular = new System.Windows.Forms.Label();
            this.mskdtxtbCelular = new System.Windows.Forms.MaskedTextBox();
            this.gpbSexo = new System.Windows.Forms.GroupBox();
            this.rbtnFemenino = new System.Windows.Forms.RadioButton();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.rbtnNãoInformar = new System.Windows.Forms.RadioButton();
            this.lblFoto = new System.Windows.Forms.Label();
            this.pctbFoto = new System.Windows.Forms.PictureBox();
            this.btnCaregar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.gpbendereco = new System.Windows.Forms.GroupBox();
            this.mskdtxtbCEP = new System.Windows.Forms.MaskedTextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.txtbLogradouro = new System.Windows.Forms.TextBox();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.txtbBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtbCidade = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.cbbEstado = new System.Windows.Forms.ComboBox();
            this.txtbNumero = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnAlterarEndereco = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLimparEndereco = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtbComplemento = new System.Windows.Forms.TextBox();
            this.gpbDadosPessoais.SuspendLayout();
            this.gpbSexo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbFoto)).BeginInit();
            this.gpbendereco.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbDadosPessoais
            // 
            this.gpbDadosPessoais.Controls.Add(this.btnLimpar);
            this.gpbDadosPessoais.Controls.Add(this.btnAlterar);
            this.gpbDadosPessoais.Controls.Add(this.btnCaregar);
            this.gpbDadosPessoais.Controls.Add(this.pctbFoto);
            this.gpbDadosPessoais.Controls.Add(this.lblFoto);
            this.gpbDadosPessoais.Controls.Add(this.gpbSexo);
            this.gpbDadosPessoais.Controls.Add(this.mskdtxtbCelular);
            this.gpbDadosPessoais.Controls.Add(this.lblCelular);
            this.gpbDadosPessoais.Controls.Add(this.dtTpDataNascimento);
            this.gpbDadosPessoais.Controls.Add(this.lblDatanasc);
            this.gpbDadosPessoais.Controls.Add(this.mskdTxtbCPF);
            this.gpbDadosPessoais.Controls.Add(this.lblCPF);
            this.gpbDadosPessoais.Controls.Add(this.txtbEmail);
            this.gpbDadosPessoais.Controls.Add(this.lblEmail);
            this.gpbDadosPessoais.Controls.Add(this.txtbNome);
            this.gpbDadosPessoais.Controls.Add(this.lblNome);
            this.gpbDadosPessoais.Controls.Add(this.txtbCodigo);
            this.gpbDadosPessoais.Controls.Add(this.lblCodigo);
            this.gpbDadosPessoais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDadosPessoais.Location = new System.Drawing.Point(12, 12);
            this.gpbDadosPessoais.Name = "gpbDadosPessoais";
            this.gpbDadosPessoais.Size = new System.Drawing.Size(756, 314);
            this.gpbDadosPessoais.TabIndex = 0;
            this.gpbDadosPessoais.TabStop = false;
            this.gpbDadosPessoais.Text = "Dados Pessoais";
            this.gpbDadosPessoais.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(16, 78);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(67, 20);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código :";
            this.lblCodigo.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtbCodigo
            // 
            this.txtbCodigo.Enabled = false;
            this.txtbCodigo.Location = new System.Drawing.Point(89, 75);
            this.txtbCodigo.MaxLength = 10;
            this.txtbCodigo.Name = "txtbCodigo";
            this.txtbCodigo.Size = new System.Drawing.Size(100, 26);
            this.txtbCodigo.TabIndex = 1;
            this.txtbCodigo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtbNome
            // 
            this.txtbNome.Location = new System.Drawing.Point(260, 75);
            this.txtbNome.MaxLength = 100;
            this.txtbNome.Name = "txtbNome";
            this.txtbNome.Size = new System.Drawing.Size(200, 26);
            this.txtbNome.TabIndex = 2;
            this.txtbNome.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(195, 78);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(59, 20);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome :";
            this.lblNome.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtbEmail
            // 
            this.txtbEmail.Location = new System.Drawing.Point(532, 75);
            this.txtbEmail.MaxLength = 100;
            this.txtbEmail.Name = "txtbEmail";
            this.txtbEmail.Size = new System.Drawing.Size(218, 26);
            this.txtbEmail.TabIndex = 3;
            this.txtbEmail.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(466, 78);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(56, 20);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email :";
            this.lblEmail.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(16, 137);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(48, 20);
            this.lblCPF.TabIndex = 6;
            this.lblCPF.Text = "CPF :";
            // 
            // mskdTxtbCPF
            // 
            this.mskdTxtbCPF.Location = new System.Drawing.Point(70, 134);
            this.mskdTxtbCPF.Mask = "999,999,999-99";
            this.mskdTxtbCPF.Name = "mskdTxtbCPF";
            this.mskdTxtbCPF.Size = new System.Drawing.Size(119, 26);
            this.mskdTxtbCPF.TabIndex = 4;
            // 
            // lblDatanasc
            // 
            this.lblDatanasc.AutoSize = true;
            this.lblDatanasc.Location = new System.Drawing.Point(206, 137);
            this.lblDatanasc.Name = "lblDatanasc";
            this.lblDatanasc.Size = new System.Drawing.Size(160, 20);
            this.lblDatanasc.TabIndex = 8;
            this.lblDatanasc.Text = "Data de nascimento :";
            this.lblDatanasc.Click += new System.EventHandler(this.label5_Click);
            // 
            // dtTpDataNascimento
            // 
            this.dtTpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTpDataNascimento.Location = new System.Drawing.Point(372, 134);
            this.dtTpDataNascimento.Name = "dtTpDataNascimento";
            this.dtTpDataNascimento.Size = new System.Drawing.Size(101, 26);
            this.dtTpDataNascimento.TabIndex = 5;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(496, 137);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(66, 20);
            this.lblCelular.TabIndex = 10;
            this.lblCelular.Text = "Celular :";
            this.lblCelular.Click += new System.EventHandler(this.label6_Click);
            // 
            // mskdtxtbCelular
            // 
            this.mskdtxtbCelular.Location = new System.Drawing.Point(558, 134);
            this.mskdtxtbCelular.Mask = "99999-9999";
            this.mskdtxtbCelular.Name = "mskdtxtbCelular";
            this.mskdtxtbCelular.Size = new System.Drawing.Size(119, 26);
            this.mskdtxtbCelular.TabIndex = 6;
            // 
            // gpbSexo
            // 
            this.gpbSexo.Controls.Add(this.rbtnNãoInformar);
            this.gpbSexo.Controls.Add(this.rbtnMasculino);
            this.gpbSexo.Controls.Add(this.rbtnFemenino);
            this.gpbSexo.Location = new System.Drawing.Point(6, 182);
            this.gpbSexo.Name = "gpbSexo";
            this.gpbSexo.Size = new System.Drawing.Size(226, 126);
            this.gpbSexo.TabIndex = 7;
            this.gpbSexo.TabStop = false;
            this.gpbSexo.Text = "Sexo :";
            this.gpbSexo.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // rbtnFemenino
            // 
            this.rbtnFemenino.AutoSize = true;
            this.rbtnFemenino.Location = new System.Drawing.Point(36, 30);
            this.rbtnFemenino.Name = "rbtnFemenino";
            this.rbtnFemenino.Size = new System.Drawing.Size(92, 24);
            this.rbtnFemenino.TabIndex = 8;
            this.rbtnFemenino.TabStop = true;
            this.rbtnFemenino.Text = "Feminino";
            this.rbtnFemenino.UseVisualStyleBackColor = true;
            this.rbtnFemenino.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.Location = new System.Drawing.Point(36, 60);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(98, 24);
            this.rbtnMasculino.TabIndex = 9;
            this.rbtnMasculino.TabStop = true;
            this.rbtnMasculino.Text = "Masculino";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            this.rbtnMasculino.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbtnNãoInformar
            // 
            this.rbtnNãoInformar.AutoSize = true;
            this.rbtnNãoInformar.Location = new System.Drawing.Point(36, 90);
            this.rbtnNãoInformar.Name = "rbtnNãoInformar";
            this.rbtnNãoInformar.Size = new System.Drawing.Size(174, 24);
            this.rbtnNãoInformar.TabIndex = 10;
            this.rbtnNãoInformar.TabStop = true;
            this.rbtnNãoInformar.Text = "Não Desejo Informar";
            this.rbtnNãoInformar.UseVisualStyleBackColor = true;
            this.rbtnNãoInformar.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.Location = new System.Drawing.Point(238, 186);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(50, 20);
            this.lblFoto.TabIndex = 14;
            this.lblFoto.Text = "Foto :";
            this.lblFoto.Click += new System.EventHandler(this.label7_Click);
            // 
            // pctbFoto
            // 
            this.pctbFoto.Image = ((System.Drawing.Image)(resources.GetObject("pctbFoto.Image")));
            this.pctbFoto.Location = new System.Drawing.Point(294, 186);
            this.pctbFoto.Name = "pctbFoto";
            this.pctbFoto.Size = new System.Drawing.Size(154, 110);
            this.pctbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctbFoto.TabIndex = 15;
            this.pctbFoto.TabStop = false;
            // 
            // btnCaregar
            // 
            this.btnCaregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaregar.Image = ((System.Drawing.Image)(resources.GetObject("btnCaregar.Image")));
            this.btnCaregar.Location = new System.Drawing.Point(473, 187);
            this.btnCaregar.Name = "btnCaregar";
            this.btnCaregar.Size = new System.Drawing.Size(77, 29);
            this.btnCaregar.TabIndex = 11;
            this.btnCaregar.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.Location = new System.Drawing.Point(473, 222);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(77, 29);
            this.btnAlterar.TabIndex = 12;
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(473, 257);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(77, 29);
            this.btnLimpar.TabIndex = 13;
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // gpbendereco
            // 
            this.gpbendereco.Controls.Add(this.txtbComplemento);
            this.gpbendereco.Controls.Add(this.lblEstado);
            this.gpbendereco.Controls.Add(this.panel1);
            this.gpbendereco.Controls.Add(this.lblCidade);
            this.gpbendereco.Controls.Add(this.txtbNumero);
            this.gpbendereco.Controls.Add(this.cbbEstado);
            this.gpbendereco.Controls.Add(this.lblComplemento);
            this.gpbendereco.Controls.Add(this.txtbCidade);
            this.gpbendereco.Controls.Add(this.lblNumero);
            this.gpbendereco.Controls.Add(this.lblBairro);
            this.gpbendereco.Controls.Add(this.txtbBairro);
            this.gpbendereco.Controls.Add(this.mskdtxtbCEP);
            this.gpbendereco.Controls.Add(this.lblCEP);
            this.gpbendereco.Controls.Add(this.txtbLogradouro);
            this.gpbendereco.Controls.Add(this.lblLogradouro);
            this.gpbendereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbendereco.Location = new System.Drawing.Point(12, 332);
            this.gpbendereco.Name = "gpbendereco";
            this.gpbendereco.Size = new System.Drawing.Size(756, 226);
            this.gpbendereco.TabIndex = 14;
            this.gpbendereco.TabStop = false;
            this.gpbendereco.Text = "Endereço";
            // 
            // mskdtxtbCEP
            // 
            this.mskdtxtbCEP.Location = new System.Drawing.Point(631, 34);
            this.mskdtxtbCEP.Mask = "99999-999";
            this.mskdtxtbCEP.Name = "mskdtxtbCEP";
            this.mskdtxtbCEP.Size = new System.Drawing.Size(119, 26);
            this.mskdtxtbCEP.TabIndex = 17;
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(572, 37);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(49, 20);
            this.lblCEP.TabIndex = 4;
            this.lblCEP.Text = "CEP :";
            // 
            // txtbLogradouro
            // 
            this.txtbLogradouro.Location = new System.Drawing.Point(111, 34);
            this.txtbLogradouro.MaxLength = 100;
            this.txtbLogradouro.Name = "txtbLogradouro";
            this.txtbLogradouro.Size = new System.Drawing.Size(255, 26);
            this.txtbLogradouro.TabIndex = 15;
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Location = new System.Drawing.Point(6, 37);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(99, 20);
            this.lblLogradouro.TabIndex = 2;
            this.lblLogradouro.Text = "Logradouro :";
            // 
            // txtbBairro
            // 
            this.txtbBairro.Location = new System.Drawing.Point(70, 78);
            this.txtbBairro.MaxLength = 100;
            this.txtbBairro.Name = "txtbBairro";
            this.txtbBairro.Size = new System.Drawing.Size(285, 26);
            this.txtbBairro.TabIndex = 18;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(5, 81);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(59, 20);
            this.lblBairro.TabIndex = 13;
            this.lblBairro.Text = "Bairro :";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(387, 37);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(73, 20);
            this.lblNumero.TabIndex = 14;
            this.lblNumero.Text = "Número :";
            this.lblNumero.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtbCidade
            // 
            this.txtbCidade.Location = new System.Drawing.Point(460, 78);
            this.txtbCidade.MaxLength = 100;
            this.txtbCidade.Name = "txtbCidade";
            this.txtbCidade.Size = new System.Drawing.Size(204, 26);
            this.txtbCidade.TabIndex = 19;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(239, 123);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(116, 20);
            this.lblComplemento.TabIndex = 16;
            this.lblComplemento.Text = "Complemento :";
            // 
            // cbbEstado
            // 
            this.cbbEstado.FormattingEnabled = true;
            this.cbbEstado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AM",
            "BA",
            "CE",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO",
            "DF"});
            this.cbbEstado.Location = new System.Drawing.Point(80, 119);
            this.cbbEstado.Name = "cbbEstado";
            this.cbbEstado.Size = new System.Drawing.Size(121, 28);
            this.cbbEstado.TabIndex = 20;
            // 
            // txtbNumero
            // 
            this.txtbNumero.Location = new System.Drawing.Point(466, 34);
            this.txtbNumero.MaxLength = 10;
            this.txtbNumero.Name = "txtbNumero";
            this.txtbNumero.Size = new System.Drawing.Size(100, 26);
            this.txtbNumero.TabIndex = 16;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(387, 81);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(67, 20);
            this.lblCidade.TabIndex = 20;
            this.lblCidade.Text = "Cidade :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnVoltar);
            this.panel1.Controls.Add(this.btnPesquisar);
            this.panel1.Controls.Add(this.btnLimparEndereco);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.btnAlterarEndereco);
            this.panel1.Controls.Add(this.btnCadastrar);
            this.panel1.Controls.Add(this.btnNovo);
            this.panel1.Location = new System.Drawing.Point(10, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 60);
            this.panel1.TabIndex = 22;
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.Location = new System.Drawing.Point(3, 13);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(100, 40);
            this.btnNovo.TabIndex = 23;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovo.UseVisualStyleBackColor = false;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.Location = new System.Drawing.Point(108, 13);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(114, 40);
            this.btnCadastrar.TabIndex = 24;
            this.btnCadastrar.Text = "&Cadastrar";
            this.btnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // btnAlterarEndereco
            // 
            this.btnAlterarEndereco.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAlterarEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarEndereco.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterarEndereco.Image")));
            this.btnAlterarEndereco.Location = new System.Drawing.Point(225, 13);
            this.btnAlterarEndereco.Name = "btnAlterarEndereco";
            this.btnAlterarEndereco.Size = new System.Drawing.Size(100, 40);
            this.btnAlterarEndereco.TabIndex = 25;
            this.btnAlterarEndereco.Text = "&Alterar";
            this.btnAlterarEndereco.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterarEndereco.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(328, 13);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 40);
            this.btnExcluir.TabIndex = 26;
            this.btnExcluir.Text = "E&xcluir";
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnLimparEndereco
            // 
            this.btnLimparEndereco.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLimparEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparEndereco.Image = ((System.Drawing.Image)(resources.GetObject("btnLimparEndereco.Image")));
            this.btnLimparEndereco.Location = new System.Drawing.Point(432, 13);
            this.btnLimparEndereco.Name = "btnLimparEndereco";
            this.btnLimparEndereco.Size = new System.Drawing.Size(100, 40);
            this.btnLimparEndereco.TabIndex = 27;
            this.btnLimparEndereco.Text = "&Limpar";
            this.btnLimparEndereco.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimparEndereco.UseVisualStyleBackColor = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(535, 13);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(117, 40);
            this.btnPesquisar.TabIndex = 28;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar.Location = new System.Drawing.Point(658, 13);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(84, 40);
            this.btnVoltar.TabIndex = 29;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar.UseVisualStyleBackColor = false;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(9, 126);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(68, 20);
            this.lblEstado.TabIndex = 22;
            this.lblEstado.Text = "Estado :";
            // 
            // txtbComplemento
            // 
            this.txtbComplemento.Location = new System.Drawing.Point(361, 120);
            this.txtbComplemento.MaxLength = 30;
            this.txtbComplemento.Name = "txtbComplemento";
            this.txtbComplemento.Size = new System.Drawing.Size(148, 26);
            this.txtbComplemento.TabIndex = 21;
            // 
            // frmFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 557);
            this.Controls.Add(this.gpbendereco);
            this.Controls.Add(this.gpbDadosPessoais);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Padaria - Funcionarios";
            this.Load += new System.EventHandler(this.frmFuncionarios_Load);
            this.gpbDadosPessoais.ResumeLayout(false);
            this.gpbDadosPessoais.PerformLayout();
            this.gpbSexo.ResumeLayout(false);
            this.gpbSexo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbFoto)).EndInit();
            this.gpbendereco.ResumeLayout(false);
            this.gpbendereco.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbDadosPessoais;
        private System.Windows.Forms.TextBox txtbEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtbNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtbCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.MaskedTextBox mskdTxtbCPF;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblDatanasc;
        private System.Windows.Forms.DateTimePicker dtTpDataNascimento;
        private System.Windows.Forms.MaskedTextBox mskdtxtbCelular;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.GroupBox gpbSexo;
        private System.Windows.Forms.RadioButton rbtnNãoInformar;
        private System.Windows.Forms.RadioButton rbtnMasculino;
        private System.Windows.Forms.RadioButton rbtnFemenino;
        private System.Windows.Forms.Label lblFoto;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCaregar;
        private System.Windows.Forms.PictureBox pctbFoto;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.GroupBox gpbendereco;
        private System.Windows.Forms.MaskedTextBox mskdtxtbCEP;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.TextBox txtbLogradouro;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtbBairro;
        private System.Windows.Forms.TextBox txtbCidade;
        private System.Windows.Forms.ComboBox cbbEstado;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.TextBox txtbNumero;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnLimparEndereco;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterarEndereco;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox txtbComplemento;
        private System.Windows.Forms.Label lblEstado;
    }
}