using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pim2019_desk.Apresentacao
{
    public partial class frmCadastrarSigla : Form
    {
        public frmCadastrarSigla()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrarSigla_Click(object sender, EventArgs e)
        {
            List<String> dadosSigla = new List<string>();
            dadosSigla.Add("0");
            dadosSigla.Add(txbSigla.Text);
            Modelo.Controle controle = new Modelo.Controle();
            controle.CadastrarSigla(dadosSigla);
            MessageBox.Show(controle.mensagem, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txbSigla.Text = "";
        }
    }
}
