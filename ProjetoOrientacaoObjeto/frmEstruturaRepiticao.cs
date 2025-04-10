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
    public partial class frmEstruturaRepiticao : Form
    {
        //metodo construtor classe
        public frmEstruturaRepiticao()
        {
            InitializeComponent();
            //executar o método carrega comboEstados
            carregaCombo();
            //carregaListaEstado();*/
            txtInserirEstado.Focus();
        }

        private void btnCarregaEstado_Click(object sender, EventArgs e)
        {
            carregaCombo();

        }

        private void carregaCombo()
        {
            cbbEstados.Items.Clear();
            cbbEstados.Items.Add("Capão Redondo");
            cbbEstados.Items.Add("São Luis");
            cbbEstados.Items.Add("Campo Grande");
            cbbEstados.Items.Add("Piraporinha");
            cbbEstados.Items.Add("Jardim Angela");
            cbbEstados.Items.Add("Vila Remo");
            cbbEstados.Items.Add("Capelinha");
            cbbEstados.Items.Add("Campo Limpo");
            cbbEstados.Items.Add("Jardim Jacira");
            cbbEstados.Items.Add("Jardim Nakamura");

        }
        private void btnCarregarListadeDesejo_Click(object sender, EventArgs e)
        {
            carregaListaEstado();
        }

        private void carregaListaEstado()
        {
            ltbListaDesejos.Items.Clear();
            ltbListaDesejos.Items.Add("Pinheiros");
            ltbListaDesejos.Items.Add("Socorro");
            ltbListaDesejos.Items.Add("Ibirapuera");
            ltbListaDesejos.Items.Add("Moema");
            ltbListaDesejos.Items.Add("Borba Gato");
            ltbListaDesejos.Items.Add("Granja Julieta");
            ltbListaDesejos.Items.Add("Morumbi");
            ltbListaDesejos.Items.Add("Alto da Boa Vista");
            ltbListaDesejos.Items.Add("Vila Olimpia");
            ltbListaDesejos.Items.Add("Brooklin");
            ltbListaDesejos.Items.Add("Cidade Jardins");
        }

        private void btnInserirEstado_Click(object sender, EventArgs e)
        {
          inserirEstado();
        }


        public void inserirEstado()
        {
            try
            {

            ltbListaDesejos.Items.Add(txtInserirEstado.Text);
            txtInserirEstado.Focus();
            txtInserirEstado.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Favor Inserir valores.");
                txtInserirEstado.Focus();
                txtInserirEstado.Clear();
            }
        }

        private void txtInserirEstado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                inserirEstado();
            }
        }
    }
}
