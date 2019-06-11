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

        public void CadastrarCampus(List<String> dadosCampus)
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

        public void ExcluirCampus(List<String> dadosCampus)
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

        public void CadastrarAlfabeto(List<String> dadosAlfabeto)
        {
            this.mensagem = "";
            Validacao validacao = new Validacao();
            validacao.ValidarDadosAlfabeto(dadosAlfabeto);
            if (validacao.mensagem.Equals(""))
            {
                tb_alfabeto alfabeto = new tb_alfabeto();
                alfabeto.nomeAlfabeto = dadosAlfabeto[1];
                Dal.AlfabetoDAO alfabetoDAO = new Dal.AlfabetoDAO();
                alfabetoDAO.CadastrarAlfabeto(alfabeto);
                this.mensagem = alfabetoDAO.mensagem;
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }

        public tb_alfabeto GetAlfabetoPorCodigo(int codigo)
        {
            tb_alfabeto alfabeto = new tb_alfabeto();
            Dal.AlfabetoDAO alfabetoDAO = new Dal.AlfabetoDAO();
            alfabeto = alfabetoDAO.GetAlfabetoPorCodigo(codigo);
            return alfabeto;
        }

        public void EditarAlfabeto(List<String> dadosAlfabeto)
        {
            this.mensagem = "";
            Validacao validacao = new Validacao();
            validacao.ValidarDadosAlfabeto(dadosAlfabeto);
            if (validacao.mensagem.Equals(""))
            {
                tb_alfabeto alfabeto = new tb_alfabeto();
                alfabeto.idAlfabeto = validacao.idAlfabeto;
                alfabeto.nomeAlfabeto = dadosAlfabeto[1];
                Dal.AlfabetoDAO alfabetoDAO = new Dal.AlfabetoDAO();
                alfabetoDAO.EditarAfabeto(alfabeto);
                this.mensagem = alfabetoDAO.mensagem;
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }

        public void ExcluirAlfabeto(List<String> dadosAlfabeto)
        {
            this.mensagem = "";
            Validacao validacao = new Validacao();
            validacao.ValidarDadosAlfabeto(dadosAlfabeto);
            if (validacao.mensagem.Equals(""))
            {
                tb_alfabeto alfabeto = new tb_alfabeto();
                alfabeto.idAlfabeto = validacao.idAlfabeto;
                Dal.AlfabetoDAO alfabetoDAO = new Dal.AlfabetoDAO();
                alfabetoDAO.ExcluirAlfabeto(alfabeto);
                this.mensagem = alfabetoDAO.mensagem;
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }

        public List<tb_alfabeto> ListarAlfabeto()
        {
            Dal.AlfabetoDAO alfabetoDAO = new Dal.AlfabetoDAO();
            List<tb_alfabeto> listaAlfabeto = new List<tb_alfabeto>();
            listaAlfabeto = alfabetoDAO.ListarAlfabeto();
            return listaAlfabeto;
        }

        public void CadastrarAndar(List<String> dadosAndar)
        {
            this.mensagem = "";
            Validacao validacao = new Validacao();
            validacao.ValidarDadosAndar(dadosAndar);
            if (validacao.mensagem.Equals(""))
            {
                tb_andar andar = new tb_andar();
                andar.nomeAndar = dadosAndar[1];
                Dal.AndarDAO andarDAO = new Dal.AndarDAO();
                andarDAO.CadastrarAndar(andar);
                this.mensagem = andarDAO.mensagem;
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }

        public tb_andar GetAndarPorCodigo(int codigo)
        {
            tb_andar andar = new tb_andar();
            Dal.AndarDAO andarDAO = new Dal.AndarDAO();
            andar = andarDAO.GetAndarPorCodigo(codigo);
            return andar;
        }

        public void EditarAndar(List<String> dadosAndar)
        {
            this.mensagem = "";
            Validacao validacao = new Validacao();
            validacao.ValidarDadosAndar(dadosAndar);
            if (validacao.mensagem.Equals(""))
            {
                tb_andar andar = new tb_andar();
                andar.idAndar = validacao.idAndar;
                andar.nomeAndar = dadosAndar[1];
                Dal.AndarDAO andarDAO = new Dal.AndarDAO();
                andarDAO.EditarAndar(andar);
                this.mensagem = andarDAO.mensagem;
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }

        public void ExcluirAndar(List<String> dadosAndar)
        {
            this.mensagem = "";
            Validacao validacao = new Validacao();
            validacao.ValidarDadosAndar(dadosAndar);
            if (validacao.mensagem.Equals(""))
            {
                tb_andar andar = new tb_andar();
                andar.idAndar = validacao.idAndar;
                Dal.AndarDAO andarDAO = new Dal.AndarDAO();
                andarDAO.ExcluirAndar(andar);
                this.mensagem = andarDAO.mensagem;
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }

        public void CadastrarTipoSala(List<String> dadosTipo)
        {
            this.mensagem = "";
            Validacao validacao = new Validacao();
            validacao.ValidarDadosTipoSala(dadosTipo);
            if (validacao.mensagem.Equals(""))
            {
                tb_tipo_sala tipo = new tb_tipo_sala();
                tipo.nomeTipoSala = dadosTipo[1];
                Dal.TipoSalaDAO tipoDAO = new Dal.TipoSalaDAO();
                tipoDAO.CadastrarTipoSala(tipo);
                this.mensagem = tipoDAO.mensagem;
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }

        public tb_tipo_sala GetTipoSalaPorCodigo(int codigo)
        {
            tb_tipo_sala tipo = new tb_tipo_sala();
            Dal.TipoSalaDAO tipoDAO = new Dal.TipoSalaDAO();
            tipo = tipoDAO.GetTipoSalaPorCodigo(codigo);
            return tipo;
        }

        public void EditarTipoSala(List<String> dadosTipo)
        {
            this.mensagem = "";
            Validacao validacao = new Validacao();
            validacao.ValidarDadosTipoSala(dadosTipo);
            if (validacao.mensagem.Equals(""))
            {
                tb_tipo_sala tipo = new tb_tipo_sala();
                tipo.idTipoSala = validacao.idTipoSala;
                tipo.nomeTipoSala = dadosTipo[1];
                Dal.TipoSalaDAO tipoDAO = new Dal.TipoSalaDAO();
                tipoDAO.EditarTipoSala(tipo);
                this.mensagem = tipoDAO.mensagem;
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }

        public void ExcluirTipoSala(List<String> dadosTipo)
        {
            this.mensagem = "";
            Validacao validacao = new Validacao();
            validacao.ValidarDadosTipoSala(dadosTipo);
            if (validacao.mensagem.Equals(""))
            {
                tb_tipo_sala tipo = new tb_tipo_sala();
                tipo.idTipoSala = validacao.idTipoSala;
                Dal.TipoSalaDAO tipoDAO = new Dal.TipoSalaDAO();
                tipoDAO.ExcluirTipoSala(tipo);
                this.mensagem = tipoDAO.mensagem;
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }

        public void CadastrarSala(List<String> dadosSala)
        {
            this.mensagem = "";
            Validacao validacao = new Validacao();
            validacao.ValidarDadosSala(dadosSala);
            if (validacao.mensagem.Equals(""))
            {
                tb_sala sala = new tb_sala();
                sala.numeroSala = validacao.numeroSala;
                sala.capacidade = validacao.capacidadeSala;
                sala.fkAlfabeto = Convert.ToInt32(dadosSala[3]);
                sala.fkTipoSala = Convert.ToInt32(dadosSala[4]);
                sala.fkAndar = Convert.ToInt32(dadosSala[5]);
                Dal.SalaDAO salaDAO = new Dal.SalaDAO();
                salaDAO.CadastrarSala(sala);
                this.mensagem = salaDAO.mensagem;
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }

        public tb_sala GetSalaPorCodigo(int codigo)
        {
            tb_sala sala = new tb_sala();
            Dal.SalaDAO salaDAO = new Dal.SalaDAO();
            sala = salaDAO.GetSalaPorCodigo(codigo);
            return sala;
        }

        public void EditarSala(List<String> dadosSala)
        {
            this.mensagem = "";
            Validacao validacao = new Validacao();
            validacao.ValidarDadosSala(dadosSala);
            if (validacao.mensagem.Equals(""))
            {
                tb_sala sala = new tb_sala();
                sala.idSala = validacao.idSala;
                sala.numeroSala = validacao.numeroSala;
                sala.capacidade = validacao.capacidadeSala;
                sala.fkAlfabeto = Convert.ToInt32(dadosSala[3]);
                sala.fkTipoSala = Convert.ToInt32(dadosSala[4]);
                sala.fkAndar = Convert.ToInt32(dadosSala[5]);
                Dal.SalaDAO salaDAO = new Dal.SalaDAO();
                salaDAO.EditarSala(sala);
                this.mensagem = salaDAO.mensagem;
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }

        public void ExcluirSala(List<String> dadosSala)
        {
            this.mensagem = "";
            Validacao validacao = new Validacao();
            validacao.ValidarDadosSala(dadosSala);
            if (validacao.mensagem.Equals(""))
            {
                tb_sala sala = new tb_sala();
                sala.idSala = validacao.idSala;
                sala.numeroSala = validacao.numeroSala;
                sala.capacidade = validacao.capacidadeSala;
                sala.fkAlfabeto = Convert.ToInt32(dadosSala[3]);
                sala.fkTipoSala = Convert.ToInt32(dadosSala[4]);
                sala.fkAndar = Convert.ToInt32(dadosSala[5]);
                Dal.SalaDAO salaDAO = new Dal.SalaDAO();
                salaDAO.ExcluirSala(sala);
                this.mensagem = salaDAO.mensagem;
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }

        public void CadastrarSigla(List<String> dadosSigla)
        {
            this.mensagem = "";
            Validacao validacao = new Validacao();
            validacao.ValidarDadosSigla(dadosSigla);
            if (validacao.mensagem.Equals(""))
            {
                tb_sigla sigla = new tb_sigla();
                sigla.idSigla = validacao.idSigla;
                sigla.nomeSigla = dadosSigla[1];                
                Dal.SiglaDAO siglaDAO = new Dal.SiglaDAO();
                siglaDAO.CadastrarSigla(sigla);
                this.mensagem = siglaDAO.mensagem;
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }

        public tb_sigla GetSiglaPorCodigo(int codigo)
        {
            tb_sigla sigla = new tb_sigla();
            Dal.SiglaDAO siglaDAO = new Dal.SiglaDAO();
            sigla = siglaDAO.GetSiglaPorCodigo(codigo);
            return sigla;
        }

        public void EditarSigla(List<String> dadosSigla)
        {
            this.mensagem = "";
            Validacao validacao = new Validacao();
            validacao.ValidarDadosSigla(dadosSigla);
            if (validacao.mensagem.Equals(""))
            {
                tb_sigla sigla = new tb_sigla();
                sigla.idSigla = validacao.idSigla;
                sigla.nomeSigla = dadosSigla[1];
                Dal.SiglaDAO siglaDAO = new Dal.SiglaDAO();
                siglaDAO.EditarSigla(sigla);
                this.mensagem = siglaDAO.mensagem;
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }

        public void ExcluirSigla(List<String> dadosSigla)
        {
            this.mensagem = "";
            Validacao validacao = new Validacao();
            validacao.ValidarDadosSigla(dadosSigla);
            if (validacao.mensagem.Equals(""))
            {
                tb_sigla sigla = new tb_sigla();
                sigla.idSigla = validacao.idSigla;
                sigla.nomeSigla = dadosSigla[1];
                Dal.SiglaDAO siglaDAO = new Dal.SiglaDAO();
                siglaDAO.ExcluirSigla(sigla);
                this.mensagem = siglaDAO.mensagem;
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }

        public void CadastrarTurma(List<String> dadosTurma)
        {
            this.mensagem = "";
            Validacao validacao = new Validacao();
            validacao.ValidarDadosSigla(dadosTurma);
            if (validacao.mensagem.Equals(""))
            {
                tb_turma turma = new tb_turma();
                turma.idTurma = validacao.idSigla;
                turma.fkSigla = Convert.ToInt32(dadosTurma[1]);
                turma.fkAlfabeto = Convert.ToInt32(dadosTurma[2]);
                turma.fkCampus = Convert.ToInt32(dadosTurma[3]);
                turma.fkCurso = Convert.ToInt32(dadosTurma[4]);
                turma.anoInicio = dadosTurma[5];
                turma.semestreInicio = validacao.semestreInicio;
                Dal.TurmaDAO turmaDAO = new Dal.TurmaDAO();
                turmaDAO.CadastrarTurma(turma);
                this.mensagem = turmaDAO.mensagem;
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }

        //public tb_turma GetTurmaPorCodigo(int codigo)
        //{
        //    tb_turma turma = new tb_turma();
        //    Dal.TurmaDAO turmaDAO = new Dal.TurmaDAO();
        //    turma = turmaDAO.GetSiglaPorCodigo(codigo);
        //    return turma;
        //}

        //public void EditarTurma(List<String> dadosTurma)
        //{
        //    this.mensagem = "";
        //    Validacao validacao = new Validacao();
        //    validacao.ValidarDadosSigla(dadosSigla);
        //    if (validacao.mensagem.Equals(""))
        //    {
        //        tb_turma turma = new tb_turma();
        //        turma.idSigla = validacao.idSigla;
        //        turma.nomeSigla = dadosSigla[1];
        //        Dal.TurmaDAO turmaDAO = new Dal.TurmaDAO();
        //        turmaDAO.EditarSigla(turma);
        //        this.mensagem = turmaDAO.mensagem;
        //    }
        //    else
        //    {
        //        this.mensagem = validacao.mensagem;
        //    }
        //}

        //public void ExcluirTurma(List<String> dadosTurma)
        //{
        //    this.mensagem = "";
        //    Validacao validacao = new Validacao();
        //    validacao.ValidarDadosSigla(dadosSigla);
        //    if (validacao.mensagem.Equals(""))
        //    {
        //        tb_turma turma = new tb_turma();
        //        turma.idSigla = validacao.idSigla;
        //        turma.nomeSigla = dadosSigla[1];
        //        Dal.TurmaDAO turmaDAO = new Dal.TurmaDAO();
        //        turmaDAO.ExcluirSigla(turma);
        //        this.mensagem = turmaDAO.mensagem;
        //    }
        //    else
        //    {
        //        this.mensagem = validacao.mensagem;
        //    }
        //}
    }
}
