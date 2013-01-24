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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.nome = "Victor Harada";
            textoTitular.Text = cliente.nome;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta c = new Conta();
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
            Conta c1 = new Conta();
            ContaPoupanca c2 = new ContaPoupanca();
            
            TotalizadorDeContas t = new TotalizadorDeContas();
            
            t.Soma(c1);
            t.Soma(c2); // funciona!

            MessageBox.Show("Saldo da Conta Poupança: " + c2.Saldo);
        }
    }
}
