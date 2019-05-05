using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pim2019_desk.Modelo;

namespace pim2019_desk.Dal
{
    public class AlunoDAO : intAlunoDAO
    {
        public String mensagem;
        unip_salaEntities alunoEntity = new unip_salaEntities();

        public void CadastrarAluno(tb_aluno aluno)
        {
            try
            {
                this.mensagem = "";
                alunoEntity.tb_aluno.Add(aluno);
                alunoEntity.SaveChanges();
                this.mensagem = "Cadastrado com Sucesso!";
            }
            catch (Exception e)
            {
                this.mensagem = e.ToString();
            }
        }

        public void EditarAluno(tb_aluno aluno)
        {
            throw new NotImplementedException();
        }

        public void ExcluirAluno(tb_aluno aluno)
        {
            throw new NotImplementedException();
        }

        public tb_aluno GetAlunoPorCodigo(int codigo)
        {
            throw new NotImplementedException();
        }
    }
}
