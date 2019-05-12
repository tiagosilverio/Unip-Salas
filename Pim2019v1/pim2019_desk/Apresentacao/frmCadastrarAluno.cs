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
    public partial class frmCadastrarAluno : Form
    {
        public frmCadastrarAluno()
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

        private void btnCadastrarAluno_Click(object sender, EventArgs e)
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
            dadosAluno.Add("0");
            dadosAluno.Add(txbRaAluno.Text);
            dadosAluno.Add(txbNomeAluno.Text);
            dadosAluno.Add(Convert.ToString(statusAluno));
            Modelo.Controle controle = new Modelo.Controle();
            controle.CadastrarAluno(dadosAluno);
            MessageBox.Show(controle.mensagem, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);            
            txbRaAluno.Text = "";
            txbNomeAluno.Text = "";
        }
    }
}
