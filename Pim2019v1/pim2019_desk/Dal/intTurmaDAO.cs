using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pim2019_desk.Modelo;

namespace pim2019_desk.Dal
{
    interface intTurmaDAO
    {
        void CadastrarTurma(tb_turma turma);
        tb_turma GetTurmaPorCodigo(int codigo);
        void EditarTurma(tb_turma turma);
        void ExcluirTurma(tb_turma turma);
    }
}

