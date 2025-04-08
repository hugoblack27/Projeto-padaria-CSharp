namespace ProjetoOrientacaoObjeto
{
    partial class frmExecutaPessoa
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
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.gpbDadosPessoais = new System.Windows.Forms.GroupBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.gpbMostrarRegistros = new System.Windows.Forms.GroupBox();
            this.lblMostrarNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.lblIdade = new System.Windows.Forms.Label();
            this.mskbCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.mskbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblMostrarEmail = new System.Windows.Forms.Label();
            this.lblMostrarIdade = new System.Windows.Forms.Label();
            this.lblMostrarCPF = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblMostrarTelefone = new System.Windows.Forms.Label();
            this.gpbDadosPessoais.SuspendLayout();
            this.gpbMostrarRegistros.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(12, 394);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(125, 44);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // gpbDadosPessoais
            // 
            this.gpbDadosPessoais.Controls.Add(this.lblTelefone);
            this.gpbDadosPessoais.Controls.Add(this.mskbTelefone);
            this.gpbDadosPessoais.Controls.Add(this.lblCPF);
            this.gpbDadosPessoais.Controls.Add(this.mskbCPF);
            this.gpbDadosPessoais.Controls.Add(this.txtIdade);
            this.gpbDadosPessoais.Controls.Add(this.lblIdade);
            this.gpbDadosPessoais.Controls.Add(this.txtEmail);
            this.gpbDadosPessoais.Controls.Add(this.lblEmail);
            this.gpbDadosPessoais.Controls.Add(this.txtNome);
            this.gpbDadosPessoais.Controls.Add(this.lblNome);
            this.gpbDadosPessoais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDadosPessoais.Location = new System.Drawing.Point(12, 12);
            this.gpbDadosPessoais.Name = "gpbDadosPessoais";
            this.gpbDadosPessoais.Size = new System.Drawing.Size(622, 201);
            this.gpbDadosPessoais.TabIndex = 1;
            this.gpbDadosPessoais.TabStop = false;
            this.gpbDadosPessoais.Text = "Dados Pessoais";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(40, 40);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 20);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // gpbMostrarRegistros
            // 
            this.gpbMostrarRegistros.Controls.Add(this.lblMostrarTelefone);
            this.gpbMostrarRegistros.Controls.Add(this.lblMostrarCPF);
            this.gpbMostrarRegistros.Controls.Add(this.lblMostrarIdade);
            this.gpbMostrarRegistros.Controls.Add(this.lblMostrarEmail);
            this.gpbMostrarRegistros.Controls.Add(this.lblMostrarNome);
            this.gpbMostrarRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbMostrarRegistros.Location = new System.Drawing.Point(12, 219);
            this.gpbMostrarRegistros.Name = "gpbMostrarRegistros";
            this.gpbMostrarRegistros.Size = new System.Drawing.Size(622, 130);
            this.gpbMostrarRegistros.TabIndex = 2;
            this.gpbMostrarRegistros.TabStop = false;
            this.gpbMostrarRegistros.Text = "Mostrar Registros";
            // 
            // lblMostrarNome
            // 
            this.lblMostrarNome.AutoSize = true;
            this.lblMostrarNome.Location = new System.Drawing.Point(40, 40);
            this.lblMostrarNome.Name = "lblMostrarNome";
            this.lblMostrarNome.Size = new System.Drawing.Size(51, 20);
            this.lblMostrarNome.TabIndex = 0;
            this.lblMostrarNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(97, 37);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(132, 26);
            this.txtNome.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(324, 37);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(225, 26);
            this.txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(270, 40);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(97, 82);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(55, 26);
            this.txtIdade.TabIndex = 5;
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(40, 85);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(50, 20);
            this.lblIdade.TabIndex = 4;
            this.lblIdade.Text = "Idade";
            // 
            // mskbCPF
            // 
            this.mskbCPF.Location = new System.Drawing.Point(324, 85);
            this.mskbCPF.Mask = "999,999,999-99";
            this.mskbCPF.Name = "mskbCPF";
            this.mskbCPF.Size = new System.Drawing.Size(132, 26);
            this.mskbCPF.TabIndex = 6;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(270, 88);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(40, 20);
            this.lblCPF.TabIndex = 7;
            this.lblCPF.Text = "CPF";
            // 
            // mskbTelefone
            // 
            this.mskbTelefone.Location = new System.Drawing.Point(99, 134);
            this.mskbTelefone.Mask = "(99) 99999-9999";
            this.mskbTelefone.Name = "mskbTelefone";
            this.mskbTelefone.Size = new System.Drawing.Size(132, 26);
            this.mskbTelefone.TabIndex = 8;
            // 
            // lblMostrarEmail
            // 
            this.lblMostrarEmail.AutoSize = true;
            this.lblMostrarEmail.Location = new System.Drawing.Point(181, 40);
            this.lblMostrarEmail.Name = "lblMostrarEmail";
            this.lblMostrarEmail.Size = new System.Drawing.Size(48, 20);
            this.lblMostrarEmail.TabIndex = 1;
            this.lblMostrarEmail.Text = "Email";
            // 
            // lblMostrarIdade
            // 
            this.lblMostrarIdade.AutoSize = true;
            this.lblMostrarIdade.Location = new System.Drawing.Point(179, 91);
            this.lblMostrarIdade.Name = "lblMostrarIdade";
            this.lblMostrarIdade.Size = new System.Drawing.Size(50, 20);
            this.lblMostrarIdade.TabIndex = 2;
            this.lblMostrarIdade.Text = "Idade";
            // 
            // lblMostrarCPF
            // 
            this.lblMostrarCPF.AutoSize = true;
            this.lblMostrarCPF.Location = new System.Drawing.Point(399, 40);
            this.lblMostrarCPF.Name = "lblMostrarCPF";
            this.lblMostrarCPF.Size = new System.Drawing.Size(40, 20);
            this.lblMostrarCPF.TabIndex = 3;
            this.lblMostrarCPF.Text = "CPF";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(20, 137);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(71, 20);
            this.lblTelefone.TabIndex = 9;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblMostrarTelefone
            // 
            this.lblMostrarTelefone.AutoSize = true;
            this.lblMostrarTelefone.Location = new System.Drawing.Point(40, 91);
            this.lblMostrarTelefone.Name = "lblMostrarTelefone";
            this.lblMostrarTelefone.Size = new System.Drawing.Size(71, 20);
            this.lblMostrarTelefone.TabIndex = 10;
            this.lblMostrarTelefone.Text = "Telefone";
            // 
            // frmExecutaPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gpbMostrarRegistros);
            this.Controls.Add(this.gpbDadosPessoais);
            this.Controls.Add(this.btnCadastrar);
            this.Name = "frmExecutaPessoa";
            this.Text = "frmExecutaPessoa";
            this.gpbDadosPessoais.ResumeLayout(false);
            this.gpbDadosPessoais.PerformLayout();
            this.gpbMostrarRegistros.ResumeLayout(false);
            this.gpbMostrarRegistros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.GroupBox gpbDadosPessoais;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox gpbMostrarRegistros;
        private System.Windows.Forms.Label lblMostrarNome;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.MaskedTextBox mskbCPF;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.MaskedTextBox mskbTelefone;
        private System.Windows.Forms.Label lblMostrarCPF;
        private System.Windows.Forms.Label lblMostrarIdade;
        private System.Windows.Forms.Label lblMostrarEmail;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblMostrarTelefone;
    }
}