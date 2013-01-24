using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OiMundo
{
    class ContaPoupanca : Conta
    {
        public override void Deposita(double valorASerDepositado)
        {
            this.Saldo += valorASerDepositado;
        }
    }
}