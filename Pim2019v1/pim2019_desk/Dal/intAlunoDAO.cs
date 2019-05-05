using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pim2019_desk.Modelo;

namespace pim2019_desk.Dal
{
    interface intAlunoDAO
    {
        void CadastrarAluno(tb_aluno aluno);
        tb_aluno GetAlunoPorCodigo(int codigo);
        void EditarAluno(tb_aluno aluno);
        void ExcluirAluno(tb_aluno aluno);
    }
}
