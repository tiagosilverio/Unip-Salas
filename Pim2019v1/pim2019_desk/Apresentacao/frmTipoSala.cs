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
    public partial class frmTipoSala : Form
    {
        public frmTipoSala()
        {
            InitializeComponent();
            ExibirTipoSala();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovoTipo_Click(object sender, EventArgs e)
        {
            frmCadastrarTipoSala cadastrarTipoSala = new frmCadastrarTipoSala();
            cadastrarTipoSala.ShowDialog();
            ExibirTipoSala();
        }

        private void btnEditarTipo_Click(object sender, EventArgs e)
        {
            frmEditarTipoSala editarTipoSala = new frmEditarTipoSala();
            editarTipoSala.txbIdTipoSala.Text = this.lblIdTipoSalaResultado.Text;
            editarTipoSala.txbTipoSala.Text = this.lblNomeTipoSalaResultado.Text;
            editarTipoSala.ShowDialog();
            ExibirTipoSala();
        }

        private void ExibirTipoSala()
        {
            this.tb_tipo_salaTableAdapter.Fill(this.unip_salaDataSet7.tb_tipo_sala);
        }

        private void preencherControlesTipoSala(Modelo.tb_tipo_sala tipo)
        {
            lblIdTipoSalaResultado.Text = tipo.idTipoSala.ToString();
            lblNomeTipoSalaResultado.Text = tipo.nomeTipoSala.ToString();
        }

        private void frmTipoSala_Load(object sender, EventArgs e)
        {            

        }

        private void dgvTipoSala_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int idTipoSala = Convert.ToInt32(dgvTipoSala.Rows[e.RowIndex].Cells[0].Value);
            Modelo.Controle controle = new Modelo.Controle();
            Modelo.tb_tipo_sala tipo = controle.GetTipoSalaPorCodigo(idTipoSala);
            preencherControlesTipoSala(tipo);
        }
    }
}
