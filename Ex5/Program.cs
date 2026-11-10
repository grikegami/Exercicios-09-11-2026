int ano;

Console.WriteLine("Digite um ano para verificar se é bissexto:");
ano = int.Parse(Console.ReadLine());

if ((ano % 4 == 0) && (ano % 100 != 0 || ano % 400 == 0))
{
    Console.WriteLine(ano + " é um ano bissexto.");
}
else
{
    Console.WriteLine(ano + " não é um ano bissexto.");
}