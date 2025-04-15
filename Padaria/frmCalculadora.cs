using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Padaria
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //// Declarando as variáveis
            //// Tipo de variável e o nome da variável
            //int valor1, valor4, resp;
            //double valor2, valor5;
            //float valor3;
            //bool flag;
            //string nome;
            //char sexo;

            //// Inicializar as variáveis
            //valor1 = 10;
            //valor4 = 20;

            //resp = valor1 + valor4;

            //declarando as variaveis
            double num1, num2, resp=0;
            

            //inicializar as variaveis
            try
            {
                
                num1 = Convert.ToDouble(txtNumero1.Text);
                num2 = Convert.ToDouble(txtNumero2.Text);

                if (rbtnSomar.Checked == false && rbtnSubitrair.Checked == false && rbtnMultiplicar.Checked == false && rbtnDivisao.Checked == false) 
                {
                    MessageBox.Show("Selecione uma operação",
                                    "Mensagem do sistema",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error,
                                    MessageBoxDefaultButton.Button1
                                    );
                }
                Operacoes op = new Operacoes();

                if (rbtnSomar.Checked)
                {
                    resp = op.somaValor(num1, num2);                                                                       
                }

                if (rbtnSubitrair.Checked)
                {
                    resp = op.subtracaoValor(num1, num2);
                }

                if (rbtnDivisao.Checked)
                {
                    if (num2 == 0)
                    {
                        MessageBox.Show("Impossivel dividir por zero", "Mensagem do Sistema",
                            MessageBoxButtons.YesNoCancel,
                            MessageBoxIcon.Error,
                            MessageBoxDefaultButton.Button2);

                        resp = 0;
                    }

                    else
                    {
                        resp = op.divisaoValor(num1,num2);
                    }
                }

                if (rbtnMultiplicar.Checked)
                {
                    resp = op.multiplicacaoValor(num1,num2);
                }

                txtbResposta.Text = resp.ToString();

            }catch (Exception)
            {
                MessageBox.Show("Apenas usar números", 
                    "Mensagem do Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button2);
                    limparCampos();
            }

        }

        public void limparCampos()
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            txtNumero1.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //sair do sistema e encerrar todos os processos
            Application.Exit();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            //Limpar os cantos 
            limparCamposDesabilitar();
        }

        public void limparCamposDesabilitar()
        {
            txtNumero1.Text = "";
            txtNumero2.Clear();
            txtbResposta.Clear();

            rbtnSomar.Checked = false;
            rbtnSubitrair.Checked = false;
            rbtnDivisao.Checked = false;
            rbtnMultiplicar.Checked = false;

            txtNumero1.Focus();
        }
    }
}
