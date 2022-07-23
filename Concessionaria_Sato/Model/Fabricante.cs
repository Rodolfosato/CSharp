using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Concessionaria_Sato.Util;
using System.Data;

namespace Concessionaria_Sato.Model
{
    class Fabricante
    {
        public int Id { get; set; }
        public string fabricante { get; set; }
        public string mensagem { get; set; }

        NpgsqlCommand command = new NpgsqlCommand();

        ConectBD conexao = new ConectBD();

        NpgsqlDataReader dr;

        DataTable dt;

        NpgsqlDataAdapter da;

         public Fabricante(int id, string fabricante)
        {
            this.Id = id;
            this.fabricante = fabricante;
        }

         public Fabricante()
         {
             // TODO: Complete member initialization
         }

         public void Cadastrar()
         {
             command.CommandText = "INSERT INTO FABRICANTE (FABRICANTE)" +
                     "VALUES ('" + this.fabricante + "')";
             try
             {
                 command.Connection = conexao.getConexao();
                 command.ExecuteNonQuery();
             }
             catch (NpgsqlException ex)
             {
                 this.mensagem = "Erro no banco de dados!" + ex;
             }
         }
         public List<string> preencherCBFabricante()
         {
             List<string> lista = new List<string>();
             command.CommandText = "SELECT * FROM FABRICANTE";

             try
             {
                 command.Connection = conexao.getConexao();
                 dr = command.ExecuteReader();
                 while (dr.Read())
                 {

                     lista.Add(dr["FABRICANTE"].ToString());
                 }
                 return lista;

                 
             }
             catch (NpgsqlException ex)
             {
                 this.mensagem = "Erro no banco de dados!" + ex;
             }
             finally
             {
                 conexao.getDesconectar();
             }
             return lista;
         }
         public DataTable Listar(string sql)
         {
             try
             {
                 NpgsqlConnection conection = conexao.getConexao();
                 dt = new DataTable();
                 da = new NpgsqlDataAdapter(sql, conection);
                 da.Fill(dt);

                 return dt;
             }
             catch (NpgsqlException)
             {
                 this.mensagem = "Erro no Banco de dados";
             }
             finally
             {
                 conexao.getDesconectar();
             }
             return dt;
         }
         public void AlterarFabricante(int id_fabricante,string novoFabricante)
         {
             command.CommandText = "UPDATE FABRICANTE SET FABRICANTE = @FABRICANTE WHERE ID_FABRICANTE = @ID_FABRICANTE ";
             command.Parameters.AddWithValue("@ID_FABRICANTE", id_fabricante);
             command.Parameters.AddWithValue("@FABRICANTE", novoFabricante);
             try
             {
                 command.Connection = conexao.getConexao();
                 command.ExecuteNonQuery();
             }
             catch (NpgsqlException)
             {
                 this.mensagem = "Erro no banco de dados";
             }
             finally
             {
                 conexao.getDesconectar();
             }
         }
         public void ExcluirFabricante(int id_fabricante)
         {
             command.CommandText = "DELETE FROM FABRICANTE WHERE ID_FABRICANTE = @ID_FABRICANTE";
             command.Parameters.AddWithValue("@ID_FABRICANTE", id_fabricante);

             try
             {
                 command.Connection = conexao.getConexao();
                 command.ExecuteNonQuery();
             }
             catch (NpgsqlException)
             {
                 this.mensagem = "Erro no banco de dados";
             }
             finally
             {
                 conexao.getDesconectar();
             }
         }
    }
}
