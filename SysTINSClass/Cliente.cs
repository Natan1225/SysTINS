using System;
using System.Collections.Generic;
using System.Data;

namespace SysTINSClass
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public DateTime Data_Nasc { get; set; }
        public DateTime Data_Cad { get; set; }
        public bool Ativo { get; set; }
        public List<Endereco> Enderecos { get; set; }


        public Cliente()
        {
            Enderecos = new List<Endereco>();
        }

        public Cliente(int id, string nome, string cpf, string email, string telefone, DateTime dataNasc, DateTime dataCad, bool ativo)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            Data_Nasc = dataNasc;
            Data_Cad = dataCad;
            Ativo = ativo;
            Enderecos = new List<Endereco>();
        }


        public Cliente(string nome, string cpf, string email, string telefone, DateTime dataNasc, DateTime dataCad, bool ativo)
        {
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            Data_Nasc = dataNasc;
            Data_Cad = dataCad;
            Ativo = ativo;
            Enderecos = new List<Endereco>();
        }


        public void Inserir()
        {
            var cmd = Banco.Abrir();
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_cliente_insert";
                cmd.Parameters.AddWithValue("spnome", Nome);
                cmd.Parameters.AddWithValue("spcpf_cnpj", Cpf);
                cmd.Parameters.AddWithValue("spemail", Email);
                cmd.Parameters.AddWithValue("sptelefone", Telefone);


                Id = Convert.ToInt32(cmd.ExecuteScalar());
            }
        }


        public static Cliente ObterPorId(int id)
        {
            Cliente cliente = new();

            var cmd = Banco.Abrir();
            {
                cmd.CommandText = "SELECT * FROM clientes WHERE id = @id";
                cmd.Parameters.AddWithValue("id", id);
                var dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    cliente = new Cliente(
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetString(3),
                        dr.GetString(4),
                        dr.GetDateTime(5),
                        dr.GetDateTime(6),
                        dr.GetBoolean(7)
                    );
                }
            }
            return cliente;
        }


        public static List<Cliente> ObterLista()
        {
            List<Cliente> clientes = new List<Cliente>();

            var cmd = Banco.Abrir();
            {
                cmd.CommandText = "SELECT * FROM clientes";
                var dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    clientes.Add(new Cliente(
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetString(3),
                        dr.GetString(4),
                        dr.GetDateTime(5),
                        dr.GetDateTime(6),
                        dr.GetBoolean(7)
                    ));
                }
            }

            return clientes;
        }


        public bool Atualizar()
        {
            bool resposta = false;

            var cmd = Banco.Abrir();
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_cliente_update";
                cmd.Parameters.AddWithValue("spid", Id);
                cmd.Parameters.AddWithValue("spnome", Nome);
                cmd.Parameters.AddWithValue("spcpf_cnpj", Cpf);
                cmd.Parameters.AddWithValue("spemail", Email);
                cmd.Parameters.AddWithValue("sptelefone", Telefone);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    resposta = true;
                }
            }

            return resposta;
        }


        public void Excluir()
        {
            var cmd = Banco.Abrir();
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_cliente_delete";
                cmd.Parameters.AddWithValue("spid", Id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
