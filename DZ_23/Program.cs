int lineN;
int lineNN;

Console.Write("Введите число: ");
string? inputLineN = Console.ReadLine();     // принимает значения с консоли

void Method1()
{
    if (inputLineN != null)                      // борьба с пустыми ссылками, нужно чтоб программа не ругалась
    {  
        int numberN = int.Parse(inputLineN);    // распознает значения принятые с консоли

        string lineN = "";
        string lineNN = string.Empty;          // string.Empty; = пустая строка = "";
        int s = 1;
        while (s <= numberN)
        {
            lineN = lineN + s + " ";                  // выводит массив по заданому числу
            lineNN = lineNN + (s * s * s) + " ";      // выводит массив куба по заданному числу
            s++;                                      // увеличивает s на 1
        }
        Console.WriteLine(lineN);
        Console.WriteLine(lineNN);
    }
   
}
    
Method1();



