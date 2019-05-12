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
    public partial class frmEditarAluno : Form
    {
        public frmEditarAluno()
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

        private void btnEditarAluno_Click(object sender, EventArgs e)
        {
            bool statusAluno = false;

            if (rdbMatriculado.Checked)
            {
                statusAluno = true;
            }

            if (rdbNaoMatriculado.Checked)
            {
                statusAluno = false;
            }

            List<String> dadosAluno = new List<string>();
            dadosAluno.Add(txbIdAlunoEditar.Text);
            dadosAluno.Add(txbRaAlunoEditar.Text);
            dadosAluno.Add(txbNomeAlunoEditar.Text);
            dadosAluno.Add(Convert.ToString(statusAluno));
            Modelo.Controle controle = new Modelo.Controle();
            controle.EditarAluno(dadosAluno);
            MessageBox.Show(controle.mensagem, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);            
            txbIdAlunoEditar.Text = "";
            txbRaAlunoEditar.Text = "";
            txbNomeAlunoEditar.Text = "";
            rdbMatriculado.Checked = false;
            rdbNaoMatriculado.Checked = false;
        }

        private void btnExcluirAluno_Click(object sender, EventArgs e)
        {
            bool statusAluno = false;

            if (rdbMatriculado.Checked)
            {
                statusAluno = true;
            }

            if (rdbNaoMatriculado.Checked)
            {
                statusAluno = false;
            }

            List<String> dadosAluno = new List<string>();
            dadosAluno.Add(txbIdAlunoEditar.Text);
            dadosAluno.Add(txbRaAlunoEditar.Text);
            dadosAluno.Add(txbNomeAlunoEditar.Text);
            dadosAluno.Add(Convert.ToString(statusAluno));
            Modelo.Controle controle = new Modelo.Controle();

            DialogResult result = MessageBox.Show("Deseja realmente excluir?",
                "Alerta de exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                controle.ExcluirAluno(dadosAluno);
                MessageBox.Show(controle.mensagem, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);                
                txbIdAlunoEditar.Text = "";
                txbRaAlunoEditar.Text = "";
                txbNomeAlunoEditar.Text = "";
                rdbMatriculado.Checked = false;
                rdbNaoMatriculado.Checked = false;
            }
        }
    }
}
