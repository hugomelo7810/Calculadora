bool desejaContinuar = true;
while (desejaContinuar == true)
{
    Console.WriteLine("Seja bem-vindo a nossa calculadora!");
    Console.Write("\nDigite seu primeiro número: ");
    double primeiroNum = double.TryParse(Console.ReadLine(), out primeiroNum) ? primeiroNum : 0;
    Console.Write("\nDigite seu segundo número número: ");
    double segundoNum = double.TryParse(Console.ReadLine(), out segundoNum) ? segundoNum : 0;
    Console.Write("\nDigite sua operação(/, *, +, -): ");
    string operacao = Console.ReadLine();
    double resultado = 0;

    void Multiplicacao()
    {
        resultado = primeiroNum * segundoNum;
    }

    void Subtracao()
    {
        resultado = primeiroNum - segundoNum;
    }

    void Adicao()
    {
        resultado = primeiroNum + segundoNum;
    }

    void Divisao()
    {
        if (segundoNum == 0)
        {
            Console.WriteLine("Seu segundo número não pode ser 0 para essa operação, digite outro");
            segundoNum = double.TryParse(Console.ReadLine(), out segundoNum) ? segundoNum : 0;
        }
        else
        {
            resultado = primeiroNum / segundoNum;
        }
    }

    switch (operacao)
    {
        case ("*"):
            Multiplicacao();
            break;
        case ("-"):
            Subtracao();
            break;
        case ("+"):
            Adicao();
            break;
        case ("/"):
            Divisao();
            break;
        default:
            Console.WriteLine("Operação inválida");
            break;
    }

    Console.WriteLine($"Seus números: {primeiroNum}, {segundoNum}, sua operação {operacao}.");
    Console.WriteLine($"Seu resultado foi {resultado}");
    bool operacaoValida = false;
    while (operacaoValida == false)
    {
        Console.WriteLine("Deseja fazer outra operação? (sim ou não)");
        string outraOperacao = Console.ReadLine().ToUpper();

        switch (outraOperacao)
        {
            case "SIM":
                Console.WriteLine("Começando outra operação");
                Thread.Sleep(2500);
                Console.Clear();
                operacaoValida = true;
                break;

            case "NÃO":
                Console.WriteLine("Fechando calculadora");
                Thread.Sleep(2500);
                operacaoValida = true;
                desejaContinuar = false;
                break;

            default:
                Console.WriteLine("Digite corretamente (sim ou não)");
                outraOperacao = Console.ReadLine().ToUpper();
                operacaoValida = true;
                if(outraOperacao == "SIM")
                {
                    desejaContinuar = true;
                    Console.Clear();
                }
                if (outraOperacao == "NÃO")
                {
                    desejaContinuar = false;
                }
                break;

        }
    }
}