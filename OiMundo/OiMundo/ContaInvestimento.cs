using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OiMundo
{
    class ContaInvestimento : Conta, ITributavel
    {
        public override void Deposita(double valorASerDepositado)
        {
            this.Saldo += valorASerDepositado;
        }

        public double CalculaTributo()
        {
            return this.Saldo * 0.03;
        }
    }
}
