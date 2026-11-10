int x = 0;

Console.WriteLine("Digite um número inteiro: ");
x = int.Parse(Console.ReadLine());

if (x % 2 == 0)
{
    Console.WriteLine("O número digitado é par!");
}

else 
{ 
    Console.WriteLine("O número digitado é impar!");
}