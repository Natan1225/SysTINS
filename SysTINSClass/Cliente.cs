using System;
using System.Collections.Generic;
using System.Data;

namespace SysTINSClass
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CpfCnpj { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public List<Endereco> Enderecos { get; set; }

        public Cliente()
        {
            Enderecos = new List<Endereco>();
        }

        public Cliente(int id, string nome, string cpfCnpj, string email, string telefone)
        {
            Id = id;
            Nome = nome;
            CpfCnpj = cpfCnpj;
            Email = email;
            Telefone = telefone;
            Enderecos = new List<Endereco>();
        }


        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_cliente_insert";
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spcpf_cnpj", CpfCnpj);
            cmd.Parameters.AddWithValue("spemail", Email);
            cmd.Parameters.AddWithValue("sptelefone", Telefone);
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();
        }

        public static Cliente ObterPorId(int id)
        {
            Cliente cliente = null;
            var cmd = Banco.Abrir();
            cmd.CommandText = $"SELECT * FROM clientes WHERE id = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cliente = new Cliente(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4)
                );
            }
            return cliente;
        }

        public static List<Cliente> ObterLista()
        {
            List<Cliente> clientes = new List<Cliente>();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"SELECT * FROM clientes";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clientes.Add(new Cliente(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4)
                ));
            }
            return clientes;
        }

        public bool Atualizar()
        {
            bool resposta = false;
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_cliente_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spcpf_cnpj", CpfCnpj);
            cmd.Parameters.AddWithValue("spemail", Email);
            cmd.Parameters.AddWithValue("sptelefone", Telefone);
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
            cmd.CommandText = "sp_cliente_delete";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
    }
}