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
        public int idCampus;
        public int numeroCampus;
        public int idCurso;
        public int idAluno;

        public void ValidarDadosCampus(List<String> dadosCampus)
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
                this.numeroCampus = Convert.ToInt32(dadosCampus[1]);
            }
            catch (FormatException)
            {
                this.mensagem += "Número inválido. \n";
            }

            try
            {
                this.idCampus = Convert.ToInt32(dadosCampus[0]);
            }
            catch (FormatException)
            {
                this.mensagem += "ID inválido. \n";
            }
        }

        public void ValidarDadosCurso(List<String> dadosCurso)
        {
            this.mensagem = "";
            if (dadosCurso[1] == "")
                this.mensagem = "Insira o nome do curso. \n";
            if (dadosCurso[1].Length > 70)
                this.mensagem = "Nome inválido, deve conter até 70 caracteres. \n";

            try
            {
                this.idCurso = Convert.ToInt32(dadosCurso[0]);
            }
            catch (FormatException)
            {
                this.mensagem += "ID inválido. \n";
            }
        }

        public void ValidarDadosAluno(List<String> dadosAluno)
        {
            this.mensagem = "";
            if (dadosAluno[1] == "")
                this.mensagem = "Insira o RA do aluno. \n";
            if (dadosAluno[1].Length > 7)
                this.mensagem += "RA inválido, deve conter até 7 caracteres. \n";
            if (dadosAluno[2] == "")
                this.mensagem += "Insira o nome do aluno. \n";
            if (dadosAluno[2].Length > 50)
                this.mensagem += "Nome inválido, deve conter até 50 caracteres. \n";            

            try
            {
                this.idAluno = Convert.ToInt32(dadosAluno[0]);
            }
            catch (FormatException)
            {
                this.mensagem += "ID inválido. \n";
            }
        }
    }
}
