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

        public int codbarras;
        public int descricao;
        public int unidadevenda;
        public int categoriaid;
        public int estoqueminimo;
        public double classedesconto;
        public Produto produto;


        public Produto(int Codbarras, int Descricao, int Unidadevenda, int Categoriaid, int EstoqueMinimo, int Classedesconto)
        {

           
            codbarras = Codbarras;
            descricao = Descricao;
            unidadevenda = Unidadevenda;
            categoriaid = Categoriaid;
            estoqueminimo = EstoqueMinimo;
            classedesconto = Classedesconto;
           

        }
        
        public static Produto InserirProduto()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_produto_insert";
            cmd.Parameters.Add("spnome", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = 
            cmd.Parameters.AddWithValue("Cod_barras",
            cmd.Parameters.AddWithValue("spsenha", Senha);
            cmd.Parameters.AddWithValue("spnivel", Nivel.Id);
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Id = dr.GetInt32(0);
            }
            cmd.Connection.Close();


            return produto;
        }
        

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"insert produtos (descricao ,valor_unit)  values('Parabrisa','240R$')";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();


        }
    }

    
}     

 
   

   

