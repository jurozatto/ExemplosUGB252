Console.WriteLine("Informe seu nome: ");
string nome = Console.ReadLine();
Console.WriteLine("Informe seu salário: ");
decimal salarioStr = decimal.Parse(Console.ReadLine());
Console.WriteLine("Seja bem-vindo(a) " + nome + ". Seu salário é de R$" + salarioStr);