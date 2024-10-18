using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysTINSClass
{
    public class Nivel
    {
        public int id {  get; set; }
        public string? name { get; set; }
        public string? Sigla { get; set; }
        public Nivel() { } //Método construtor (new) chamando o metodo contrutor

        public Nivel(int id, string? name, string? sigla)
        {
            this.id = id;
            this.name = name;
            Sigla = sigla;
        }
    }
}
