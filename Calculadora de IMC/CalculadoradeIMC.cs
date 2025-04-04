using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_de_IMC
{
    public partial class CalculadoradeIMC : Form
    {
        public CalculadoradeIMC()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAltura.Clear();
            txtIdade.Clear();
            txtPeso.Clear();
            txtCalculodoIMC.Clear();
            rbtnFeminino.Checked = false;
            rbtnMasculino.Checked = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
               
            double peso = Convert.ToDouble(txtPeso.Text);
            double altura = Convert.ToDouble(txtAltura.Text);
              

            double IMC = peso / (altura * altura);

            
           









            //Mandando o Calculo para o texto
            txtCalculodoIMC.Text = IMC.ToString("F2");
        }
    }
}
