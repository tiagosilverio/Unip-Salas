using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pim2019_desk.Modelo;

namespace pim2019_desk.Dal
{
    public class TurmaDAO : intTurmaDAO
    {
        public String mensagem;
        unip_salaEntities turmaEntity = new unip_salaEntities();        
        Conexao conexaoBD = new Conexao();

        public void CadastrarTurma(tb_turma turma)
        {
            try
            {
                this.mensagem = "";
                turmaEntity.tb_turma.Add(turma);
                turmaEntity.SaveChanges();
                this.mensagem = "Cadastrado com Sucesso!";
            }
            catch (Exception e)
            {
                this.mensagem = e.ToString();
            }
        }

        public void EditarTurma(tb_turma turma)
        {
            try
            {
                this.mensagem = "";
                turmaEntity.Entry(turma).State = System.Data.Entity.EntityState.Modified;
                turmaEntity.SaveChanges();
                this.mensagem = "Editado com Sucesso!";
            }
            catch (EntryPointNotFoundException e)
            {
                this.mensagem = e.ToString();
            }
        }

        public void ExcluirTurma(tb_turma turma)
        {
            try
            {
                this.mensagem = "";
                turma = turmaEntity.tb_turma.Find(turma.idTurma);
                turmaEntity.tb_turma.Remove(turma);
                turmaEntity.SaveChanges();
                this.mensagem = "Excluído com Sucesso!";
            }
            catch (EntryPointNotFoundException e)
            {
                this.mensagem = e.ToString();
            }
        }

        public tb_turma GetTurmaPorCodigo(int codigo)
        {
            tb_turma turma = turmaEntity.tb_turma.First(c => c.idTurma == codigo);
            return turma;
        }
    }
}
