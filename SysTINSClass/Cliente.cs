using Org.BouncyCastle.Cms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    public class Cliente
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public int cpf { get; set; }


    }
}
