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
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditarSigla_Click(object sender, EventArgs e)
        {
            frmEditarSigla editarSigla = new frmEditarSigla();
            editarSigla.ShowDialog();
        }

        private void btnNovaSigla_Click(object sender, EventArgs e)
        {
            frmCadastrarSigla cadastrarSigla = new frmCadastrarSigla();
            cadastrarSigla.ShowDialog();
        }
    }
}
