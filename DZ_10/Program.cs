// Вариант 1

void Variant1()
{
    Console.Clear();

    Console.Write("Введите трёхзначное число: "); // принимаем значение с консоли
    string? inputLineOne = Console.ReadLine()?? "";

    char[]M = inputLineOne.ToCharArray();        // преобразуем значение в массив
    if( M.Length != 3)                           // выставляем условие что длина массива не более 3х элементов
    {
        Console.Write("Ошибка! Введено неверное число");
    }
    else
    {
        Console.Write("Вторая цифра числа: ");
        Console.WriteLine(M[1]);
    }
}

//Вариант 2

void variant2()
{
    //Console.Clear();
    Console.Write("Введите трёхзначное число: "); // принимаем значение с консоли
    string? inputLineOne = Console. ReadLine()?? "";

    int NumberOne =int.Parse(inputLineOne);      // создание переменной
    int NumberTwo =(NumberOne%100)/10;           // вычисление второй цифры из введёного числа
    if(NumberOne < 100 || NumberOne > 999)       // проверка введёного числа
    {
        Console.Write("Ошибка! Введено неверное число");
    }
    else
    {
        Console.Write("Вторая цифра числа: ");
        Console.Write(NumberTwo);
    }

}


Variant1();

variant2();

// Одновременно оба варианта не ратотают, один приходится отключать. Подскажите пожалуйста как это исправить