using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pim2019_desk.Modelo;

namespace pim2019_desk.Dal
{
    public class CampusDAO : intCampusDAO
    {
        public String mensagem;
        unip_salaEntities campusEntity = new unip_salaEntities();        

        public void CadastrarCampus(tb_campus campus)
        {
            try
            {
                this.mensagem = "";
                campusEntity.tb_campus.Add(campus);
                campusEntity.SaveChanges();
                this.mensagem = "Cadastrado com Sucesso!";
            }
            catch (Exception e)
            {
                this.mensagem = e.ToString();
            }
        }

        public void EditarCampus(tb_campus campus)
        {
            this.mensagem = "";

            try
            {               
                campusEntity.Entry(campus).State = System.Data.Entity.EntityState.Modified;
                campusEntity.SaveChanges();
                this.mensagem = "Editado com Sucesso!";
            }
            catch (EntryPointNotFoundException e)
            {
                this.mensagem = e.ToString();
            }
        }

        public void ExcluirCampus(tb_campus campus)
        {
            try
            {
                this.mensagem = "";
                campus = campusEntity.tb_campus.Find(campus.idCampus);
                campusEntity.tb_campus.Remove(campus);
                campusEntity.SaveChanges();
                this.mensagem = "Excluído com Sucesso!";
            }
            catch (EntryPointNotFoundException e)
            {
                this.mensagem = e.ToString();
            }            
        }

        public tb_campus GetRegistroPorCodigo(int codigo)
        {
            tb_campus campus = campusEntity.tb_campus.First(c => c.idCampus == codigo);
            return campus;
        }
    }
}
