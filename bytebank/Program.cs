using bytebank;

ContaCorrente contaDoAndre = new ContaCorrente();
contaDoAndre.titular = "André Silva";
contaDoAndre.numero_agencia = 15;
contaDoAndre.conta = "1010-x";
contaDoAndre.saldo = 100;

Console.WriteLine("Saldo do "+ contaDoAndre.titular + "  "+ contaDoAndre.saldo);

ContaCorrente contaDaMaria = new ContaCorrente();
contaDoAndre.titular = "Maria Souza";
contaDoAndre.numero_agencia = 17;
contaDoAndre.conta = "1010-5";
contaDoAndre.saldo = 350;

Console.WriteLine("Saldo do " + contaDaMaria.titular + "  " + contaDaMaria.saldo);

Console.WriteLine("Saldo do André " + contaDoAndre.saldo);