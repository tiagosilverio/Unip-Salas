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
    public partial class frmEditarSigla : Form
    {
        public frmEditarSigla()
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

        private void btnEditarSigla_Click(object sender, EventArgs e)
        {
            List<String> dadosSigla = new List<string>();
            dadosSigla.Add(txbIdSigla.Text);
            dadosSigla.Add(txbNomeSigla.Text);
            Modelo.Controle controle = new Modelo.Controle();
            controle.EditarSigla(dadosSigla);
            MessageBox.Show(controle.mensagem, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txbIdSigla.Text = "";
            txbNomeSigla.Text = "";
        }

        private void btnExcluirSigla_Click(object sender, EventArgs e)
        {
            List<String> dadosSigla = new List<string>();
            dadosSigla.Add(txbIdSigla.Text);
            dadosSigla.Add(txbNomeSigla.Text);
            Modelo.Controle controle = new Modelo.Controle();

            DialogResult result = MessageBox.Show("Deseja realmente excluir?",
                "Alerta de exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                controle.ExcluirSigla(dadosSigla);
                MessageBox.Show(controle.mensagem, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbIdSigla.Text = "";
                txbNomeSigla.Text = "";
            }
        }
    }
}
