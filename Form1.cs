using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private ContaBancaria conta;

        public Form1()
        {
            InitializeComponent();
            conta = new ContaBancaria(2222200490L, "Renan Santos de Oliveira");
            AtualizarSaldo();
        }

        private void AtualizarSaldo()
        {
            labelSaldo.Text = $"R$ {conta.ConsultarSaldo()}";
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBoxDeposito.Text, out decimal valorDeposito))
            {
                conta.Depositar(valorDeposito);
                AtualizarSaldo();
            }
            else
            {
                MessageBox.Show("Por favor, insira um valor válido para depósito.");
            }
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBoxSaque.Text, out decimal valorSaque))
            {
                conta.Sacar(valorSaque);
                AtualizarSaldo();
            }
            else
            {
                MessageBox.Show("Por favor, insira um valor válido para saque.");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
