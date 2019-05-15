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
    public partial class frmAndar : Form
    {
        public frmAndar()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditarAndar_Click(object sender, EventArgs e)
        {
            frmEditarAndar editarAndar = new frmEditarAndar();
            editarAndar.ShowDialog();
        }

        private void btnNovoAndar_Click(object sender, EventArgs e)
        {
            frmCadastrarAndar cadastrarAndar = new frmCadastrarAndar();
            cadastrarAndar.ShowDialog();
        }
    }
}
