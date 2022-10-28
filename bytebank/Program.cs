using bytebank.Contas;
using bytebank.Titular;

ContaCorrente conta4 = new(18, "1010-X");
conta4.SetSaldo(500);
conta4.Titular = new();

Console.WriteLine(conta4.GetSaldo());
Console.WriteLine(conta4.Numero_agencia);

ContaCorrente conta5 = new ContaCorrente(283, "1234-X");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
ContaCorrente conta6 = new ContaCorrente(283, "1234-X");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
ContaCorrente conta7 = new ContaCorrente(283, "1234-X");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
Console.WriteLine($"Total de clientes {Cliente.TotalDeCliente}");