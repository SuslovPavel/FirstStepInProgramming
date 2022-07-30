// программа которая принимает на вход
//число (N) и выдаёт таблицу квадратов чисел от 1 до N
// Пример:5 -> 1, 4, 9, 16, 25.

string? inputLineN = Console.ReadLine();     // принимает значения с консоли

if (inputLineN != null)                      // борьба с пустыми ссылками, нужно чтоб программа не ругалась
{
    int numberN = int.Parse(inputLineN);    // распознает значения принятые с консоли

    string lineN = "";
    string lineNN = string.Empty;          // string.Empty; = пустая строка = "";
    int s = 1;
    while (s <= numberN)
    {
        lineN = lineN + s + " ";              // выводит массив по заданому числу
        lineNN = lineNN + s * s + " ";        // выводит массив квадрата по заданному числу
        s++;                                  // увеличивает s на 1
    }
    Console.WriteLine(lineN);
    Console.WriteLine(lineNN);
}
