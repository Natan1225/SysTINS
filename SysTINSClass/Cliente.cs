using Google.Protobuf.WellKnownTypes;
using Org.BouncyCastle.Cms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SysTINSClass
{
    //    id int(4) AI PK
    //nome varchar(100)
    //cpf char (11) 
    //telefone char (14) 
    //email varchar(60)
    //data_nasc date
    //data_cad timestamp
    //ativo bit(1)

//    CREATE DEFINER =`root`@`localhost` PROCEDURE `sp_cliente_insert`(
//spnome varchar(100), 
//spcpf char (11), 
//sptelefone char (14), 
//spemail varchar(60), 
//spdatanasc date
//)
//begin
//    insert into clientes
//    values(0, spnome, spcpf, sptelefone, spemail, spdatanasc,default,1);
//    select last_insert_id();
//    end
    public class Cliente
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public char Cpf { get; set; }
        public char Telefone { get; set; }
        public string? Email { get; set; }
        public DateTime DataNasc { get; set; }
        public DateTime? DataCad { get; set; }
        public bool ativo { get; set; }

        public Cliente(int id, string? nome, char cpf, char telefone, string? email, DateTime dataNasc, DateTime? dataCad, bool ativo)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            DataNasc = dataNasc;
            DataCad = dataCad;
            this.ativo = ativo;


        }
        public Cliente()
        {

        }
        public void InserirCliente()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = " sp_cliente_insert";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spcpf", Cpf);
            cmd.Parameters.AddWithValue("sptelefone", Telefone);
            cmd.Parameters.AddWithValue("spemail", Email );
            cmd.Parameters.AddWithValue("spdatanasc", DataNasc);
            cmd.Parameters.AddWithValue("spdatacad", DataCad);
            cmd.Parameters.AddWithValue("spativo", ativo);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            


        }
        public static Cliente ObterPorId(int id)
        {
            Cliente cliente = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from clientes where id = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cliente = new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetChar(2),
                     dr.GetChar(3),
                     dr.GetString(4),
                     dr.GetDateTime(5),
                     dr.GetDateTime(6),
                     dr.GetBoolean(7)
                     );




            }
            return cliente;
        }



    }
}
