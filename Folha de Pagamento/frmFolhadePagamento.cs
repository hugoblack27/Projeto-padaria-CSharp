using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Folha_de_Pagamento
{
    public partial class frmFolhadePagamento : Form
    {
        public frmFolhadePagamento()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double num1, num2, resp=0;

                
            try
            {
                num1 = Convert.ToDouble(txtbSalario.Text);
                num2 = Convert.ToDouble(txtbSalario.Text); 


                //Imposto de renda

                if (num1 <= 2259.20)
                {
                    num1 = num1 - 0;
                    resp = 0;
                }
                else if (num1 >= 2259.21 && num1 <= 2826.65)
                {
                    resp = num1 * 7.5 / 100;
                    num1 = num1 - (resp);
                }
                else if (num1 >= 2826.66 && num1 <= 3751.05)
                {
                    resp = num1 * 15 / 100;
                    num1 = num1 - (resp);
                }
                else if (num1 >= 3571.06 && num1 <= 4664.68)
                {
                    resp = num1 * 22.5 / 100;
                    num1 = num1 - (resp);
                }
                else if (num1 >= 4664.69)
                {
                    resp = num1 * 27.5 / 100;
                    num1 = num1 - (resp);
                }

                //escolhendo o clube

                if (cmbbClubes.SelectedIndex == 0)
                {
                    num1 = num1 - 100;
                }
                if (cmbbClubes.SelectedIndex == 1)
                {
                    num1 = num1 - 50;
                }
                if (cmbbClubes.SelectedIndex == 2)
                {
                    num1 = num1 - 30;
                }

                //parte do plano de saúde
                if (chkbxPlanodesaude.Checked == true)
                {
                    num1 = num1 - 400;
                }

                // mandando para o salario folha
                txtSalariofolha.Text = num2.ToString();

                //parte de resposta
                txtImpostoderenda.Text = resp.ToString();
                txtbSalarioliquido.Text = num1.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("bararaba", 
                    "Mensagem do Sistema", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtbSalario.Clear();
            txtSalariofolha.Clear();
            txtImpostoderenda.Clear();
            txtbSalarioliquido.Clear();
            chkbxPlanodesaude.Checked = false;
            cmbbClubes.Items.Clear();
            txtbSalario.Focus();
            
        }

    }
}
