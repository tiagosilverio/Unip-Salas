using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pim2019_desk.Modelo;

namespace pim2019_desk.Dal
{
    public class TipoSalaDAO : intTipoSalaDAO
    {
        public String mensagem;
        unip_salaEntities tipoEntity = new unip_salaEntities();

        public void CadastrarTipoSala(tb_tipo_sala tipoSala)
        {
            try
            {
                this.mensagem = "";
                tipoEntity.tb_tipo_sala.Add(tipoSala);
                tipoEntity.SaveChanges();
                this.mensagem = "Cadastrado com Sucesso!";
            }
            catch (Exception e)
            {
                this.mensagem = e.ToString();
            }
        }

        public void EditarTipoSala(tb_tipo_sala tipoSala)
        {
            try
            {
                this.mensagem = "";
                tipoEntity.Entry(tipoSala).State = System.Data.Entity.EntityState.Modified;
                tipoEntity.SaveChanges();
                this.mensagem = "Editado com Sucesso!";
            }
            catch (EntryPointNotFoundException e)
            {
                this.mensagem = e.ToString();
            }
        }

        public void ExcluirTipoSala(tb_tipo_sala tipoSala)
        {
            try
            {
                this.mensagem = "";
                tipoSala = tipoEntity.tb_tipo_sala.Find(tipoSala.idTipoSala);
                tipoEntity.tb_tipo_sala.Remove(tipoSala);
                tipoEntity.SaveChanges();
                this.mensagem = "Excluído com Sucesso!";
            }
            catch (EntryPointNotFoundException e)
            {
                this.mensagem = e.ToString();
            }
        }

        public tb_tipo_sala GetTipoSalaPorCodigo(int codigo)
        {
            tb_tipo_sala tipoSala = tipoEntity.tb_tipo_sala.First(c => c.idTipoSala == codigo);
            return tipoSala;
        }
    }
}
