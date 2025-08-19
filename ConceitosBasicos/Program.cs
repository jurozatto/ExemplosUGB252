//try
//{
//    Console.WriteLine("Informe seu nome: ");
//    string nome = Console.ReadLine();
//    Console.WriteLine("Informe seu salário: ");
//    decimal salario = decimal.Parse(Console.ReadLine());
//    Console.WriteLine("Seja bem-vindo(a) " + nome + ". Seu salário é de R$" + salario);

//    decimal novoSalario = 0;
//    //informe o valor do IRPF a ser pago de acordo com o salário informado. Utilize a tabela real de desconto de IRPF
//    if (salario <= 2259.20m)
//    {
//        Console.WriteLine("Você não paga taxa.");
//    }
//    else if (salario >= 2259.20m && salario <= 2826.65m)
//    {
//        novoSalario = salario - (salario * 0.075m - 169.21m);
//        //Console.WriteLine($"Seu salário com desconto é de {novoSalario:C2}");
//    }
//    else if (salario >= 2826.66m && salario <= 3751.05m)
//    {
//        novoSalario = salario - (salario * 0.15m - 381.44m);
//        //Console.WriteLine($"Seu salário com desconto é de {novoSalario:C2}");
//    }
//    else if (salario >= 3751.06m && salario <= 4664.68m)
//    {
//        novoSalario = salario - (salario * 0.225m - 662.77m);
//        //Console.WriteLine($"Seu salário com desconto é de {novoSalario:C2}");
//    }
//    else
//    {
//        novoSalario = salario - (salario * 0.275m - 896m);
//        //Console.WriteLine($"Seu salário com desconto é de {novoSalario:C2}");
//    }

//    Console.WriteLine($"Para o salário de {salario} o valor a ser pago de IRPF é {novoSalario}, então o salário com desconto será {salario - novoSalario}");
//}

//catch (FormatException)
//{
//    Console.WriteLine("O salário deve ser informado em formato numérico.");
//}

//catch (Exception e)
//{
//    Console.WriteLine("Ocorreu um erro. Contate o suporte técnico.");
//    Console.WriteLine(e.StackTrace);
//}

using ConceitosBasicos.uteis;

SomaDoisNumeros somaDoisNumeros = new SomaDoisNumeros();
int resultado = somaDoisNumeros.Somar(20, 22);
Console.WriteLine(resultado);


int milimetros = MetrosMilimetros.Converter(2);
Console.WriteLine(milimetros);

