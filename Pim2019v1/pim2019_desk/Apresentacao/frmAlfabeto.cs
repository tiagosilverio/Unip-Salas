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
    public partial class frmAlfabeto : Form
    {
        public frmAlfabeto()
        {
            InitializeComponent();
            ExibirAlfabeto();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovoAlfabeto_Click(object sender, EventArgs e)
        {
            frmCadastrarAlfabeto cadastrarAlfabeto = new frmCadastrarAlfabeto();
            cadastrarAlfabeto.ShowDialog();
            ExibirAlfabeto();
        }

        private void btnEditarAlfabeto_Click(object sender, EventArgs e)
        {
            frmEditarAlfabeto editarAlfabeto = new frmEditarAlfabeto();
            editarAlfabeto.txbIdAlfabeto.Text = this.lblIdAlfabetoResultado.Text;
            editarAlfabeto.txbNomeAlfabeto.Text = this.lblNomeAlfabetoResultado.Text;
            editarAlfabeto.ShowDialog();
            ExibirAlfabeto();
        }

        private void ExibirAlfabeto()
        {
            this.tb_alfabetoTableAdapter.Fill(this.unip_salaDataSet5.tb_alfabeto);
        }
        private void frmAlfabeto_Load(object sender, EventArgs e)
        {
           
        }

        private void preencherControlesAlfabeto(Modelo.tb_alfabeto alfabeto)
        {
            lblIdAlfabetoResultado.Text = alfabeto.idAlfabeto.ToString();
            lblNomeAlfabetoResultado.Text = alfabeto.nomeAlfabeto.ToString();
        }

        private void dgvAlfabeto_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int idAlfabeto = Convert.ToInt32(dgvAlfabeto.Rows[e.RowIndex].Cells[0].Value);
            Modelo.Controle controle = new Modelo.Controle();
            Modelo.tb_alfabeto alfabeto = controle.GetAlfabetoPorCodigo(idAlfabeto);
            preencherControlesAlfabeto(alfabeto);
        }
    }
}
