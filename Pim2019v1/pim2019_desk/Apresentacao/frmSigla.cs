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
    public partial class frmSigla : Form
    {
        public frmSigla()
        {
            InitializeComponent();
            ExibirSigla();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditarSigla_Click(object sender, EventArgs e)
        {
            frmEditarSigla editarSigla = new frmEditarSigla();
            editarSigla.txbIdSigla.Text = this.lblIdSiglaResultado.Text;
            editarSigla.txbNomeSigla.Text = this.lblNomeSiglaResultado.Text;
            editarSigla.ShowDialog();
            ExibirSigla();
        }

        private void btnNovaSigla_Click(object sender, EventArgs e)
        {
            frmCadastrarSigla cadastrarSigla = new frmCadastrarSigla();
            cadastrarSigla.ShowDialog();
            ExibirSigla();
        }

        private void preencherControlesSigla(Modelo.tb_sigla sigla)
        {
            lblIdSiglaResultado.Text = sigla.idSigla.ToString();
            lblNomeSiglaResultado.Text = sigla.nomeSigla.ToString();
        }

        private void ExibirSigla()
        {
            this.tb_siglaTableAdapter.Fill(this.unip_salaDataSet9.tb_sigla);
        }

        private void frmSigla_Load(object sender, EventArgs e)
        {

        }

        private void dgvSigla_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int idSigla = Convert.ToInt32(dgvSigla.Rows[e.RowIndex].Cells[0].Value);
            Modelo.Controle controle = new Modelo.Controle();
            Modelo.tb_sigla sigla = controle.GetSiglaPorCodigo(idSigla);
            preencherControlesSigla(sigla);
        }
    }
}
