using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pim2019_desk.Modelo;

namespace pim2019_desk.Dal
{
    interface intCursoDAO
    {
        void CadastrarCurso(tb_curso curso);
        tb_curso GetCursoPorCodigo(int codigo);
        void EditarCurso(tb_curso curso);
        void ExcluirCurso(tb_curso curso);
    }
}

