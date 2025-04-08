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
    public partial class frmExecutaPessoa : Form
    {
        public frmExecutaPessoa()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Pessoa ps = new Pessoa();
            
            ps.setNome(txtNome.Text);
            lblMostrarNome.Text = ps.getNome();

            ps.setCPF(mskbCPF.Text);
            lblMostrarCPF.Text = ps.getCPF();

            ps.setEmail(txtEmail.Text);
            lblMostrarEmail.Text = ps.getEmail();

            ps.setTelefone (mskbTelefone.Text);
            lblMostrarTelefone.Text = ps.getTelefone();

            ps.setIdade (Convert.ToInt32(txtIdade.Text));
            lblMostrarIdade.Text = ps.getIdade().ToString();

        }
    }
}
