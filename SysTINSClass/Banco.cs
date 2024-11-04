using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysTINSClass
{ //clase banco é a nossa classe de conexão
    public static class Banco //pois não precisaremos criar uma instancia de banco para conectar às nossas bases de dados
    {
        
         public static MySqlCommand Abrir()
         {
            string strcon = @"server=127.0.0.1;database=systinsdb01;user=root;password=";
            MySqlConnection cn = new(strcon);
            MySqlCommand cmd = new();
            try
            {
                cn.Open();
                cmd.Connection = cn;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
                
            }
            return cmd;

         }


    }
}
