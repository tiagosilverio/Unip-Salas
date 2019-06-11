using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pim2019_desk.Modelo;

namespace pim2019_desk.Dal
{
    interface intSalaDAO
    {
        void CadastrarSala(tb_sala sala);
        tb_sala GetSalaPorCodigo(int codigo);        
        void EditarSala(tb_sala sala);
        void ExcluirSala(tb_sala sala);
    }
}
