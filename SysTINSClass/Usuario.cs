using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace SysTINSClass
{
    public class Usuario
    {
        public int Id;
        public string? Nome;
        public string? Email;
        public string? Senha;
        public Nivel Nivel;
        public bool Ativo;

        public Usuario()
        {
            Nivel = new Nivel();
        }

        public Usuario(string nome, string email, string senha, Nivel nivel)
        {

            Nome = nome;
            Email = email;
            Senha = senha;
            Nivel = nivel;

        }
        public Usuario(string nome, string email, string senha, Nivel nivel, bool ativo)
        {

            Nome = nome;
            Email = email;
            Senha = senha;
            Nivel = nivel;
            Ativo = ativo;

        }
        public Usuario(int id, string nome, string email, string senha, Nivel nivel, bool ativo)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            Nivel = nivel;
            Ativo = ativo;
        }
        //inserir usuario
        public void inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_usuario_insert";
            cmd.Parameters.Add("spnome", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Nome;
            cmd.Parameters.AddWithValue("spemail", Email);
            cmd.Parameters.AddWithValue("spsenha", Senha);
            cmd.Parameters.AddWithValue("spnivel", Nivel.Id);
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Id = dr.GetInt32(0);
            }
            cmd.Connection.Close();
        }
        //Obter por id
        public static Usuario ObterPorId(int id)
        {
            Usuario usuario = new Usuario();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from usuarios where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                usuario = new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    Nivel.ObterPorId(dr.GetInt32(4)),
                    dr.GetBoolean(5)
                    );
            }
            return usuario;
        }
        public List<Usuario> ObterLista()
        {
            List<Usuario> lista = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from usuarios order by nome asc";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                lista.Add(new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    Nivel.ObterPorId(dr.GetInt32(4)),
                    dr.GetBoolean(5)

                    )
                );
            }

            return lista;
        }
    }
}
