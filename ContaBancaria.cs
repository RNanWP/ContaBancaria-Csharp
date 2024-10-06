using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public class ContaBancaria
    {
        public long NumeroConta { get; private set; }
        public string Titular { get; set; }
        private decimal Saldo;

        public ContaBancaria(long numeroConta, string titular)
        {
            NumeroConta = numeroConta;
            Titular = titular;
            Saldo = 0;
        }

        public void Depositar(decimal valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                MessageBox.Show($"Depósito de R$ {valor} realizado com sucesso.");
            }
            else
            {
                MessageBox.Show("O valor de depósito deve ser positivo.");
            }
        }

        public void Sacar(decimal valor)
        {
            if (valor > 0)
            {
                if (Saldo >= valor)
                {
                    Saldo -= valor;
                    MessageBox.Show($"Saque de R$ {valor} realizado com sucesso.");
                }
                else
                {
                    MessageBox.Show("Saldo insuficiente para realizar o saque.");
                }
            }
            else
            {
                MessageBox.Show("O valor de saque deve ser positivo.");
            }
        }

        public decimal ConsultarSaldo()
        {
            return Saldo;
        }
    }
}