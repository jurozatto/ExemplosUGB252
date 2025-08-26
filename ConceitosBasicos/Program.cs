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


class Program
{
    static void Main()
    {
        Console.WriteLine("Escolha um método para executar:");
        Console.WriteLine("1. Soma de dois números");
        Console.WriteLine("2. Converter metros em milimetros");
        Console.WriteLine("3. Calcular o aumento do salário");

        Console.WriteLine("Digite o número da opção: ");
        int escolha = int.Parse(Console.ReadLine());

        switch (escolha)
        {
            case 1:
                SomaDoisNumeros somaDoisNumeros = new SomaDoisNumeros();
                Console.WriteLine("Digite o primeiro número: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo número: ");
                int num2 = int.Parse(Console.ReadLine());
                int resultado = somaDoisNumeros.Somar(num1, num2);
                Console.WriteLine($"O resultado da soma é {resultado}");
                break;

            case 2:
                MetrosMilimetros metrosMilimetros = new MetrosMilimetros();
                Console.WriteLine("Digite a quantidade em metros: ");
                int num3 = int.Parse(Console.ReadLine());
                int milimetros = MetrosMilimetros.Converter(num3);
                Console.WriteLine(milimetros); ;
                break;

            case 3:
                CalculaAumento calculaAumento = new CalculaAumento();
                Console.WriteLine("Informe seu salário: ");
                decimal salario = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Informe seu percentual de aumento: ");
                float percentual = float.Parse(Console.ReadLine());
                decimal percentualAumento = calculaAumento.Calcular(salario, percentual);
                Console.WriteLine($"Para o salário {salario:c2}, o aumento de {percentual}% corresponde a {percentualAumento:c2}");
                Console.WriteLine($"O novo salário é {salario + percentualAumento:c2}"); ;
                break;

        }
    }

}



//SomaDoisNumeros somaDoisNumeros = new SomaDoisNumeros();
//int resultado = somaDoisNumeros.Somar(20, 50);
//Console.WriteLine(resultado);


//int milimetros = MetrosMilimetros.Converter(50);
//Console.WriteLine(milimetros);


//CalculaAumento calculaAumento = new CalculaAumento();
//Console.WriteLine("Informe seu salário: ");
//decimal salario = Convert.ToDecimal(Console.ReadLine());
//Console.WriteLine("Informe seu percentual de aumento: ");
//float percentual = float.Parse(Console.ReadLine());
//decimal percentualAumento = calculaAumento.Calcular(salario, percentual);
//Console.WriteLine($"Para o salário {salario:c2}, o aumento de {percentual}% corresponde a {percentualAumento:c2}");
//Console.WriteLine($"O novo salário é {salario + percentualAumento:c2}");



