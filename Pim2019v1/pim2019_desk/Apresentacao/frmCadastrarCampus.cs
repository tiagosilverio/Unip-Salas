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
    public partial class frmCadastrarCampus : Form
    {
        public frmCadastrarCampus()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {            
            this.Close();            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            List<String> dadosCampus = new List<string>();
            dadosCampus.Add("0");
            dadosCampus.Add(txbNumeroCampus.Text);
            dadosCampus.Add(txbNomeCampus.Text);
            Modelo.Controle controle = new Modelo.Controle();
            controle.CadastrarCampus(dadosCampus);
            MessageBox.Show(controle.mensagem, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);                        
            txbNomeCampus.Text = "";
            txbNumeroCampus.Text = "";
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
