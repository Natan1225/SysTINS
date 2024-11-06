using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysTINSClass
    ///começando a classe produto
{
    public class Produto
    {
        public int Id { get; set; }
        public string? CodBar { get; set; }
        public string? Descricao{ get; set;}
         public double ValorUnit { get; set; }
        public string? UnidadeVenda { get; set; }
        public Categoria Categoria { get; set; }
        public double EstoqueMinimo { get; set; }
        public double ClasseDesconto { get; set; }
        public DateTime DataCad { get; set; }

        
        public Produto()
        {
            Categoria = new();
        }

       

        public Produto(int id, string codBar, string? descricao, double valorUnit, string? unidadeVenda, Categoria categoria, double estoqueMinimo, double classeDesconto, DateTime dataCad)
        {

            CodBar = codBar;
            Descricao = descricao;
            ValorUnit = valorUnit;
            UnidadeVenda = unidadeVenda;
            Categoria = categoria;
            EstoqueMinimo = estoqueMinimo;
            ClasseDesconto = classeDesconto;

        }

        public Produto(int id, string codBar, string? descricao, double valorUnit, string? unidadeVenda, Categoria categoria, double estoqueMinimo, double classeDesconto, DateTime dataCad)
        {
            Id = id;
            CodBar = codBar;
            Descricao = descricao;
            ValorUnit = valorUnit;
            UnidadeVenda = unidadeVenda;
            Categoria = categoria;
            EstoqueMinimo = estoqueMinimo;
            ClasseDesconto = classeDesconto;
            DataCad = dataCad;
        }

        
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = " sp_produto_insert";
            cmd.Parameters.AddWithValue("spcod_barras", CodBar);
            cmd.Parameters.AddWithValue("spdescricao", Descricao);
            cmd.Parameters.AddWithValue("spvalor_unit", ValorUnit);
            cmd.Parameters.AddWithValue("spunidade_venda", UnidadeVenda);
            cmd.Parameters.AddWithValue("spcategoria_id", Categoria.Id);
            cmd.Parameters.AddWithValue("spestoque_minimo", EstoqueMinimo);
            cmd.Parameters.AddWithValue("spclasse_desconto", ClasseDesconto);
            Id = Convert.ToInt32 (cmd.ExecuteScalar());
            cmd.Connection.Close();

        }
        public static Produto ObterPorId(int id)
        {
            Produto categoria = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from categorias where id = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                categoria = new(
                    dr.GetString(0),
                    dr.GetString(1),
                    dr.GetString(2),
                     dr.GetDouble(3),
                      dr.GetString(4)),
                      Categoria.ObterPorId(dr.GetInt32(5)
                      );
                      
            }
            return categoria;

            //usuario = new(
               //     dr.GetInt32(0),
               // dr.GetString(1),
               // dr.GetString(2),
               // dr.GetString(3),
               // Nivel.ObterPorId(dr.GetInt32(4)),
               // dr.GetBoolean(5)
               //);
        }

        public static List<Produto> ObterPorLista()
        {
            List <Categoria>  categorias = new();

            return categorias;
        }

        public bool Atualizar()
        {

            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = " sp_produto_update";
            cmd.Parameters.AddWithValue("spcod_barras", CodBar);
            cmd.Parameters.AddWithValue("spdescricao", Descricao);
            cmd.Parameters.AddWithValue("spvalor_unit", ValorUnit);
            cmd.Parameters.AddWithValue("spunidade_venda", UnidadeVenda);
            cmd.Parameters.AddWithValue("spcategoria_id", Categoria.Id);
            cmd.Parameters.AddWithValue("spestoque_minimo", EstoqueMinimo);
            cmd.Parameters.AddWithValue("spclasse_desconto", ClasseDesconto);
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();
            if(cmd.ExecuteReader)


        }


        public void Excluir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("spid", Id);
            cmd.CommandText = " sp_categoria_delete";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }




    }

    
}     

 
   

   

