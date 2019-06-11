using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pim2019_desk.Modelo;

namespace pim2019_desk.Dal
{
    interface intSiglaDAO
    {
        void CadastrarSigla(tb_sigla sigla);
        tb_sigla GetSiglaPorCodigo(int codigo);
        void EditarSigla(tb_sigla sigla);
        void ExcluirSigla(tb_sigla sigla);
    }
}
