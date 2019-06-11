using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pim2019_desk.Modelo;

namespace pim2019_desk.Dal
{
    public class SiglaDAO : intSiglaDAO
    {
        public String mensagem;
        unip_salaEntities siglaEntity = new unip_salaEntities();

        public void CadastrarSigla(tb_sigla sigla)
        {
            try
            {
                this.mensagem = "";
                siglaEntity.tb_sigla.Add(sigla);
                siglaEntity.SaveChanges();
                this.mensagem = "Cadastrado com Sucesso!";
            }
            catch (Exception e)
            {
                this.mensagem = e.ToString();
            }
        }

        public void EditarSigla(tb_sigla sigla)
        {
            try
            {
                this.mensagem = "";
                siglaEntity.Entry(sigla).State = System.Data.Entity.EntityState.Modified;
                siglaEntity.SaveChanges();
                this.mensagem = "Editado com Sucesso!";
            }
            catch (EntryPointNotFoundException e)
            {
                this.mensagem = e.ToString();
            }
        }

        public void ExcluirSigla(tb_sigla sigla)
        {
            try
            {
                this.mensagem = "";
                sigla = siglaEntity.tb_sigla.Find(sigla.idSigla);
                siglaEntity.tb_sigla.Remove(sigla);
                siglaEntity.SaveChanges();
                this.mensagem = "Excluído com Sucesso!";
            }
            catch (EntryPointNotFoundException e)
            {
                this.mensagem = e.ToString();
            }
        }

        public tb_sigla GetSiglaPorCodigo(int codigo)
        {
            tb_sigla sigla = siglaEntity.tb_sigla.First(c => c.idSigla == codigo);
            return sigla;
        }
    }
}
