


void Read()
{
    Console.Write("Введите число: ");                               // Принимает значение с консоли, уберает null, расрлзнает значение
    string inputLineNumberA = Console.ReadLine() ?? "";
    int inputNumberA = int.Parse(inputLineNumberA);

    Console.Write("В какую степень возвести число: " + (inputNumberA) + "? ");
    string inputLineNumberB = Console.ReadLine() ?? "";
    int inputNumberB = int.Parse(inputLineNumberB);
}

void Method1()
{
    int i = 1;
    int numC = 0;
    while (i < inputNumberB)                           // Повторяет цикл количество раз inputNumberB
    {
        numC = (numC * inputNumberA);
        i++;
    }
    Console.WriteLine(numC);
}

Read();
Method1();




