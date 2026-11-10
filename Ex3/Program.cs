float nota1, nota2, nota3, nota4;

Console.WriteLine("Digite a nota de cada bimestre em sequência (Total: 4): ");
nota1 = float.Parse(Console.ReadLine());
Console.WriteLine("Próxima nota");
nota2 = float.Parse(Console.ReadLine());
Console.WriteLine("Próxima nota");
nota3 = float.Parse(Console.ReadLine());
Console.WriteLine("Próxima nota");
nota4 = float.Parse(Console.ReadLine());
Console.WriteLine("Todas as notas foram digitadas!");

float media = (nota1 + nota2 + nota3 + nota4) / 4;

Console.WriteLine($"Média obtida: {media}");

if (media >= 0 && media <= 10)
{
    if (media >= 7)
    {
        Console.WriteLine("O aluno está aprovado!");
    }
    else if (media > 5)
    {
        Console.WriteLine("O aluno está de recuperação!");
    }
    else
    {
        Console.WriteLine("O aluno está reprovado!");
    }
}
else
{
    Console.WriteLine("A média não está entre 0 e 10.");
}