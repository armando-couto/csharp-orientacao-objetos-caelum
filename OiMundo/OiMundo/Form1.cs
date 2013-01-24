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

        private void button1_Click(object sender, EventArgs e)
        {
            Conta c = new Conta();
            c.Titular = new Cliente(); // funciona, pois titular tem um set
            // c.Saldo = 1000.0; // não funciona, pois saldo é private set
            Console.WriteLine(c.Saldo); // funciona, pois saldo tem get
        }
    }
}
