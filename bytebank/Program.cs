using bytebank;

/*ContaCorrente contaDoAndre = new();
contaDoAndre.titular = "André Silva";
contaDoAndre.numero_agencia = 15;
contaDoAndre.conta = "1010-x";
contaDoAndre.saldo = 100;

Console.WriteLine("Saldo do "+ contaDoAndre.titular + "  "+ contaDoAndre.saldo);

ContaCorrente contaDaMaria = new();
contaDaMaria.titular = "Maria Souza";
contaDaMaria.numero_agencia = 17;
contaDaMaria.conta = "1010-5";
contaDaMaria.saldo = 350;

Console.WriteLine("Saldo da " + contaDaMaria.titular + "  " + contaDaMaria.saldo);

contaDoAndre.Transferir(50, contaDaMaria);

Console.WriteLine("Depois da transferencia");
Console.WriteLine("Saldo do " + contaDoAndre.titular + "  " + contaDoAndre.saldo);
Console.WriteLine("Saldo da " + contaDaMaria.titular + "  " + contaDaMaria.saldo);
*/

/*double valor = 300;
double valor2 = valor;

Console.WriteLine(valor == valor2);
Console.WriteLine(valor);
Console.WriteLine(valor2);*/



ContaCorrente contaDoAndre = new();
contaDoAndre.titular = "André Silva";
contaDoAndre.numero_agencia = 15;
contaDoAndre.conta = "1010-x";
contaDoAndre.saldo = 100;

Console.WriteLine("Saldo do " + contaDoAndre.titular + "  " + contaDoAndre.saldo);


ContaCorrente contaDoAndre2 = new();
contaDoAndre2.titular = "André Silva";
contaDoAndre2.numero_agencia = 15;
contaDoAndre2.conta = "1010-x";
contaDoAndre2.saldo = 100;

Console.WriteLine("Saldo do " + contaDoAndre2.titular + "  " + contaDoAndre2.saldo);

contaDoAndre = contaDoAndre2;

Console.WriteLine(contaDoAndre == contaDoAndre2);
