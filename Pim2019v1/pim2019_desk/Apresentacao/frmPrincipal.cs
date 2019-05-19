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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            ExibirAluno();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConfigurar_Click(object sender, EventArgs e)
        {
            frmConfigurar frmConfigurar = new frmConfigurar();
            frmConfigurar.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void ExibirAluno()
        {
            this.tb_alunoTableAdapter.Fill(this.unip_salaDataSet4.tb_aluno);
        }

        private void preencheControlesAluno(Modelo.tb_aluno aluno)
        {
            lblIdAlunoResultado.Text = aluno.idAluno.ToString();
            lblRaAlunoResultado.Text = aluno.raAluno;
            lblNomeAlunoResultado.Text = aluno.nomeAluno;
            if (aluno.statusAluno == true)
            {
                lblStatusAlunoResultado.Text = "Matriculado";
            }
            else
            {
                lblStatusAlunoResultado.Text = "Não Matriculado";
            }
        }

        private void dgvAlunos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int idAluno = Convert.ToInt32(dgvAlunos.Rows[e.RowIndex].Cells[0].Value);
            Modelo.Controle controle = new Modelo.Controle();
            Modelo.tb_aluno aluno = controle.GetAlunoPorCodigo(idAluno);
            preencheControlesAluno(aluno);
        }

        private void btnCadastrarAluno_Click(object sender, EventArgs e)
        {
            frmCadastrarAluno cadastrarAluno = new frmCadastrarAluno();
            cadastrarAluno.ShowDialog();
            ExibirAluno();
        }

        private void btnEditarAluno_Click(object sender, EventArgs e)
        {
            frmEditarAluno editarAluno = new frmEditarAluno();
            editarAluno.txbIdAlunoEditar.Text = this.lblIdAlunoResultado.Text;
            editarAluno.txbRaAlunoEditar.Text = this.lblRaAlunoResultado.Text;
            editarAluno.txbNomeAlunoEditar.Text = this.lblNomeAlunoResultado.Text;

            if(lblStatusAlunoResultado.Text == "Matriculado")
            {
                editarAluno.rdbMatriculado.Checked = true;
            }

            if (lblStatusAlunoResultado.Text == "Não Matriculado")
            {
                editarAluno.rdbNaoMatriculado.Checked = true;
            }
            editarAluno.ShowDialog();
            ExibirAluno();
        }

        private void siglaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSigla sigla = new frmSigla();
            sigla.ShowDialog();
        }

        private void btnEditarTurma_Click(object sender, EventArgs e)
        {
            frmEditarTurma editarTurma = new frmEditarTurma();
            editarTurma.ShowDialog();
        }

        private void btnNovaTurma_Click(object sender, EventArgs e)
        {
            frmCadastrarTurma cadastrarTurma = new frmCadastrarTurma();
            cadastrarTurma.ShowDialog();
        }

        private void btnNovaAula_Click(object sender, EventArgs e)
        {
            frmCadastrarAula cadastrarAula = new frmCadastrarAula();
            cadastrarAula.ShowDialog();
        }

        private void btnEditarAula_Click(object sender, EventArgs e)
        {
            frmEditarAula editarAula = new frmEditarAula();
            editarAula.ShowDialog();
        }
    }
}
