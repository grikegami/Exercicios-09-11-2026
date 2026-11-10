float peso, altura;

Console.WriteLine("Digite seu peso: ");
peso = float.Parse(Console.ReadLine());

Console.WriteLine("Digite sua altura (Em centímetros): ");
altura = float.Parse(Console.ReadLine());

float imc = peso / ((altura / 100) * (altura / 100));

Console.WriteLine($"Seu IMC é: {imc}");

if (imc < 18.5)
{
    Console.WriteLine("Você está abaixo do peso.");
}
else if (imc >= 18.5 && imc < 24.9)
{
    Console.WriteLine("Você está com o peso normal.");
}
else if (imc >= 25 && imc < 29.9)
{
    Console.WriteLine("Você está com sobrepeso.");
}
else
{
    Console.WriteLine("Você está com obesidade.");
}