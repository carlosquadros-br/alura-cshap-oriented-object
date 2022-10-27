using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank
{
    public class ContaCorrente
    {
        public int numero_agencia;
        public string conta;
        public double saldo = 100;

        public Cliente titular;

        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (valor > saldo)
                return false;       
            saldo -= valor;
            return true;
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
                return false;
            Sacar(valor);
            destino.Depositar(valor);
            return true;
        }
    }
}
