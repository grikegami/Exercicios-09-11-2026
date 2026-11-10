int idade;

Console.WriteLine("Digite sua idade: ");
idade = int.Parse(Console.ReadLine());

if (idade <= 12)
{
    Console.WriteLine("Você é uma criança!");
}
else if (idade > 12 && idade < 18)
{
    Console.WriteLine("Você é um(a) adolescente!");
}
else if (idade >= 18 && idade < 60)
{
    Console.WriteLine("Você é um(a) adulto!");
}
else
{
    Console.WriteLine("Você é um(a) idoso!");
}
