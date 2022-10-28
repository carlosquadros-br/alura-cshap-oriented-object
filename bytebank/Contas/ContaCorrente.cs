using bytebank.Titular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Contas
{
    public class ContaCorrente
    {

        public ContaCorrente(int numero_agencia, string numero_conta)
        {
            this.Numero_agencia = numero_agencia;
            this.Conta = numero_conta;
            TotalDeContasCriadas++;
        }
        private int _numero_agencia;
        public int Numero_agencia
        {
            get { return _numero_agencia; }
            private set
            {
                if (value > 0)
                {
                    _numero_agencia = value;
                }
            }
        }

        public static int TotalDeContasCriadas { get; set; }
        public string Conta { get; set; }
        private double _saldo = 100;

        public Cliente Titular { get; set; }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (valor > _saldo)
                return false;
            _saldo -= valor;
            return true;
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (_saldo < valor)
                return false;
            Sacar(valor);
            destino.Depositar(valor);
            return true;
        }

        public void SetSaldo(double valor)
        {
            if (valor < 0)
                return;
            _saldo = valor;
        }

        public double GetSaldo()
        {
            return _saldo;
        }
    }
}
