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
    public partial class frmEditarCampus : Form
    {
        public frmEditarCampus()
        {
            InitializeComponent();
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {           
            this.Close();
        }

        public void InicializarForm()
        {            
            
        }

        private void btnEditarCampus_Click(object sender, EventArgs e)
        {
            List<String> dadosCampus = new List<string>();
            dadosCampus.Add(txbIdCampusEditar.Text);
            dadosCampus.Add(txbNumeroCampusEditar.Text);
            dadosCampus.Add(txbNomeCampusEditar.Text);
            Modelo.Controle controle = new Modelo.Controle();
            controle.EditarCampus(dadosCampus);
            MessageBox.Show(controle.mensagem, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);            
            txbIdCampusEditar.Text = "";
            txbNomeCampusEditar.Text = "";
            txbNumeroCampusEditar.Text = "";
        }

        private void btnExcluirCampus_Click(object sender, EventArgs e)
        {
            List<String> dadosCampus = new List<string>();
            dadosCampus.Add(txbIdCampusEditar.Text);
            dadosCampus.Add(txbNumeroCampusEditar.Text);
            dadosCampus.Add(txbNomeCampusEditar.Text);
            Modelo.Controle controle = new Modelo.Controle();

            DialogResult result = MessageBox.Show("Deseja realmente excluir?",
                "Alerta de exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                controle.ExcluirCampus(dadosCampus);
                MessageBox.Show(controle.mensagem, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }   
            
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
