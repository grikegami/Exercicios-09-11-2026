int lado1, lado2, lado3;

Console.WriteLine("Digite o valor do lado 1: ");
lado1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor do lado 2: ");
lado2 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor do lado 3: ");
lado3 = int.Parse(Console.ReadLine());

if (lado1 <= 0 || lado2 <= 0 || lado3 <= 0)
{
    Console.WriteLine("Os lados do triângulo devem ser maiores que zero.");
}
else if (lado1 + lado2 <= lado3 || lado1 + lado3 <= lado2 || lado2 + lado3 <= lado1)
{
    Console.WriteLine("Os valores fornecidos não formam um triângulo válido.");
}
else
{
    if (lado1 == lado2 && lado2 == lado3)
    {
        Console.WriteLine("O triângulo é equilátero.");
    }
    else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
    {
        Console.WriteLine("O triângulo é isósceles.");
    }
    else
    {
        Console.WriteLine("O triângulo é escaleno.");
    }
}