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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            List<String> dadosCampus = new List<string>();
            dadosCampus.Add("0");
            dadosCampus.Add(mskNumero.Text);
            dadosCampus.Add(txbNomeCampus.Text);
            Modelo.Controle controle = new Modelo.Controle();
            controle.CadastrarCampus(dadosCampus);
            MessageBox.Show(controle.mensagem, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.tb_campusTableAdapter.Fill(this.unip_salaDataSet1.tb_campus);
            txbIdCampus.Text = "";
            txbNomeCampus.Text = "";
            mskNumero.Text = "";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbIdCampus.Text = "";
            txbNomeCampus.Text = "";
            mskNumero.Text = "";
        }

        private void frmCampus_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'unip_salaDataSet3.tb_aluno'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_alunoTableAdapter.Fill(this.unip_salaDataSet3.tb_aluno);
            txbIdAluno.Text = "";
            txbRaAluno.Text = "";
            txbNomeAluno.Text = "";
            rdbMatriculado.Checked = false;
            rdbNaoMatriculado.Checked = false;

            // TODO: esta linha de código carrega dados na tabela 'unip_salaDataSet2.tb_curso'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_cursoTableAdapter1.Fill(this.unip_salaDataSet2.tb_curso);
            txbIdCurso.Text = "";
            txbNomeCurso.Text = "";

            // TODO: esta linha de código carrega dados na tabela 'unip_salaDataSet1.tb_campus'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_campusTableAdapter.Fill(this.unip_salaDataSet1.tb_campus);
            txbIdCampus.Text = "";
            txbNomeCampus.Text = "";
            mskNumero.Text = "";
            
        }

        private void preencheControlesCampus(Modelo.tb_campus campus)
        {
            txbIdCampus.Text = campus.idCampus.ToString();
            txbNomeCampus.Text = campus.nomeCampus;
            mskNumero.Text = campus.numeroCampus.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCampus_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int idCampus = Convert.ToInt32(dgvCampus.Rows[e.RowIndex].Cells[0].Value);
            Modelo.Controle controle = new Modelo.Controle();
            Modelo.tb_campus campus = controle.GetRegistroPorCodigo(idCampus);
            preencheControlesCampus(campus);            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            List<String> dadosCampus = new List<string>();
            dadosCampus.Add(txbIdCampus.Text);
            dadosCampus.Add(mskNumero.Text);
            dadosCampus.Add(txbNomeCampus.Text);
            Modelo.Controle controle = new Modelo.Controle();
            controle.EditarCampus(dadosCampus);
            MessageBox.Show(controle.mensagem, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.tb_campusTableAdapter.Fill(this.unip_salaDataSet1.tb_campus);
            txbIdCampus.Text = "";
            txbNomeCampus.Text = "";
            mskNumero.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txbIdCampus.Text = "";
            txbNomeCampus.Text = "";
            mskNumero.Text = "";
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            List<String> dadosCampus = new List<string>();
            dadosCampus.Add(txbIdCampus.Text);
            dadosCampus.Add(mskNumero.Text);
            dadosCampus.Add(txbNomeCampus.Text);
            Modelo.Controle controle = new Modelo.Controle();
            
            DialogResult result = MessageBox.Show("Deseja realmente excluir?",
                "Alerta de exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                controle.ExcluirCampus(dadosCampus);
                MessageBox.Show(controle.mensagem, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.tb_campusTableAdapter.Fill(this.unip_salaDataSet1.tb_campus);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCadastrarCurso_Click(object sender, EventArgs e)
        {
            List<String> dadosCurso = new List<string>();
            dadosCurso.Add("0");
            dadosCurso.Add(txbNomeCurso.Text);
            Modelo.Controle controle = new Modelo.Controle();
            controle.CadastrarCurso(dadosCurso);
            MessageBox.Show(controle.mensagem, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.tb_cursoTableAdapter1.Fill(this.unip_salaDataSet2.tb_curso);
            txbIdCurso.Text = "";
            txbNomeCurso.Text = "";
        }

        private void btnEditarCurso_Click(object sender, EventArgs e)
        {
            List<String> dadosCurso = new List<string>();
            dadosCurso.Add(txbIdCurso.Text);
            dadosCurso.Add(txbNomeCurso.Text);            
            Modelo.Controle controle = new Modelo.Controle();
            controle.EditarCurso(dadosCurso);
            MessageBox.Show(controle.mensagem, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.tb_cursoTableAdapter1.Fill(this.unip_salaDataSet2.tb_curso);
            txbIdCurso.Text = "";
            txbNomeCurso.Text = "";            
        }

        private void preencheControlesCurso(Modelo.tb_curso curso)
        {
            txbIdCurso.Text = curso.idCurso.ToString();
            txbNomeCurso.Text = curso.nomeCurso;
        }

        private void dgvCurso_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int idCurso = Convert.ToInt32(dgvCurso.Rows[e.RowIndex].Cells[0].Value);
            Modelo.Controle controle = new Modelo.Controle();
            Modelo.tb_curso curso = controle.GetCursoPorCodigo(idCurso);
            preencheControlesCurso(curso);
        }

        private void btnLimparCurso_Click(object sender, EventArgs e)
        {
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
            }
            this.tb_cursoTableAdapter1.Fill(this.unip_salaDataSet2.tb_curso);
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
            this.tb_alunoTableAdapter.Fill(this.unip_salaDataSet3.tb_aluno);
            txbIdAluno.Text = "";
            txbRaAluno.Text = "";
            txbNomeAluno.Text = "";
            rdbMatriculado.Checked = false;
            rdbNaoMatriculado.Checked = false;
        }

        private void preencheControlesAluno(Modelo.tb_aluno aluno)
        {
            txbIdAluno.Text = aluno.idAluno.ToString();
            txbRaAluno.Text = aluno.raAluno;
            txbNomeAluno.Text = aluno.nomeAluno;
            if (aluno.statusAluno == true)
            {
                rdbMatriculado.Checked = true;
            }
            else
            {
                rdbNaoMatriculado.Checked = true;
            }                
        }

        private void dgvAluno_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int idAluno = Convert.ToInt32(dgvAluno.Rows[e.RowIndex].Cells[0].Value);
            Modelo.Controle controle = new Modelo.Controle();
            Modelo.tb_aluno aluno = controle.GetAlunoPorCodigo(idAluno);
            preencheControlesAluno(aluno);
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
            dadosAluno.Add(txbIdAluno.Text);
            dadosAluno.Add(txbRaAluno.Text);
            dadosAluno.Add(txbNomeAluno.Text);
            dadosAluno.Add(Convert.ToString(statusAluno));
            Modelo.Controle controle = new Modelo.Controle();
            controle.EditarAluno(dadosAluno);
            MessageBox.Show(controle.mensagem, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.tb_alunoTableAdapter.Fill(this.unip_salaDataSet3.tb_aluno);
            txbIdAluno.Text = "";
            txbRaAluno.Text = "";
            txbNomeAluno.Text = "";
            rdbMatriculado.Checked = false;
            rdbNaoMatriculado.Checked = false;
        }

        private void btnLimparAluno_Click(object sender, EventArgs e)
        {
            txbIdAluno.Text = "";
            txbRaAluno.Text = "";
            txbNomeAluno.Text = "";
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
            dadosAluno.Add(txbIdAluno.Text);
            dadosAluno.Add(txbRaAluno.Text);
            dadosAluno.Add(txbNomeAluno.Text);
            dadosAluno.Add(Convert.ToString(statusAluno));
            Modelo.Controle controle = new Modelo.Controle();

            DialogResult result = MessageBox.Show("Deseja realmente excluir?",
                "Alerta de exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                controle.ExcluirAluno(dadosAluno);
                MessageBox.Show(controle.mensagem, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.tb_alunoTableAdapter.Fill(this.unip_salaDataSet3.tb_aluno);
                txbIdAluno.Text = "";
                txbRaAluno.Text = "";
                txbNomeAluno.Text = "";
                rdbMatriculado.Checked = false;
                rdbNaoMatriculado.Checked = false;
            }
        }
    }
}
