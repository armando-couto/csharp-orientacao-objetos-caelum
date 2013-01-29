using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OiMundo
{
    public partial class Form1 : Form
    {

        Conta[] contas;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.nome = "Victor Harada";
            textoTitular.Text = cliente.nome;

            Conta contaDoVictor = new ContaCorrente();
            contaDoVictor.Titular.nome = "Victor";
            contaDoVictor.Numero = 1;
            Conta contaDoMario = new ContaCorrente();
            contaDoMario.Titular.nome = "Mario";
            contaDoMario.Numero = 2;

            this.contas = new Conta[2];
            this.contas[0] = contaDoVictor;
            this.contas[1] = contaDoMario;

            foreach (Conta conta in contas)
            {
                comboContas.Items.Add(conta.Titular);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta c = new ContaCorrente();
            c.Titular = new Cliente(); // funciona, pois titular tem um set
            // c.Saldo = 1000.0; // não funciona, pois saldo é private set
            Console.WriteLine(c.Saldo); // funciona, pois saldo tem get
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cliente guilherme = new Cliente("Guilherme Silveira");

            MessageBox.Show("Nome é: " + guilherme.nome);
            textoTitular.Text = guilherme.nome;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ContaPoupanca c = new ContaPoupanca();
            c.Deposita(400.0); // chama o comportamento escrito no pai
            c.Saca(100.0); // chama o comportamento escrito na própria classe

            MessageBox.Show("Saldo da conta Poupança: "+c.Saldo);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Conta c1 = new ContaCorrente();
            ContaPoupanca c2 = new ContaPoupanca();
            
            TotalizadorDeContas t = new TotalizadorDeContas();
            
            t.Soma(c1);
            t.Soma(c2); // funciona!

            MessageBox.Show("Saldo da Conta Poupança: " + c2.Saldo);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Conta[] contas = new Conta[2];
            contas[0] = new ContaCorrente();
            contas[1] = new ContaPoupanca();

            contas[0].Deposita(300);
            contas[1].Deposita(100);

            foreach (Conta c in contas)
            {
                MessageBox.Show("Saldo: "+c.Saldo);
            }
        }

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceSelecionado = comboContas.SelectedIndex;
            Conta contaSelecionada = contas[indiceSelecionado];
            textoTitular.Text = contaSelecionada.Titular.nome;
            textoSaldo.Text = Convert.ToString(contaSelecionada.Saldo);
            textoNumero.Text = Convert.ToString(contaSelecionada.Numero);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ContaPoupanca cp = new ContaPoupanca();
            ContaInvestimento ci = new ContaInvestimento();

            cp.Deposita(10);
            ci.Deposita(100);

            TotalizadorDeTributos tt = new TotalizadorDeTributos();

            tt.Acumula(cp);
            tt.Acumula(ci);

            MessageBox.Show("Total é: " + tt.Total);
        }
    }
}
