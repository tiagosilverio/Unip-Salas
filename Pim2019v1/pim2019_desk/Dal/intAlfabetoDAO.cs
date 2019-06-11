using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pim2019_desk.Modelo;

namespace pim2019_desk.Dal
{
    interface intAlfabetoDAO
    {
        void CadastrarAlfabeto(tb_alfabeto alfabeto);
        tb_alfabeto GetAlfabetoPorCodigo(int codigo);
        void EditarAfabeto(tb_alfabeto alfabeto);
        void ExcluirAlfabeto(tb_alfabeto alfabeto);
        List<tb_alfabeto> ListarAlfabeto();
    }
}
