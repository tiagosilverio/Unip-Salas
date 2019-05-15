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
    public partial class frmTipoSala : Form
    {
        public frmTipoSala()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovoTipo_Click(object sender, EventArgs e)
        {
            frmCadastrarTipoSala cadastrarTipoSala = new frmCadastrarTipoSala();
            cadastrarTipoSala.ShowDialog();
        }

        private void btnEditarTipo_Click(object sender, EventArgs e)
        {
            frmEditarTipoSala editarTipoSala = new frmEditarTipoSala();
            editarTipoSala.ShowDialog();
        }
    }
}
