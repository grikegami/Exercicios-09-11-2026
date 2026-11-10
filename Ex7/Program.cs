float peso, altura;

Console.WriteLine("Digite seu peso: ");
peso = float.Parse(Console.ReadLine());

Console.WriteLine("Digite sua altura (Em centímetros): ");
altura = float.Parse(Console.ReadLine());

float imc = peso / ((altura / 100) * (altura / 100));

Console.WriteLine($"Seu IMC é: {imc}");