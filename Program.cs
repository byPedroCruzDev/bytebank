
using bytebank.Contas;
using bytebank.Titular;
/* Importação de classe 
Chamada e intanciamento de valor 
ContaCorrente contaAndre = new ContaCorrente();
contaAndre.titular = "André jonsom";
contaAndre.numero_agencia = 15;
contaAndre.conta = "1010-X";
contaAndre.saldo = 100;

ContaCorrente contaMaria = new ContaCorrente();
contaMaria.titular = "Maria morsa";
contaMaria.numero_agencia = 22;
contaMaria.conta = "1515-x";
contaMaria.saldo = 0;

contaAndre.Tranferir(80, contaMaria);
Console com interpolação de valores
Console.WriteLine($"Saldo da conta do {contaAndre.titular}: R${contaAndre.saldo} ");



Console.WriteLine($"Saldo da conta do {contaMaria.titular}: R${contaMaria.saldo} ");

ContaCorrente contaPedro = new ContaCorrente();
contaPedro.titular = "Pedrin Borba"
Console.WriteLine(contaPedro.titular);
Console.WriteLine(contaPedro.numero_agencia);
Console.WriteLine(contaPedro.conta);
Console.WriteLine(contaPedro.saldo);
*/
 //tipos por valor
/* double valor = 3000;
double valor2 = valor;

Console.WriteLine(valor==valor2); */

/* 
Client client = new Client();
client.nome = "Pedrin Borba";
client.cpf = "000522832-26";
client.profissao = "dev jr";

ContaCorrente contaPedrin = new ContaCorrente();
contaPedrin.titular = client;
contaPedrin.numero_agencia = 15;
contaPedrin.conta = "xxx-x";
contaPedrin.saldo = 25;

/* ContaCorrente conta2 = new ContaCorrente();
conta2.Titular = new Client();
conta2.Titular.Nome = "Pedrin borba";
conta2.Titular.Cpf = "051845488";
conta2.Titular.Profissao = "Web dev";
conta2.Numeero_agencia = 15; 
conta2.Conta = "1547-x";
conta2.SetSaldo(1000);
 */

//Console.WriteLine($"Saldo da conta do {conta2.Titular.Nome}: R${conta2.GetSaldo()}, Profissão: {conta2.Titular.Profissao}");


ContaCorrente conta4 = new ContaCorrente(18, "1515-b");
conta4.SetSaldo(500);
conta4.Titular = new Client();


ContaCorrente conta5 = new ContaCorrente(18, "1515-b");
conta5.SetSaldo(500);
conta5.Titular = new Client();

 
ContaCorrente conta6 = new ContaCorrente(18, "1515-b");
conta5.SetSaldo(500);
conta5.Titular = new Client();

Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
