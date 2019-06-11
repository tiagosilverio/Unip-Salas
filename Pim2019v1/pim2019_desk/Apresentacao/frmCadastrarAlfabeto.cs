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
    public partial class frmCadastrarAlfabeto : Form
    {
        public frmCadastrarAlfabeto()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrarAlfabeto_Click(object sender, EventArgs e)
        {
            List<String> dadosAlfabeto = new List<string>();
            dadosAlfabeto.Add("0");
            dadosAlfabeto.Add(txbAlfabeto.Text);
            Modelo.Controle controle = new Modelo.Controle();
            controle.CadastrarAlfabeto(dadosAlfabeto);
            MessageBox.Show(controle.mensagem, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txbAlfabeto.Text = "";
        }
    }
}
