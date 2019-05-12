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
    public partial class frmEditarCurso : Form
    {
        public frmEditarCurso()
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

        private void btnEditarCurso_Click(object sender, EventArgs e)
        {
            List<String> dadosCurso = new List<string>();
            dadosCurso.Add(txbIdCurso.Text);
            dadosCurso.Add(txbNomeCurso.Text);
            Modelo.Controle controle = new Modelo.Controle();
            controle.EditarCurso(dadosCurso);
            MessageBox.Show(controle.mensagem, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);            
            txbIdCurso.Text = "";
            txbNomeCurso.Text = "";
        }

        private void btnExcluirCurso_Click(object sender, EventArgs e)
        {
            List<String> dadosCurso = new List<string>();
            dadosCurso.Add(txbIdCurso.Text);
            dadosCurso.Add(txbNomeCurso.Text);
            Modelo.Controle controle = new Modelo.Controle();

            DialogResult result = MessageBox.Show("Deseja realmente excluir?",
                "Alerta de exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                controle.ExcluirCurso(dadosCurso);
                MessageBox.Show(controle.mensagem, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbIdCurso.Text = "";
                txbNomeCurso.Text = "";
            }
        }
    }
}
