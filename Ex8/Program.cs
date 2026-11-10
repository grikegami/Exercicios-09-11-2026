float salario;

Console.WriteLine("Digite o salario desejado: ");
salario = float.Parse(Console.ReadLine());

if (salario <= 2000)
{
    Console.WriteLine("O aumento será de 15%");
    salario = salario + (salario * 0.15f);
}
else if (salario > 2000 && salario <= 4000)
{
    Console.WriteLine("O aumento será de 10%");
    salario = salario + (salario * 0.10f);
}
else if (salario = 0)
{
    Console.WriteLine("Não terá aumento, pois seu salário é 0");
}
else
{
    Console.WriteLine("O aumento será de 5%");
    salario = salario + (salario * 0.05f);
}
