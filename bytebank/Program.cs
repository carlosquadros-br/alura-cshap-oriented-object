using bytebank.Contas;
using bytebank.Titular;

//Aula 2
ContaCorrente contaDoAndre = new();
//contaDoAndre.titular = "André Silva";
contaDoAndre.numero_agencia = 15;
contaDoAndre.conta = "1010-x";
contaDoAndre.saldo = 100;

Console.WriteLine("Saldo do "+ contaDoAndre.titular + "  "+ contaDoAndre.saldo);

//Aula 3
ContaCorrente contaDaMaria = new();
//contaDaMaria.titular = "Maria Souza";
contaDaMaria.numero_agencia = 17;
contaDaMaria.conta = "1010-5";
contaDaMaria.saldo = 350;

Console.WriteLine("Saldo da " + contaDaMaria.titular + "  " + contaDaMaria.saldo);

contaDoAndre.Transferir(50, contaDaMaria);

Console.WriteLine("Depois da transferencia");
Console.WriteLine("Saldo do " + contaDoAndre.titular + "  " + contaDoAndre.saldo);
Console.WriteLine("Saldo da " + contaDaMaria.titular + "  " + contaDaMaria.saldo);

//Aula 4

double valor = 300;
double valor2 = valor;

Console.WriteLine(valor == valor2);
Console.WriteLine(valor);
Console.WriteLine(valor2);



ContaCorrente contaDoAndre2 = new();
//contaDoAndre2.titular = "André Silva";
contaDoAndre2.numero_agencia = 15;
contaDoAndre2.conta = "1010-x";
contaDoAndre2.saldo = 100;

Console.WriteLine("Saldo do " + contaDoAndre.titular + "  " + contaDoAndre.saldo);


ContaCorrente contaDoAndre3 = new();
//contaDoAndre3.titular = "André Silva";
contaDoAndre3.numero_agencia = 15;
contaDoAndre3.conta = "1010-x";
contaDoAndre3.saldo = 100;

Console.WriteLine("Saldo do " + contaDoAndre3.titular + "  " + contaDoAndre2.saldo);

contaDoAndre3 = contaDoAndre2;

Console.WriteLine(contaDoAndre3 == contaDoAndre2);

//Aula 4

Cliente cliente = new();
cliente.nome = "André Silva";
cliente.CPF = "123456789";
cliente.profissao = "Vendedor";

ContaCorrente conta = new();
conta.titular = cliente;
conta.conta = "1010-X";
conta.numero_agencia = 15;
conta.saldo = 100;

Console.WriteLine("Titular = "
    + conta.titular.nome);
Console.WriteLine("CPF = "
    + conta.titular.CPF);
Console.WriteLine("Profissao = "
    + conta.titular.profissao);
Console.WriteLine("Nº Conta = "
    + conta.conta);
Console.WriteLine("Saldo = "
    + conta.saldo);
Console.WriteLine("Nº Agencia = "
    + conta.numero_agencia);