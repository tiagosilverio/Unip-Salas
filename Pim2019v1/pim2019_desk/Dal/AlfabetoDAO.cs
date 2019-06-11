using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pim2019_desk.Modelo;

namespace pim2019_desk.Dal
{
    public class AlfabetoDAO : intAlfabetoDAO
    {
        public String mensagem;
        unip_salaEntities alfabetoEntity = new unip_salaEntities();

        public void CadastrarAlfabeto(tb_alfabeto alfabeto)
        {
            try
            {
                this.mensagem = "";
                alfabetoEntity.tb_alfabeto.Add(alfabeto);
                alfabetoEntity.SaveChanges();
                this.mensagem = "Cadastrado com Sucesso!";
            }
            catch (Exception e)
            {
                this.mensagem = e.ToString();
            }
        }

        public void EditarAfabeto(tb_alfabeto alfabeto)
        {            
            try
            {
                this.mensagem = "";
                alfabetoEntity.Entry(alfabeto).State = System.Data.Entity.EntityState.Modified;
                alfabetoEntity.SaveChanges();
                this.mensagem = "Editado com Sucesso!";
            }
            catch (EntryPointNotFoundException e)
            {
                this.mensagem = e.ToString();
            }
        }

        public void ExcluirAlfabeto(tb_alfabeto alfabeto)
        {
            try
            {
                this.mensagem = "";
                alfabeto = alfabetoEntity.tb_alfabeto.Find(alfabeto.idAlfabeto);
                alfabetoEntity.tb_alfabeto.Remove(alfabeto);
                alfabetoEntity.SaveChanges();
                this.mensagem = "Excluído com Sucesso!";
            }
            catch (EntryPointNotFoundException e)
            {
                this.mensagem = e.ToString();
            }
        }

        public tb_alfabeto GetAlfabetoPorCodigo(int codigo)
        {
            tb_alfabeto alfabeto = alfabetoEntity.tb_alfabeto.First(c => c.idAlfabeto == codigo);
            return alfabeto;
        }

        public List<tb_alfabeto> ListarAlfabeto()
        {
            try
            {
                return alfabetoEntity.tb_alfabeto.ToList();
            }
            catch (Exception e)
            {
                this.mensagem = e.ToString();
                return null;
            }
        }
    }
}
