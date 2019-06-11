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
    public partial class frmCadastrarAndar : Form
    {
        public frmCadastrarAndar()
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

        private void btnCadastrarAndar_Click(object sender, EventArgs e)
        {
            List<String> dadosAndar = new List<string>();
            dadosAndar.Add("0");
            dadosAndar.Add(txbAndar.Text);
            Modelo.Controle controle = new Modelo.Controle();
            controle.CadastrarAndar(dadosAndar);
            MessageBox.Show(controle.mensagem, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txbAndar.Text = "";
        }
    }
}
