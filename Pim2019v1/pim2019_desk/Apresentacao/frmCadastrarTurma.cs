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
    public partial class frmCadastrarTurma : Form
    {
        public frmCadastrarTurma()
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

        private void frmCadastrarTurma_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'unip_salaDataSet.tb_curso'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_cursoTableAdapter.Fill(this.unip_salaDataSet.tb_curso);
            // TODO: esta linha de código carrega dados na tabela 'unip_salaDataSet1.tb_campus'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_campusTableAdapter.Fill(this.unip_salaDataSet1.tb_campus);
            // TODO: esta linha de código carrega dados na tabela 'cmbAlfabeto1.tb_alfabeto'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_alfabetoTableAdapter.Fill(this.cmbAlfabeto1.tb_alfabeto);
            // TODO: esta linha de código carrega dados na tabela 'unip_salaDataSet9.tb_sigla'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_siglaTableAdapter.Fill(this.unip_salaDataSet9.tb_sigla);

        }

        private void btnCadastrarTurma_Click(object sender, EventArgs e)
        {
            int idSigla = Convert.ToInt32(cmbSigla.SelectedValue);
            int idAlfabeto = Convert.ToInt32(cmbAlfabeto.SelectedValue);
            int idCampus = Convert.ToInt32(cmbCampus.SelectedValue);
            int idCurso = Convert.ToInt32(cmbCurso.SelectedValue);

            string rdb;

            if (rdb1.Checked)
            {
                this.rdb = "1";
            }

            if (rdb2.Checked)
            {
                rdb = "2";
            }

            List<String> dadosTurma = new List<string>();
            dadosTurma.Add("0");
            dadosTurma.Add(Convert.ToString(idSigla));
            dadosTurma.Add(Convert.ToString(idAlfabeto));
            dadosTurma.Add(Convert.ToString(idCampus));
            dadosTurma.Add(Convert.ToString(idCurso));
            dadosTurma.Add(txbAnoInicio.Text);
            dadosTurma.Add(rdb);
            Modelo.Controle controle = new Modelo.Controle();
            controle.CadastrarTurma(dadosTurma);
            MessageBox.Show(controle.mensagem, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //txbNumeroSala.Text = "";
            //txbCapacidade.Text = "";
            //cmbAlfabeto.Text = "";
            //cmbTipoSala.Text = "";
            //cmbAndar.Text = "";
        }
    }
}
