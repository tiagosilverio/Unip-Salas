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
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbIdCampus.Text = "";
            txbNomeCampus.Text = "";
            mskNumero.Text = "";
        }

        private void frmCampus_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'unip_salaDataSet1.tb_campus'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_campusTableAdapter.Fill(this.unip_salaDataSet1.tb_campus);            
        }

        private void preencheControles(Modelo.tb_campus campus)
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
            preencheControles(campus);            
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
    }
}
