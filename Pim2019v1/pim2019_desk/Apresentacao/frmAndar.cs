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
    public partial class frmAndar : Form
    {
        public frmAndar()
        {
            InitializeComponent();
            ExibirAndar();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditarAndar_Click(object sender, EventArgs e)
        {
            frmEditarAndar editarAndar = new frmEditarAndar();
            editarAndar.txbIdAndar.Text = this.lblIdAndarResultado.Text;
            editarAndar.txbAndar.Text = this.lblNomeAndarResultado.Text;
            editarAndar.ShowDialog();
            ExibirAndar();
        }

        private void btnNovoAndar_Click(object sender, EventArgs e)
        {
            frmCadastrarAndar cadastrarAndar = new frmCadastrarAndar();
            cadastrarAndar.ShowDialog();
            ExibirAndar();
        }

        private void ExibirAndar()
        {
            this.tb_andarTableAdapter.Fill(this.unip_salaDataSet6.tb_andar);
        }
        private void frmAndar_Load(object sender, EventArgs e)
        {
           
        }

        private void preencherControlesAndar(Modelo.tb_andar andar)
        {
            lblIdAndarResultado.Text = andar.idAndar.ToString();
            lblNomeAndarResultado.Text = andar.nomeAndar.ToString();
        }

        private void dgvAndar_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int idAndar = Convert.ToInt32(dgvAndar.Rows[e.RowIndex].Cells[0].Value);
            Modelo.Controle controle = new Modelo.Controle();
            Modelo.tb_andar andar = controle.GetAndarPorCodigo(idAndar);
            preencherControlesAndar(andar);
        }
    }
}
