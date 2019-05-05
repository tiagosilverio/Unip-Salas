using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pim2019_desk.Modelo
{
    public class Controle
    {
        public String mensagem;

        public void CadastrarCampus (List<String> dadosCampus)
        {
            this.mensagem = "";
            Validacao validacao = new Validacao();
            validacao.ValidarDadosCampus(dadosCampus);
            if (validacao.mensagem.Equals(""))
            {
                tb_campus campus = new tb_campus();
                campus.numeroCampus = validacao.numeroCampus;
                campus.nomeCampus = dadosCampus[2];
                Dal.CampusDAO campusDAO = new Dal.CampusDAO();
                campusDAO.CadastrarCampus(campus);
                this.mensagem = campusDAO.mensagem;
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }

        public void EditarCampus(List<String> dadosCampus)
        {
            this.mensagem = "";
            Validacao validacao = new Validacao();
            validacao.ValidarDadosCampus(dadosCampus);
            if (validacao.mensagem.Equals(""))
            {
                tb_campus campus = new tb_campus();
                campus.idCampus = validacao.idCampus;
                campus.numeroCampus = validacao.numeroCampus;
                campus.nomeCampus = dadosCampus[2];
                Dal.CampusDAO campusDAO = new Dal.CampusDAO();
                campusDAO.EditarCampus(campus);
                this.mensagem = campusDAO.mensagem;
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }

        public void ExcluirCampus (List<String> dadosCampus)
        {
            this.mensagem = "";
            Validacao validacao = new Validacao();
            validacao.ValidarDadosCampus(dadosCampus);
            if (validacao.mensagem.Equals(""))
            {
                tb_campus campus = new tb_campus();
                campus.idCampus = validacao.idCampus;                
                Dal.CampusDAO campusDAO = new Dal.CampusDAO();
                campusDAO.ExcluirCampus(campus);
                this.mensagem = campusDAO.mensagem;
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }

        public tb_campus GetRegistroPorCodigo(int codigo)
        {
            tb_campus campus = new tb_campus();
            Dal.CampusDAO campusDAO = new Dal.CampusDAO();
            campus = campusDAO.GetRegistroPorCodigo(codigo);
            return campus;
        }

        public void CadastrarCurso(List<String> dadosCurso)
        {
            this.mensagem = "";
            Validacao validacao = new Validacao();
            validacao.ValidarDadosCurso(dadosCurso);
            if (validacao.mensagem.Equals(""))
            {
                tb_curso curso = new tb_curso();
                curso.nomeCurso = dadosCurso[1];
                Dal.CursoDAO cursoDAO = new Dal.CursoDAO();
                cursoDAO.CadastrarCurso(curso);
                this.mensagem = cursoDAO.mensagem;
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }

        public void EditarCurso(List<String> dadosCurso)
        {
            this.mensagem = "";
            Validacao validacao = new Validacao();
            validacao.ValidarDadosCurso(dadosCurso);
            if (validacao.mensagem.Equals(""))
            {
                tb_curso curso = new tb_curso();
                curso.idCurso = validacao.idCurso;
                curso.nomeCurso = dadosCurso[1];                
                Dal.CursoDAO cursoDAO = new Dal.CursoDAO();
                cursoDAO.EditarCurso(curso);
                this.mensagem = cursoDAO.mensagem;
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }

        public tb_curso GetCursoPorCodigo(int codigo)
        {
            tb_curso curso = new tb_curso();
            Dal.CursoDAO cursoDAO = new Dal.CursoDAO();
            curso = cursoDAO.GetCursoPorCodigo(codigo);
            return curso;
        }

        public void ExcluirCurso(List<String> dadosCurso)
        {
            this.mensagem = "";
            Validacao validacao = new Validacao();
            validacao.ValidarDadosCurso(dadosCurso);
            if (validacao.mensagem.Equals(""))
            {
                tb_curso curso = new tb_curso();
                curso.idCurso = validacao.idCurso;
                Dal.CursoDAO cursoDAO = new Dal.CursoDAO();
                cursoDAO.ExcluirCurso(curso);
                this.mensagem = cursoDAO.mensagem;
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }

        public void CadastrarAluno(List<String> dadosAluno)
        {
            this.mensagem = "";
            Validacao validacao = new Validacao();
            validacao.ValidarDadosAluno(dadosAluno);
            if (validacao.mensagem.Equals(""))
            {
                tb_aluno aluno = new tb_aluno();
                aluno.raAluno = dadosAluno[1];
                aluno.nomeAluno = dadosAluno[2];
                aluno.statusAluno = Convert.ToBoolean(dadosAluno[3]);
                Dal.AlunoDAO alunoDAO = new Dal.AlunoDAO();
                alunoDAO.CadastrarAluno(aluno);
                this.mensagem = alunoDAO.mensagem;
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }            
        }

        public tb_aluno GetAlunoPorCodigo(int codigo)
        {
            tb_aluno aluno = new tb_aluno();
            Dal.AlunoDAO alunoDAO = new Dal.AlunoDAO();
            aluno = alunoDAO.GetAlunoPorCodigo(codigo);
            return aluno;
        }

        public void EditarAluno(List<String> dadosAluno)
        {
            this.mensagem = "";
            Validacao validacao = new Validacao();
            validacao.ValidarDadosAluno(dadosAluno);
            if (validacao.mensagem.Equals(""))
            {
                tb_aluno aluno = new tb_aluno();
                aluno.idAluno = validacao.idAluno;
                aluno.raAluno = dadosAluno[1];
                aluno.nomeAluno = dadosAluno[2];
                aluno.statusAluno = Convert.ToBoolean(dadosAluno[3]);
                Dal.AlunoDAO alunoDAO = new Dal.AlunoDAO();
                alunoDAO.EditarAluno(aluno);
                this.mensagem = alunoDAO.mensagem;
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }

        public void ExcluirAluno(List<String> dadosAluno)
        {
            this.mensagem = "";
            Validacao validacao = new Validacao();
            validacao.ValidarDadosAluno(dadosAluno);
            if (validacao.mensagem.Equals(""))
            {
                tb_aluno aluno = new tb_aluno();
                aluno.idAluno = validacao.idAluno;
                Dal.AlunoDAO alunoDAO = new Dal.AlunoDAO();
                alunoDAO.ExcluirAluno(aluno);
                this.mensagem = alunoDAO.mensagem;
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }
    }
}
