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
    class Veiculo
    {
        public string Placa { get; set; }
        public int Id_Fabricante { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public double PrecoTabela { get; set; }

        public string mensagem { get; set; }

        NpgsqlCommand command = new NpgsqlCommand();

        ConectBD conexao = new ConectBD();

        NpgsqlDataReader dr;

        DataTable dt;

        NpgsqlDataAdapter da;

        public void Veiculos(string placa, int id_fabricante, string modelo, int ano, double precotabela)
        {
            this.Placa = placa;
            this.Id_Fabricante = id_fabricante;
            this.Modelo = modelo;
            this.Ano = ano;
            this.PrecoTabela = precotabela;
        }

        public Veiculo()
        {
            // TODO: Complete member initialization
        }

        public void Cadastrar()
        {
            command.CommandText = "INSERT INTO VEICULO (MODELO, PLACA, ANO, PRECO, ID_FABRICANTE) VALUES (@MODELO, @PLACA, @ANO, @PRECO, @ID_FABRICANTE)";
            command.Parameters.AddWithValue("@MODELO", this.Modelo);
            command.Parameters.AddWithValue("@PLACA", this.Placa);
            command.Parameters.AddWithValue("@ANO", this.Ano);
            command.Parameters.AddWithValue("@PRECO", this.PrecoTabela);
            command.Parameters.AddWithValue("@ID_FABRICANTE", this.Id_Fabricante);
            try
            {
                command.Connection = conexao.getConexao();
                command.ExecuteNonQuery();
            }
            catch (NpgsqlException ex)
            {
                this.mensagem = "Erro no banco de dados!" + ex;
            }
            finally
            {
                conexao.getDesconectar();
            }
        }
        public int Id_fabricante(string fabricante)
        {
            int id_fabricante = 0;
            command.CommandText = "SELECT ID_FABRICANTE FROM FABRICANTE WHERE FABRICANTE = @FABRICANTE";
            command.Parameters.AddWithValue("@FABRICANTE", fabricante);

            try
            {
                command.Connection = conexao.getConexao();
                dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        id_fabricante = Convert.ToInt32(dr["ID_FABRICANTE"].ToString());
                        return id_fabricante;
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                this.mensagem = "Erro no banco de dados!" + ex;
            }
            finally
            {
                conexao.getDesconectar();
            }
            return id_fabricante;
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
        public void EditarVeiculo(int id)
        {
            command.CommandText = "UPDATE VEICULO SET MODELO = @MODELO, PLACA = @PLACA, "
            + "ANO = @ANO, PRECO = @PRECO, ID_FABRICANTE = @ID_FABRICANTE WHERE ID = @ID";
            command.Parameters.AddWithValue("@MODELO", this.Modelo);
            command.Parameters.AddWithValue("@PLACA", this.Placa);
            command.Parameters.AddWithValue("@ANO", this.Ano);
            command.Parameters.AddWithValue("@PRECO", this.PrecoTabela);
            command.Parameters.AddWithValue("@ID_FABRICANTE", this.Id_Fabricante);
            command.Parameters.AddWithValue("@ID", id);

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
        public void ExcluirVeiculo(int id_veiculo)
        {
            command.CommandText = "DELETE FROM VEICULO WHERE ID = @ID";
            command.Parameters.AddWithValue("@ID", id_veiculo);

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
