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

        public bool PodeAbrirContaSozinho
        {
            get
            {
                var maiorDeIdade = this.idade >= 18;
                // var emancipado = this.documentos.contains("emancipacao");
                var possuiCPF = !string.IsNullOrEmpty(this.cpf);
                // return (maiorDeIdade || emancipado) && possuiCPF;
                return maiorDeIdade && possuiCPF;
            }
        }
    }
}
