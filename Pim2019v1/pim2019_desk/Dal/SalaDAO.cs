using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pim2019_desk.Modelo;

namespace pim2019_desk.Dal
{
    public class SalaDAO : intSalaDAO
    {
        public String mensagem;
        unip_salaEntities salaEntity = new unip_salaEntities();
        //SqlDataReader dataReader;
        Conexao conexaoBD = new Conexao();

        public void CadastrarSala(tb_sala sala)
        {
            try
            {
                this.mensagem = "";
                salaEntity.tb_sala.Add(sala);
                salaEntity.SaveChanges();
                this.mensagem = "Cadastrado com Sucesso!";
            }
            catch (Exception e)
            {
                this.mensagem = e.ToString();
            }
        }

        public void EditarSala(tb_sala sala)
        {
            try
            {
                this.mensagem = "";
                salaEntity.Entry(sala).State = System.Data.Entity.EntityState.Modified;
                salaEntity.SaveChanges();
                this.mensagem = "Editado com Sucesso!";
            }
            catch (EntryPointNotFoundException e)
            {
                this.mensagem = e.ToString();
            }
        }

        public void ExcluirSala(tb_sala sala)
        {
            try
            {
                this.mensagem = "";
                sala = salaEntity.tb_sala.Find(sala.idSala);
                salaEntity.tb_sala.Remove(sala);
                salaEntity.SaveChanges();
                this.mensagem = "Excluído com Sucesso!";
            }
            catch (EntryPointNotFoundException e)
            {
                this.mensagem = e.ToString();
            }
        }


        public tb_sala GetSalaPorCodigo(int codigo)
        {
            //List<String> listaSala = new List<string>();
            //using (salaEntity)
            //{
            //    var s = (from p in salaEntity.tb_sala
            //             join a in salaEntity.tb_alfabeto on p.fkAlfabeto equals a.idAlfabeto
            //             join t in salaEntity.tb_tipo_sala on p.fkTipoSala equals t.idTipoSala
            //             join n in salaEntity.tb_andar on p.fkAndar equals n.idAndar
            //             where p.idSala == codigo
            //             select p).FirstOrDefault();
            //    return s;
            //}
            
            tb_sala sala = salaEntity.tb_sala.First(c => c.idSala == codigo);
            return sala;
        }

        //public List<tb_sala> ListarSala()
        //{
        //    this.mensagem = "";
        //    SqlCommand cmd = new SqlCommand();
        //List<tb_sala> listaSala = new List<tb_sala>();
        //cmd.CommandText = @"select idSala as [ID], numeroSala as [Numero], capacidade as [Capacidade], 
        //    a.nomeAlfabeto as [Bloco], t.nomeTipoSala as [Tipo], b.nomeAndar as [Andar] from tb_sala
        //    inner join tb_alfabeto as a on tb_sala.fkAlfabeto = idAlfabeto 
        //    inner join tb_tipo_sala as t on tb_sala.fkTipoSala = idTipoSala
        //    inner join tb_andar as b on tb_sala.fkAndar = idAndar";
        //    try
        //    {
        //        cmd.Connection = conexaoBD.Conectar();
        //        dataReader = cmd.ExecuteReader();
        //        while (dataReader.Read())
        //        {
        //            tb_sala tbsala = new tb_sala();
        //            tbsala.idSala = Convert.ToInt32(dataReader["idSala"].ToString());
        //            tbsala.numeroSala = Convert.ToInt32(dataReader["numeroSala"].ToString());
        //            tbsala.capacidade = Convert.ToInt32(dataReader["capacidade"].ToString());
        //            tbsala.fkAlfabeto = Convert.ToInt32(dataReader["nomeAlfabeto"].ToString());
        //            tbsala.fkTipoSala = Convert.ToInt32(dataReader["nomeTipoSala"].ToString());
        //            tbsala.fkAndar = Convert.ToInt32(dataReader["nomeAndar"].ToString());
        //            listaSala.Add(tbsala);
        //        }
        //        dataReader.Close();
        //        conexaoBD.Desconectar();
        //        return listaSala;
        //    }
        //    catch (Exception e)
        //    {
        //        this.mensagem = e.ToString();
        //        return null;
        //    }
            
        //}
    }
}
