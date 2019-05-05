using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pim2019_desk.Modelo
{
    public class Validacao
    {
        public String mensagem;
        public int id;
        public int numeroCampus;

        public void ValidarDadosCampus (List<String> dadosCampus)
        {
            this.mensagem = "";            
            if (dadosCampus[1].Length > 5)
                this.mensagem = "Número inválido, deve conter até 5 caracteres. \n";
            if (dadosCampus[2] == "")
                this.mensagem += "Insira o nome do campus. \n";
            if (dadosCampus[2].Length > 50)
                this.mensagem += "Nome inválido, deve conter até 50 caracteres. \n";

            try
            {
                this.id = Convert.ToInt32(dadosCampus[1]);
            }
            catch (FormatException)
            {
                this.mensagem += "Número inválido.";
            }

            try
            {
                this.id = Convert.ToInt32(dadosCampus[0]);
            }
            catch (FormatException)
            {
                this.mensagem += "ID inválido.";
            }
        }
    }
}
