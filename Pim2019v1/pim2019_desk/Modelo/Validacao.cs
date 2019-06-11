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
        public int idAlfabeto;
        public int idAndar;
        public int idTipoSala;
        public int idSala;
        public int numeroSala;
        public int capacidadeSala;
        public int idSigla;
        public int idTurma;
        public int semestreInicio;
        public DateTime anoInicio;

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

        public void ValidarDadosAlfabeto(List<String> dadosAlfabeto)
        {
            this.mensagem = "";
            if (dadosAlfabeto[1] == "")
                this.mensagem = "Insira o caractere. \n";
            if (dadosAlfabeto[1].Length > 1)
                this.mensagem = "Caractere inválido. \n";

            try
            {
                this.idAlfabeto = Convert.ToInt32(dadosAlfabeto[0]);
            }
            catch (FormatException)
            {
                this.mensagem += "ID inválido. \n";
            }
        }

        public void ValidarDadosAndar(List<String> dadosAndar)
        {
            this.mensagem = "";
            if (dadosAndar[1] == "")
                this.mensagem = "Insira o nome do Andar. \n";
            if (dadosAndar[1].Length > 40)
                this.mensagem = "Nome inválido, deve conter até 40 caracteres. \n";

            try
            {
                this.idAndar = Convert.ToInt32(dadosAndar[0]);
            }
            catch (FormatException)
            {
                this.mensagem += "ID inválido. \n";
            }
        }

        public void ValidarDadosTipoSala(List<String> dadosTipo)
        {
            this.mensagem = "";
            if (dadosTipo[1] == "")
                this.mensagem = "Insira o nome do tipo de sala. \n";
            if (dadosTipo[1].Length > 50)
                this.mensagem = "Nome inválido, deve conter até 50 caracteres. \n";

            try
            {
                this.idTipoSala = Convert.ToInt32(dadosTipo[0]);
            }
            catch (FormatException)
            {
                this.mensagem += "ID inválido. \n";
            }
        }

        public void ValidarDadosSala(List<String> dadosSala)
        {
            this.mensagem = "";            
            if (dadosSala[3] == "")
                this.mensagem = "Selecione o bloco da sala. \n";
            if (dadosSala[4] == "")
                this.mensagem = "Selecione o tipo da sala. \n";
            if (dadosSala[5] == "")
                this.mensagem = "Selecione o andar da sala. \n";

            try
            {
                this.idSala = Convert.ToInt32(dadosSala[0]);
            }
            catch (FormatException)
            {
                this.mensagem += "ID inválido. \n";
            }

            try
            {
                this.numeroSala = Convert.ToInt32(dadosSala[1]);
            }
            catch (FormatException)
            {
                this.mensagem += "Número inválido. \n";
            }

            try
            {
                this.capacidadeSala = Convert.ToInt32(dadosSala[2]);
            }
            catch (FormatException)
            {
                this.mensagem += "Capacidade inválida. \n";
            }
        }

        public void ValidarDadosSigla(List<String> dadosSigla)
        {
            this.mensagem = "";
            if (dadosSigla[1] == "")
                this.mensagem = "Insira o nome da sigla. \n";
            if (dadosSigla[1].Length > 8)
                this.mensagem = "Nome inválido, deve conter até 70 caracteres. \n";

            try
            {
                this.idSigla = Convert.ToInt32(dadosSigla[0]);
            }
            catch (FormatException)
            {
                this.mensagem += "ID inválido. \n";
            }
        }

        public void ValidarDadosTurma(List<String> dadosTurma)
        {
            this.mensagem = "";
            if (dadosTurma[1] == "")
                this.mensagem = "Selecione a sigla da turma. \n";
            if (dadosTurma[2] == "")
                this.mensagem += "Selecione a letra da turma. \n";
            if (dadosTurma[3] == "")
                this.mensagem += "Selecione o campus. \n";
            if (dadosTurma[4] == "")
                this.mensagem += "Selecione o curso. \n";
            if (dadosTurma[5].Length < 4 || dadosTurma[5].Length > 5)
                this.mensagem += "Ano inválido. \n";

            try
            {
                this.idTurma = Convert.ToInt32(dadosTurma[0]);
            }
            catch (FormatException)
            {
                this.mensagem += "ID inválido. \n";
            }

            try
            {
                this.semestreInicio = Convert.ToInt32(dadosTurma[6]);
            }
            catch (FormatException)
            {
                this.mensagem += "Semestre inválido. \n";
            }
        }
    }
}
