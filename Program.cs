namespace Calculator
{
  class Program
  {
    static void Main()
    {
      Menu();
    }
    static void Menu()
    {
      Console.Clear();
      Console.WriteLine("O que deseja fazer?");
      Console.WriteLine("1 - Somar");
      Console.WriteLine("2 - Subtrair");
      Console.WriteLine("3 - Multiplicar");
      Console.WriteLine("4 - Dividir");
      Console.WriteLine("5 - Sair");
      Console.WriteLine("----------");
      Console.WriteLine("Selecione uma opção: ");
      var userResponse = short.Parse(Console.ReadLine());
      switch (userResponse)
      {
        case 1: Add(); break;
        case 2: Sub(); break;
        case 3: Mul(); break;
        case 4: Div(); break;
        case 5: System.Environment.Exit(0); break;
        default: Menu(); break;
      }
    }
    static void Add()
    {
      Console.Clear();
      Console.WriteLine("Digite o primeiro número:");
      float number1 = float.Parse(Console.ReadLine());
      Console.WriteLine("Digite o segundo número:");
      float number2 = float.Parse(Console.ReadLine());
      Console.WriteLine($"O resultado é: {number1 + number2}");
      Console.ReadKey();
      Menu();
    }
    static void Sub()
    {
      Console.Clear();
      Console.WriteLine("Digite o primeiro número:");
      float number1 = float.Parse(Console.ReadLine());
      Console.WriteLine("Digite o segundo número:");
      float number2 = float.Parse(Console.ReadLine());
      Console.WriteLine($"O resultado é: {number1 - number2}");
      Console.ReadKey();
      Menu();
    }
    static void Mul()
    {
      Console.Clear();
      Console.WriteLine("Digite o primeiro número:");
      float number1 = float.Parse(Console.ReadLine());
      Console.WriteLine("Digite o segundo número:");
      float number2 = float.Parse(Console.ReadLine());
      Console.WriteLine($"O resultado é: {number1 * number2}");
      Console.ReadKey();
      Menu();
    }
    static void Div()
    {
      Console.Clear();
      Console.WriteLine("Digite o primeiro número:");
      float number1 = float.Parse(Console.ReadLine());
      Console.WriteLine("Digite o segundo número:");
      float number2 = float.Parse(Console.ReadLine());
      Console.WriteLine($"O resultado é: {number1 / number2}");
      Console.ReadKey();
      Menu();
    }
  }
}

