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
    public partial class frmCadastrarSala : Form
    {
        public frmCadastrarSala()
        {
            InitializeComponent();
            //ListarAlfabeto();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListarAlfabeto()
        {
            try
            {
                Modelo.Controle controle = new Modelo.Controle();
                cmbAlfabeto.DataSource = controle.ListarAlfabeto();
                cmbAlfabeto.ValueMember = "idAlfabeto";
                cmbAlfabeto.DisplayMember = "nomeAlfabeto";
            }   
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCadastrarSala_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cmbAlfabeto1.tb_alfabeto'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_alfabetoTableAdapter.Fill(this.cmbAlfabeto1.tb_alfabeto);
            // TODO: esta linha de código carrega dados na tabela 'cmbAndar1.tb_andar'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_andarTableAdapter.Fill(this.cmbAndar1.tb_andar);
            // TODO: esta linha de código carrega dados na tabela 'cmbTipoSala1.tb_tipo_sala'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_tipo_salaTableAdapter.Fill(this.cmbTipoSala1.tb_tipo_sala);

        }

        private void btnCadastrarSala_Click(object sender, EventArgs e)
        {
            int idAlfabeto = Convert.ToInt32(cmbAlfabeto.SelectedValue);
            int idTipoSala = Convert.ToInt32(cmbTipoSala.SelectedValue);
            int idAndar = Convert.ToInt32(cmbAndar.SelectedValue);

            List<String> dadosSala = new List<string>();
            dadosSala.Add("0");
            dadosSala.Add(txbNumeroSala.Text);
            dadosSala.Add(txbCapacidade.Text);
            dadosSala.Add(Convert.ToString(idAlfabeto));
            dadosSala.Add(Convert.ToString(idTipoSala));
            dadosSala.Add(Convert.ToString(idAndar));
            Modelo.Controle controle = new Modelo.Controle();
            controle.CadastrarSala(dadosSala);
            MessageBox.Show(controle.mensagem, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txbNumeroSala.Text = "";
            txbCapacidade.Text = "";
            cmbAlfabeto.Text = "";
            cmbTipoSala.Text = "";
            cmbAndar.Text = "";
        }
    }
}
