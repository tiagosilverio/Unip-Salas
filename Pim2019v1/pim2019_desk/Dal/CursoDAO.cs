using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pim2019_desk.Modelo;

namespace pim2019_desk.Dal
{
    public class CursoDAO : intCursoDAO
    {
        public String mensagem;
        unip_salaEntities cursoEntity = new unip_salaEntities();

        public void CadastrarCurso(tb_curso curso)
        {
            try
            {
                this.mensagem = "";
                cursoEntity.tb_curso.Add(curso);
                cursoEntity.SaveChanges();
                this.mensagem = "Cadastrado com Sucesso!";
            }
            catch (Exception e)
            {
                this.mensagem = e.ToString();
            }
        }

        public void EditarCurso(tb_curso curso)
        {
            this.mensagem = "";

            try
            {
                cursoEntity.Entry(curso).State = System.Data.Entity.EntityState.Modified;
                cursoEntity.SaveChanges();
                this.mensagem = "Editado com Sucesso!";
            }
            catch (EntryPointNotFoundException e)
            {
                this.mensagem = e.ToString();
            }
        }

        public void ExcluirCurso(tb_curso curso)
        {
            throw new NotImplementedException();
        }

        public tb_curso GetCursoPorCodigo(int codigo)
        {
            throw new NotImplementedException();
        }
    }
}
