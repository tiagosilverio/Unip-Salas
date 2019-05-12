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

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void preencheControlesCampus(Modelo.tb_campus campus)
        {            
            lblIdCampusResultado.Text = campus.idCampus.ToString();
            lblNomeCampusResultado.Text = campus.nomeCampus.ToString();
            lblNumeroCampusResultado.Text = campus.numeroCampus.ToString();
        }        

        private void dgvCampus_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int idCampus = Convert.ToInt32(dgvCampus.Rows[e.RowIndex].Cells[0].Value);
            Modelo.Controle controle = new Modelo.Controle();
            Modelo.tb_campus campus = controle.GetRegistroPorCodigo(idCampus);
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

        private void preencheControlesCurso(Modelo.tb_curso curso)
        {
            lblIdCursoResultado.Text = curso.idCurso.ToString();
            lblNomeCursoResultado.Text = curso.nomeCurso;
        }

        private void dgvCurso_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int idCurso = Convert.ToInt32(dgvCurso.Rows[e.RowIndex].Cells[0].Value);
            Modelo.Controle controle = new Modelo.Controle();
            Modelo.tb_curso curso = controle.GetCursoPorCodigo(idCurso);
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
    }
}
