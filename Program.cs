string opcaoDesejada;

Console.Clear();

Console.WriteLine("--- Calculadora 4 operações ---\n");

Console.WriteLine("[+] Soma");
Console.WriteLine("[-] Subtração");
Console.WriteLine("[*] Multiplicação");
Console.WriteLine("[/] Divisão");

Console.Write("\nSelecione a operação desejada: ");

opcaoDesejada = Console.ReadLine()!;

switch (opcaoDesejada)
{
    case "+":
        CalcularSoma();
        break;
    case "-":
        CalcularSubtracao();
        break;
    case "*":
        CalcularMultiplicacao();
        break;
    case "/":
        CalcularDivisao();
        break;
    default:
        Console.WriteLine("Opção inválida.");
        break;
}

Console.WriteLine("\nObrigado por utilizar nosso programa.");

void CalcularSoma()
{
    Console.WriteLine("Você selecionou soma");
    double a, b, resultado;

    Console.WriteLine("---  Soma A+B ---\n");
    Console.WriteLine("Digite os valores.");

    Console.Write("A = ");
    a = Convert.ToDouble(Console.ReadLine());
    Console.Write("B = ");
    b = Convert.ToDouble(Console.ReadLine());

    resultado = a + b;

    Console.WriteLine($"{a} mais {b} é {resultado}");

    Console.WriteLine("\nPressione uma tecla para continuar...");
    Console.ReadKey();
    return;
}

void CalcularSubtracao()
{
    Console.WriteLine("Você selecionou subtração");
    double a, b, resultado;

    Console.WriteLine("--- Subtração A-B ---\n");
    Console.WriteLine("Digite os valores.");

    Console.Write("A = ");
    a = Convert.ToDouble(Console.ReadLine());
    Console.Write("B = ");
    b = Convert.ToDouble(Console.ReadLine());

    resultado = a - b;

    Console.WriteLine($"{a} subtraido por {b} é {resultado}");

    Console.WriteLine("\nPressione uma tecla para continuar...");
    Console.ReadKey();
    return;
}

void CalcularMultiplicacao()
{
    double a, b, resultado;

    Console.WriteLine("--- Multiplicação A*B ---\n");
    Console.WriteLine("Digite os valores.");

    Console.Write("A = ");
    a = Convert.ToDouble(Console.ReadLine());
    Console.Write("B = ");
    b = Convert.ToDouble(Console.ReadLine());

    resultado = a * b;

    Console.WriteLine($"{a} multiplicado por {b} é {resultado}");

    Console.WriteLine("\nPressione uma tecla para continuar...");
    Console.ReadKey();

    return;
}

void CalcularDivisao()
{
    Console.WriteLine("Você selecionou divisao");
    double a, b, resultado;

    Console.WriteLine("--- Divisão A/B ---\n");
    Console.WriteLine("Digite os valores.");

    Console.Write("A = ");
    a = Convert.ToDouble(Console.ReadLine());
    Console.Write("B = ");
    b = Convert.ToDouble(Console.ReadLine());

    if (b == 0)
    {
        Console.WriteLine("Não é possivel dividir por 0!");
    }
    else{
        resultado = a / b;
        Console.WriteLine($"{a} dividido por {b} é {resultado}");
    }



    Console.WriteLine("\nPressione uma tecla para continuar...");
    Console.ReadKey();
    return;
}

