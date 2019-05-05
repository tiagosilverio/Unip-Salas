using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pim2019_desk.Modelo;

namespace pim2019_desk.Dal
{
    interface intCampusDAO
    {
        void CadastrarCampus(tb_campus campus);
        tb_campus GetRegistroPorCodigo(int codigo);
        void EditarCampus(tb_campus campus);
        void ExcluirCampus(tb_campus campus);
    }
}
