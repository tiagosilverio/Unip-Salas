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
    public partial class frmAlfabeto : Form
    {
        public frmAlfabeto()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovoAlfabeto_Click(object sender, EventArgs e)
        {
            frmCadastrarAlfabeto cadastrarAlfabeto = new frmCadastrarAlfabeto();
            cadastrarAlfabeto.ShowDialog();
        }

        private void btnEditarAlfabeto_Click(object sender, EventArgs e)
        {
            frmEditarAlfabeto editarAlfabeto = new frmEditarAlfabeto();
            editarAlfabeto.ShowDialog();
        }
    }
}
