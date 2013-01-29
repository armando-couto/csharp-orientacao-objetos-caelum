using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OiMundo
{
    class ContaCorrente : Conta
    {
        private static int totalDeContas = 0;

        public override void Deposita(double valorASerDepositado)
        {
            this.Saldo += valorASerDepositado;
        }
    }
}
