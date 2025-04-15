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
    public partial class frmVetornomes : Form
    {
        public frmVetornomes()
        {
            InitializeComponent();
        }

        private void btnNomes_Click(object sender, EventArgs e)
        {
            string [] nomes = new string[1];
            
            for (int i = 0; i < nomes.Length; i++)
            {
                nomes[i] = txtNomes.Text;
            }
        }
    }
}
