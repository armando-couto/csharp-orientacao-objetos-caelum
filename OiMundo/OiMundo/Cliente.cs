using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OiMundo
{
    class Cliente
    {
        public string nome;
        public string cpf;
        public string rg;
        public string endereco;
        public int idade;

        public bool EhMaiorDeIdade()
        {
            return idade >= 18;
        }
    }
}
