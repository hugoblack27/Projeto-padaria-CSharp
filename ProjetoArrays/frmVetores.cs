using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoArrays
{
    public partial class frmVetores : Form
    {
        public frmVetores()
        {
            InitializeComponent();
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            carregaVetores();
        }

        public void carregaVetores()
        {
            int tamanho = int.Parse(txtTamanho.Text);
            //criando um vetor ou array de linha
            string[] nome = new string[tamanho];

            //inserindo valores manualmente nos vetores
            for (int i = 0; i < nome.Length; i++)
            {
                nome[i] = txtInsiraNome.Text;
               ltbNomes.Text = nome[i];
            }
            

            //nome[0] = "Larissa";
            //nome[1] = "Edna";
            //nome[2] = "cauã";
            //nome[3] = "Pedro";
            //nome[4] = "giovanne";
            //nome[5] = "João";
            //nome[6] = "Leticia";
            //nome[7] = "Isabela";
            //nome[8] = "Eduardo";
            //nome[9] = "Hugo";

           

            ltbNomes.Items.Clear();
            //preenchendo o vetor ou array de linha
            for (int i = 0; i < nome.Length; i++)
            {
                ltbNomes.Items.Add(nome[i]);
            }

        }
    }
}
