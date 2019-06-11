using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pim2019_desk.Modelo;

namespace pim2019_desk.Dal
{
    interface intAndarDAO
    {
        void CadastrarAndar(tb_andar andar);
        tb_andar GetAndarPorCodigo(int codigo);
        void EditarAndar(tb_andar andar);
        void ExcluirAndar(tb_andar andar);
    }
}
