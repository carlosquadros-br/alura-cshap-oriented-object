using bytebank.Contas;
using bytebank.Titular;

ContaCorrente conta4 = new(18, "1010-X");
conta4.SetSaldo(500);
conta4.Titular = new();

Console.WriteLine(conta4.GetSaldo());
Console.WriteLine(conta4.Numero_agencia);
