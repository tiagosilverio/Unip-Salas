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
    public partial class frmEditarTipoSala : Form
    {
        public frmEditarTipoSala()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditarTipoSala_Click(object sender, EventArgs e)
        {
            List<String> dadosTipo = new List<String>();
            dadosTipo.Add(txbIdTipoSala.Text);
            dadosTipo.Add(txbTipoSala.Text);
            Modelo.Controle controle = new Modelo.Controle();
            controle.EditarTipoSala(dadosTipo);
            MessageBox.Show(controle.mensagem, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txbIdTipoSala.Text = "";
            txbTipoSala.Text = "";
        }

        private void btnExcluirTipoSala_Click(object sender, EventArgs e)
        {
            List<String> dadosTipo = new List<String>();
            dadosTipo.Add(txbIdTipoSala.Text);
            dadosTipo.Add(txbTipoSala.Text);
            Modelo.Controle controle = new Modelo.Controle();

            DialogResult result = MessageBox.Show("Deseja realmente excluir?",
                "Alerta de exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                controle.ExcluirTipoSala(dadosTipo);
                MessageBox.Show(controle.mensagem, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbIdTipoSala.Text = "";
                txbTipoSala.Text = "";
            }
        }
    }
}
