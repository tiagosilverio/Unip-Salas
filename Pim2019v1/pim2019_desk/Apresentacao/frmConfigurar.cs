using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pim2019_desk.Modelo;

namespace pim2019_desk.Apresentacao
{
    public partial class frmConfigurar : Form
    {
        public frmConfigurar()
        {
            InitializeComponent();
            ExibirCampus();
            ExibirCurso();
            ExibirSala();            
        }

        private void frmCampus_Load(object sender, EventArgs e)
        {

        }

        private void ExibirCurso()
        {
            this.tb_cursoTableAdapter1.Fill(this.unip_salaDataSet2.tb_curso);
        }

        private void ExibirCampus()
        {
            this.tb_campusTableAdapter.Fill(this.unip_salaDataSet1.tb_campus);
        }

        private void ExibirSala()
        {
            this.dataTable1TableAdapter.Fill(this.listarSalaxsd.DataTable1);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void preencheControlesCampus(tb_campus campus)
        {            
            lblIdCampusResultado.Text = campus.idCampus.ToString();
            lblNomeCampusResultado.Text = campus.nomeCampus.ToString();
            lblNumeroCampusResultado.Text = campus.numeroCampus.ToString();
        }        

        private void dgvCampus_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int idCampus = Convert.ToInt32(dgvCampus.Rows[e.RowIndex].Cells[0].Value);
            Controle controle = new Controle();
            tb_campus campus = controle.GetRegistroPorCodigo(idCampus);
            preencheControlesCampus(campus);            
        }

        private void btnCadastrarCampus_Click(object sender, EventArgs e)
        {
            frmCadastrarCampus cadastrarCampus = new frmCadastrarCampus();
            cadastrarCampus.ShowDialog();
            ExibirCampus();
        }

        private void btnEditarCampus_Click(object sender, EventArgs e)
        {
            frmEditarCampus editarCampus = new frmEditarCampus();
            editarCampus.txbIdCampusEditar.Text = this.lblIdCampusResultado.Text;
            editarCampus.txbNumeroCampusEditar.Text = this.lblNumeroCampusResultado.Text;
            editarCampus.txbNomeCampusEditar.Text = this.lblNomeCampusResultado.Text;
            editarCampus.ShowDialog();
            ExibirCampus();            
        }

        private void preencheControlesCurso(tb_curso curso)
        {
            lblIdCursoResultado.Text = curso.idCurso.ToString();
            lblNomeCursoResultado.Text = curso.nomeCurso;
        }

        private void dgvCurso_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int idCurso = Convert.ToInt32(dgvCurso.Rows[e.RowIndex].Cells[0].Value);
            Controle controle = new Controle();
            tb_curso curso = controle.GetCursoPorCodigo(idCurso);
            preencheControlesCurso(curso);
        }

        private void btnCadastrarCurso_Click(object sender, EventArgs e)
        {
            frmCadastrarCurso cadastrarCurso = new frmCadastrarCurso();
            cadastrarCurso.ShowDialog();
            ExibirCurso();
        }

        private void btnEditarCurso_Click(object sender, EventArgs e)
        {
            frmEditarCurso editarCurso = new frmEditarCurso();
            editarCurso.txbIdCurso.Text = this.lblIdCursoResultado.Text;
            editarCurso.txbNomeCurso.Text = this.lblNomeCursoResultado.Text;
            editarCurso.ShowDialog();
            ExibirCurso();            
        }

        private void tipoDeSalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTipoSala tipoSala = new frmTipoSala();
            tipoSala.ShowDialog();
        }

        private void andarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAndar andar = new frmAndar();
            andar.ShowDialog();
        }

        private void alfabetoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlfabeto alfabeto = new frmAlfabeto();
            alfabeto.ShowDialog();
        }

        private void preencheControlesSala(tb_sala sala)
        {
            lblIdSalaResultado.Text = sala.idSala.ToString();
            lblNumeroSalaResultado.Text = sala.numeroSala.ToString();
            lblCapacidadeResultado.Text = sala.capacidade.ToString();
            lblAlfabetoResultado.Text = sala.fkAlfabeto.ToString();
            lblTipoSalaResultado.Text = sala.fkTipoSala.ToString();
            lblAndarResultado.Text = sala.fkAndar.ToString();
        }

        private void btnEditarSala_Click(object sender, EventArgs e)
        {
            frmEditarSala editarSala = new frmEditarSala();
            editarSala.txbIdSala.Text = this.lblIdSalaResultado.Text;
            editarSala.txbNumeroSala.Text = this.lblNumeroSalaResultado.Text;
            editarSala.txbCapacidade.Text = this.lblCapacidadeResultado.Text;
            editarSala.cmbAlfabeto.Text = this.lblAlfabetoResultado.Text;
            editarSala.cmbTipoSala.Text = this.lblTipoSalaResultado.Text;
            editarSala.ShowDialog();
            ExibirSala();
        }

        private void ListarSala()
        {
            //try
            //{
            //    Controle controle = new Controle();
            //    dgvSala.DataSource = controle.ListarSala();
            //}
            //catch (Exception e)
            //{
            //    MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            
        }

        private void btnNovaSala_Click(object sender, EventArgs e)
        {
            frmCadastrarSala cadastrarSala = new frmCadastrarSala();
            cadastrarSala.ShowDialog();
            ExibirSala();
        }

        private void dgvSala_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //int idSala = Convert.ToInt32(dgvSala.Rows[e.RowIndex].Cells[0].FormattedValue);
            //Controle controle = new Controle();
            //tb_sala sala = controle.GetSalaPorCodigo(idSala);
            //preencheControlesSala(sala);

            string idSala = Convert.ToString(dgvSala.Rows[e.RowIndex].Cells[0].FormattedValue);
            string numeroSala = Convert.ToString(dgvSala.Rows[e.RowIndex].Cells[1].FormattedValue);
            string capacidade = Convert.ToString(dgvSala.Rows[e.RowIndex].Cells[2].FormattedValue);
            string bloco = Convert.ToString(dgvSala.Rows[e.RowIndex].Cells[3].FormattedValue);
            string tipo = Convert.ToString(dgvSala.Rows[e.RowIndex].Cells[4].FormattedValue);
            string andar = Convert.ToString(dgvSala.Rows[e.RowIndex].Cells[5].FormattedValue);

            lblIdSalaResultado.Text = idSala;
            lblNumeroSalaResultado.Text = numeroSala;
            lblCapacidadeResultado.Text = capacidade;
            lblAlfabetoResultado.Text = bloco;
            lblTipoSalaResultado.Text = tipo;
            lblAndarResultado.Text = andar;

        }

        private void dgvSala_SelectionChanged(object sender, EventArgs e)
        {
            
            
                
            
        }
    }
}
