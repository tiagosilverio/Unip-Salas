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
    public partial class frmCadastrarTipoSala : Form
    {
        public frmCadastrarTipoSala()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            List<String> dadosTipo = new List<string>();
            dadosTipo.Add("0");
            dadosTipo.Add(txbTipoSala.Text);            
            Modelo.Controle controle = new Modelo.Controle();
            controle.CadastrarTipoSala(dadosTipo);
            MessageBox.Show(controle.mensagem, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txbTipoSala.Text = "";            
        }        
    }
}
