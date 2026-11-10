
int valor1, valor2;


Console.WriteLine("Digite um valor: ");
valor1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite um valor: ");
valor2 = int.Parse(Console.ReadLine());

if (valor1 > valor2)
{
    Console.WriteLine($"{valor1} é maior que {valor2}");
}
else if (valor1 < valor2)
{
    Console.WriteLine($"{valor1} é menor que {valor2}");
}
else
{
    Console.WriteLine($"{valor1} e {valor2} são iguais");
}
