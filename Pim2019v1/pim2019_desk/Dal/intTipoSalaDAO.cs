using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pim2019_desk.Modelo;

namespace pim2019_desk.Dal
{
    interface intTipoSalaDAO
    {
        void CadastrarTipoSala(tb_tipo_sala tipoSala);
        tb_tipo_sala GetTipoSalaPorCodigo(int codigo);
        void EditarTipoSala(tb_tipo_sala tipoSala);
        void ExcluirTipoSala(tb_tipo_sala tipoSala);
    }
}

