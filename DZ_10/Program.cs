// Вариант 1

void Variant1()
{
    Console.Clear();

    Console.Write("Введите трёхзначное число: "); // принимаем значение с консоли
    string? inputLineOne = Console.ReadLine();

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






Variant1();