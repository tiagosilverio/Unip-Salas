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
    }
}
