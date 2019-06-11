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
    public partial class frmEditarAndar : Form
    {
        public frmEditarAndar()
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

        private void btnEditarAndar_Click(object sender, EventArgs e)
        {
            List<String> dadosAndar = new List<String>();
            dadosAndar.Add(txbIdAndar.Text);
            dadosAndar.Add(txbAndar.Text);
            Modelo.Controle controle = new Modelo.Controle();
            controle.EditarAndar(dadosAndar);
            MessageBox.Show(controle.mensagem, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txbIdAndar.Text = "";
            txbAndar.Text = "";
        }

        private void btnExluirAndar_Click(object sender, EventArgs e)
        {
            List<String> dadosAndar = new List<String>();
            dadosAndar.Add(txbIdAndar.Text);
            dadosAndar.Add(txbAndar.Text);
            Modelo.Controle controle = new Modelo.Controle();

            DialogResult result = MessageBox.Show("Deseja realmente excluir?",
                "Alerta de exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                controle.ExcluirAndar(dadosAndar);
                MessageBox.Show(controle.mensagem, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbIdAndar.Text = "";
                txbAndar.Text = "";
            }
        }
    }
}
