using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pim2019_desk.Modelo;

namespace pim2019_desk.Dal
{
    public class AndarDAO : intAndarDAO
    {
        public String mensagem;
        unip_salaEntities andarEntity = new unip_salaEntities();

        public void CadastrarAndar(tb_andar andar)
        {            
            try
            {
                this.mensagem = "";
                andarEntity.tb_andar.Add(andar);
                andarEntity.SaveChanges();
                this.mensagem = "Cadastrado com Sucesso!";
            }
            catch (Exception e)
            {
                this.mensagem = e.ToString();
            }
        }

        public void EditarAndar(tb_andar andar)
        {            
            try
            {
                this.mensagem = "";
                andarEntity.Entry(andar).State = System.Data.Entity.EntityState.Modified;
                andarEntity.SaveChanges();
                this.mensagem = "Editado com Sucesso!";
            }
            catch (EntryPointNotFoundException e)
            {
                this.mensagem = e.ToString();
            }
        }

        public void ExcluirAndar(tb_andar andar)
        {
            try
            {
                this.mensagem = "";
                andar = andarEntity.tb_andar.Find(andar.idAndar);
                andarEntity.tb_andar.Remove(andar);
                andarEntity.SaveChanges();
                this.mensagem = "Excluído com Sucesso!";
            }
            catch (EntryPointNotFoundException e)
            {
                this.mensagem = e.ToString();
            }
        }

        public tb_andar GetAndarPorCodigo(int codigo)
        {
            tb_andar andar = andarEntity.tb_andar.First(c => c.idAndar == codigo);
            return andar;
        }
    }
}
