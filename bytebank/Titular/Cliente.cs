using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Titular
{
    public class Cliente
    {
        public Cliente()
        {
            TotalDeCliente++;
        }

        public static int TotalDeCliente { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Profissao { get; set; }


    }
}
