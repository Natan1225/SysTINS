using System;
using System.Collections.Generic;
using System.Data;

namespace SysTINSClass
{
    public class Endereco
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }


        public Cliente Cliente { get; set; }


        public Endereco() { }

        public Endereco(int id, int clienteId, string rua, string numero, string complemento, string bairro, string cidade, string estado, string cep)
        {
            Id = id;
            ClienteId = clienteId;
            Rua = rua;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Cep = cep;
        }

        // Métodos para interação com o banco de dados
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_endereco_insert";
            cmd.Parameters.AddWithValue("spcliente_id", ClienteId);
            cmd.Parameters.AddWithValue("sprua", Rua);
            cmd.Parameters.AddWithValue("spnumero", Numero);
            cmd.Parameters.AddWithValue("spcomplemento", Complemento);
            cmd.Parameters.AddWithValue("spbairro", Bairro);
            cmd.Parameters.AddWithValue("spcidade", Cidade);
            cmd.Parameters.AddWithValue("spestado", Estado);
            cmd.Parameters.AddWithValue("spcep", Cep);
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();
        }

        public static Endereco ObterPorId(int id)
        {
            Endereco endereco = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"SELECT * FROM enderecos WHERE id = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                endereco = new Endereco(
                    dr.GetInt32(0),
                    dr.GetInt32(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetString(5),
                    dr.GetString(6),
                    dr.GetString(7),
                    dr.GetString(8)
                );
            }
            return endereco;
        }

        public static List<Endereco> ObterListaPorCliente(int clienteId)
        {
            List<Endereco> enderecos = new List<Endereco>();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"SELECT * FROM enderecos WHERE cliente_id = {clienteId}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                enderecos.Add(new Endereco(
                    dr.GetInt32(0),
                    dr.GetInt32(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetString(5),
                    dr.GetString(6),
                    dr.GetString(7),
                    dr.GetString(8)
                ));
            }
            return enderecos;
        }

        public bool Atualizar()
        {
            bool resposta = false;
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_endereco_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spcliente_id", ClienteId);
            cmd.Parameters.AddWithValue("sprua", Rua);
            cmd.Parameters.AddWithValue("spnumero", Numero);
            cmd.Parameters.AddWithValue("spcomplemento", Complemento);
            cmd.Parameters.AddWithValue("spbairro", Bairro);
            cmd.Parameters.AddWithValue("spcidade", Cidade);
            cmd.Parameters.AddWithValue("spestado", Estado);
            cmd.Parameters.AddWithValue("spcep", Cep);
            if (cmd.ExecuteNonQuery() > 0)
            {
                cmd.Connection.Close();
                resposta = true;
            }
            return resposta;
        }

        public void Excluir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_endereco_delete";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
    }
}