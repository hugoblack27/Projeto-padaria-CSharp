using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoOrientacaoObjeto
{
    public partial class frmProdutos : Form
    {
        public frmProdutos()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Produtos prod = new Produtos();

            prod.setdescricao(txtdescricao.Text);
            lblExecutaDescricao.Text = prod.getdescricao();

            prod.setcodigo(txtcodigo.Text);
            lblExecutacodigo.Text = prod.getcodigo();

            prod.setvalor(Convert.ToDouble(txtvalor.Text));
            lblExecutaValor.Text = prod.getvalor().ToString();

            prod.setquantidade(Convert.ToInt32(txtquantidade.Text));
            lblExecutaQuantidade.Text = prod.getquantidade().ToString();

            prod.setdataEntrada(dtpDataEntrada.Text);
            lblExecutaDataEntrada.Text = prod.getdataEntrada();

            prod.setdataSaida(dtpDataSaida.Text);
            lblExecutaDataSaida.Text = prod.getdataSaida();


            

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtcodigo.Clear();
            txtdescricao.Clear();
            txtvalor.Clear();
            txtquantidade.Clear();
            txtcodigo.Focus();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
