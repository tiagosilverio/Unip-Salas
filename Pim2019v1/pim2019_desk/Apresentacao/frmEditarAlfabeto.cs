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
    public partial class frmEditarAlfabeto : Form
    {
        public frmEditarAlfabeto()
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

        private void btnEditarAlfabeto_Click(object sender, EventArgs e)
        {
            List<String> dadosAlfabeto = new List<String>();
            dadosAlfabeto.Add(txbIdAlfabeto.Text);
            dadosAlfabeto.Add(txbNomeAlfabeto.Text);
            Modelo.Controle controle = new Modelo.Controle();
            controle.EditarAlfabeto(dadosAlfabeto);
            MessageBox.Show(controle.mensagem, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txbIdAlfabeto.Text = "";
            txbNomeAlfabeto.Text = "";
        }

        private void btnExcluirAlfabeto_Click(object sender, EventArgs e)
        {
            List<String> dadosAlfabeto = new List<String>();
            dadosAlfabeto.Add(txbIdAlfabeto.Text);
            dadosAlfabeto.Add(txbNomeAlfabeto.Text);
            Modelo.Controle controle = new Modelo.Controle();

            DialogResult result = MessageBox.Show("Deseja realmente excluir?",
                "Alerta de exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                controle.ExcluirAlfabeto(dadosAlfabeto);
                MessageBox.Show(controle.mensagem, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbIdAlfabeto.Text = "";
                txbNomeAlfabeto.Text = "";
            }
        }
    }
}
