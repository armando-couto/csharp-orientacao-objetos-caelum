using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OiMundo
{
    class Cliente
    {
        public string nome { get; set; }
        public string cpf { get; set; }
        public string rg { get; set; }
        public string endereco { get; set; }
        public int idade { get; set; }

        public Cliente()
        {
        }

        public Cliente(string nome)
        {
            this.nome = nome;
        }

        public bool EhMaiorDeIdade()
        {
            return idade >= 18;
        }
    }
}
