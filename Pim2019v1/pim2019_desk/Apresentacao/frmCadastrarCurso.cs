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
    public partial class frmCadastrarCurso : Form
    {
        public frmCadastrarCurso()
        {
            InitializeComponent();
        }

        private void btnCadastrarCurso_Click(object sender, EventArgs e)
        {
            List<String> dadosCurso = new List<string>();
            dadosCurso.Add("0");
            dadosCurso.Add(txbNomeCurso.Text);
            Modelo.Controle controle = new Modelo.Controle();
            controle.CadastrarCurso(dadosCurso);
            MessageBox.Show(controle.mensagem, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txbNomeCurso.Text = "";            
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
