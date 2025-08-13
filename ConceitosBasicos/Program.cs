Console.WriteLine("Informe seu nome: ");
string nome = Console.ReadLine();
Console.WriteLine("Informe seu salário: ");
decimal salario = decimal.Parse(Console.ReadLine());
Console.WriteLine("Seja bem-vindo(a) " + nome + ". Seu salário é de R$" + salario);

//informe o valor do IRPF a ser pago de acordo com o salário informado. Utilize a tabela real de desconto de IRPF
if (salario <= 2259.20m)
{
    Console.WriteLine("Você não paga taxa.");
}
else if (salario >= 2259.20m && salario <= 2826.65m)
{
    decimal novoSalario = salario - (salario * 0.075m);
    Console.WriteLine($"Seu salário com desconto é de {novoSalario:C2}");
}
else if (salario >= 2826.66m && salario <= 3751.05m)
{
    decimal novoSalario = salario - (salario * 0.15m);
    Console.WriteLine($"Seu salário com desconto é de {novoSalario:C2}");
}
else if (salario >= 3751.06m && salario <= 4664.68m)
{
    decimal novoSalario = salario - (salario * 0.225m);
    Console.WriteLine($"Seu salário com desconto é de {novoSalario:C2}");
}
else
{
    decimal novoSalario = salario - (salario * 0.275m);
    Console.WriteLine($"Seu salário com desconto é de {novoSalario:C2}");
}