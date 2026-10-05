Console.WriteLine("===========================   SISTEMA DE CADASTRO  ============================");

Console.WriteLine(" ");

Console.Write("Digite seu Nome:");
string nome = Console.ReadLine();
Console.Write("Digite seu NickName:");
string nickName = Console.ReadLine();
Console.Write("Digite a Plataforma (PC, PS5, XBOX OU SWITCH):");
string plataforma = Console.ReadLine();
Console.Write("Digite o Ano que virou Cliente:");
int anoCliente = int.Parse(Console.ReadLine());
Console.Write("Digite seu Saldo R$:");
double saldo = double.Parse(Console.ReadLine());


Console.WriteLine("===========================   FICHA DO CLIENTE   ============================");

Console.WriteLine(" ");

Console.WriteLine($"Nome: {nome}");
Console.WriteLine($"NickName: {nickName}");
Console.WriteLine($"Plataforma: {plataforma}");
Console.WriteLine($"Cliente desde: {anoCliente}");
Console.WriteLine($"Saldo: R${saldo}");

Console.WriteLine("===========================   DADOS DO JOGO  ============================");

Console.WriteLine(" ");

string nomeJogo = " ";
Console.Write("Digite o nome do Jogo:");
nomeJogo = Console.ReadLine();
Console.Write("Digite a Plataforma (PC, PS5, XBOX OU SWITCH):");
string plataformaJogo = Console.ReadLine();
Console.Write("Digite o valor do Jogo:");
double precoJogo = double.Parse(Console.ReadLine());

Console.WriteLine(" ");
Console.WriteLine(" ");

Console.WriteLine($"Nome do jogo: {nomeJogo} ");
Console.WriteLine($"Plataforma do jogo: {plataformaJogo} ");
Console.WriteLine($"Preço: (R$) {precoJogo:F2}");


if (plataformaJogo == plataforma)
{
    if(precoJogo > saldo)
    {
        Console.WriteLine($"Saldo insulficente! Faltam R$ {precoJogo - saldo}");
    }
    else
    {
        Console.WriteLine($"Pode comprar {nomeJogo}! Sobrariam {saldo - precoJogo}");
    }
}
else
{
    Console.WriteLine("AVISO! A Plataforma não e compativel!");
}

Console.WriteLine(" ");

Console.WriteLine("Quantos jogos você ja tem?");
int quantidadeJogo = int.Parse(Console.ReadLine());

Console.WriteLine($"===========================   BIBLIOTECA DE {nickName}  ============================");
Console.WriteLine(" ");
string[] biblioteca = new string[quantidadeJogo];
for (int i = 0; i < biblioteca.Length; i++)
{
    Console.WriteLine("Qual o nome do jogo?");
    biblioteca[i] = Console.ReadLine().ToLower();
}
Console.WriteLine(" ");

for (int i = 0; i < biblioteca.Length; i++)
{
    Console.WriteLine($"Nome do jogo {i+1}: {biblioteca[i]}");
}
Console.WriteLine(" ");
Console.WriteLine($"Total de jogos: {biblioteca.Length}");


Console.WriteLine("Qual jogo você quer verificar?");
string procurarJogo = Console.ReadLine();

for(int i = 0; i <= biblioteca.Length; i++)
{
    if (nomeJogo == biblioteca[i])
    {
        Console.WriteLine($"Você ja tem {nomeJogo}! Não precisa comprar de novo.");
        break;
    }
    else
    {
        Console.WriteLine($"{nomeJogo} Não esta na sua biblioteca");
        break;
    }
}





